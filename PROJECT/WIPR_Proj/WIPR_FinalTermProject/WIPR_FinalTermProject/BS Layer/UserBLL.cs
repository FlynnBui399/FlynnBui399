using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class UserBLL
    {
        private DBMain db = new DBMain();
        
        public static DataRow CurrentUserData { get; private set; }
        
        // Convenience properties for accessing current user information
        public static class CurrentUser
        {
            public static int? UserID => CurrentUserData != null ? 
                (CurrentUserData["UserID"] != DBNull.Value ? Convert.ToInt32(CurrentUserData["UserID"]) : (int?)null) : null;
            
            public static string Username => CurrentUserData?["Username"]?.ToString() ?? "";
            
            public static string FullName => CurrentUserData?["FullName"]?.ToString() ?? "";
            
            public static string Email => CurrentUserData?["Email"]?.ToString() ?? "";
            
            public static DateTime? CreatedDate => CurrentUserData != null && CurrentUserData["CreatedDate"] != DBNull.Value ? 
                Convert.ToDateTime(CurrentUserData["CreatedDate"]) : (DateTime?)null;
            
            public static DateTime? LastLoginDate => CurrentUserData != null && CurrentUserData["LastLoginDate"] != DBNull.Value ? 
                Convert.ToDateTime(CurrentUserData["LastLoginDate"]) : (DateTime?)null;
            
            public static string Role => CurrentUserData != null && CurrentUserData.Table.Columns.Contains("Role") ? 
                CurrentUserData["Role"]?.ToString() ?? "user" : "user";
        }
        
        // Helper methods for SQL string formatting
        private string EscapeString(string input)
        {
            if (input == null) return "NULL";
            return "N'" + input.Replace("'", "''") + "'";
        }

        private string FormatDateTime(DateTime dateTime)
        {
            return "'" + dateTime.ToString("yyyy-MM-dd HH:mm:ss") + "'";
        }
        
        // Login verification
        public bool Login(string username, string password)
        {
            try
            {
                // Hash password
                string hashedPassword = HashPassword(password);
                
                string sql = $"SELECT * FROM Users WHERE Username = {EscapeString(username)} AND Password = {EscapeString(hashedPassword)}";
                
                DataTable dt = db.ExecuteQuery(sql);
                
                if (dt.Rows.Count > 0)
                {
                    // Save current user information as DataRow
                    CurrentUserData = dt.Rows[0];
                    
                    // Update last login time
                    UpdateLastLoginDate(CurrentUser.UserID ?? 0);
                    
                    return true;
                }
                
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Logout
        public void Logout()
        {
            CurrentUserData = null;
        }
        
        // Register new user
        public bool Register(string username, string password, string fullName, string email, string role = "user")
        {
            try
            {
                // Check if username already exists
                if (IsUsernameExists(username))
                {
                    return false;
                }
                
                // Check if email already exists
                if (IsEmailExists(email))
                {
                    return false;
                }
                
                // Hash password
                string hashedPassword = HashPassword(password);
                
                // Check if the Role column exists in the Users table
                bool roleColumnExists = CheckIfRoleColumnExists();
                
                string sql;
                
                if (roleColumnExists)
                {
                    sql = $@"INSERT INTO Users (Username, Password, FullName, Email, CreatedDate, LastLoginDate, Role) 
                           VALUES ({EscapeString(username)}, {EscapeString(hashedPassword)}, {EscapeString(fullName)}, {EscapeString(email)}, {FormatDateTime(DateTime.Now)}, {FormatDateTime(DateTime.Now)}, {EscapeString(role)})";
                }
                else
                {
                    // If Role column doesn't exist, use the original query
                    sql = $@"INSERT INTO Users (Username, Password, FullName, Email, CreatedDate, LastLoginDate) 
                           VALUES ({EscapeString(username)}, {EscapeString(hashedPassword)}, {EscapeString(fullName)}, {EscapeString(email)}, {FormatDateTime(DateTime.Now)}, {FormatDateTime(DateTime.Now)})";
                }
                
                int result = db.ExecuteNonQuery(sql);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Request password reset
        // Returns a reset code if email exists, otherwise returns null
        public string RequestPasswordReset(string email)
        {
            try
            {
                // Check if email exists and get specific user count
                string countSql = $"SELECT COUNT(*) FROM Users WHERE Email = {EscapeString(email)}";
                int userCount = Convert.ToInt32(db.ExecuteScalar(countSql));
                
                if (userCount == 0)
                {
                    return null; // Email doesn't exist
                }
                
                if (userCount > 1)
                {
                    // Multiple users with same email - this should not happen with unique constraint
                    // But handle gracefully if legacy data exists
                    return null;
                }
                
                // Generate a random reset code (6 digit number)
                Random random = new Random();
                string resetCode = random.Next(100000, 999999).ToString();
                
                // Send reset code via email
                bool emailSent = WIPR_FinalTermProject.Classes.EmailHelper.SendPasswordResetCode(email, resetCode);
                
                if (emailSent)
                {
                    return resetCode;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        // Reset password using email
        public bool ResetPassword(string email, string newPassword)
        {
            try
            {
                // First ensure only one user exists with this email
                string countSql = $"SELECT COUNT(*) FROM Users WHERE Email = {EscapeString(email)}";
                int userCount = Convert.ToInt32(db.ExecuteScalar(countSql));
                
                if (userCount != 1)
                {
                    return false; // Should be exactly one user
                }
                
                // Hash the new password
                string hashedPassword = HashPassword(newPassword);
                
                // Update the password in the database
                string sql = $"UPDATE Users SET Password = {EscapeString(hashedPassword)} WHERE Email = {EscapeString(email)}";
                
                int result = db.ExecuteNonQuery(sql);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Check if username already exists
        public bool IsUsernameExists(string username)
        {
            string sql = $"SELECT COUNT(*) FROM Users WHERE Username = {EscapeString(username)}";
            
            int count = Convert.ToInt32(db.ExecuteScalar(sql));
            return count > 0;
        }
        
        // Check if email already exists
        public bool IsEmailExists(string email)
        {
            string sql = $"SELECT COUNT(*) FROM Users WHERE Email = {EscapeString(email)}";
            
            int count = Convert.ToInt32(db.ExecuteScalar(sql));
            return count > 0;
        }
        
        // Update last login time
        private void UpdateLastLoginDate(int userId)
        {
            string sql = $"UPDATE Users SET LastLoginDate = {FormatDateTime(DateTime.Now)} WHERE UserID = {userId}";
            
            db.ExecuteNonQuery(sql);
        }
        
        // Hash password
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                
                return builder.ToString();
            }
        }
        
        // Get all users
        public DataTable GetAll()
        {
            string sql = @"SELECT UserID, Username, FullName, Email, CreatedDate, LastLoginDate FROM Users";
            return db.ExecuteQuery(sql);
        }
        
        // Delete user
        public bool Delete(int userId)
        {
            try
            {
                // Delete related records first (if any foreign key constraints exist)
                // For now, directly delete the user
                string sql = $"DELETE FROM Users WHERE UserID = {userId}";
                
                int result = db.ExecuteNonQuery(sql);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Check if current user is admin
        public bool IsAdmin()
        {
            if (CurrentUserData == null) return false;
            return CurrentUser.Role?.ToLower() == "admin";
        }
        
        // Check if Role column exists in Users table
        private bool CheckIfRoleColumnExists()
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Users' AND COLUMN_NAME = 'Role'";
                
                object result = db.ExecuteScalar(sql);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Check if unique constraint exists for Email column
        private bool CheckIfEmailUniqueConstraintExists()
        {
            try
            {
                string sql = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
                              JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE cu ON tc.CONSTRAINT_NAME = cu.CONSTRAINT_NAME
                              WHERE tc.TABLE_NAME = 'Users' AND cu.COLUMN_NAME = 'Email' AND tc.CONSTRAINT_TYPE = 'UNIQUE'";
                
                object result = db.ExecuteScalar(sql);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Add unique constraint to Email column
        private void EnsureEmailUniqueConstraint()
        {
            try
            {
                if (!CheckIfEmailUniqueConstraintExists())
                {
                    // First, check for duplicate emails and handle them
                    string duplicateCheckSql = @"SELECT Email, COUNT(*) as Count 
                                                FROM Users 
                                                GROUP BY Email 
                                                HAVING COUNT(*) > 1";
                    
                    DataTable duplicates = db.ExecuteQuery(duplicateCheckSql);
                    
                    if (duplicates.Rows.Count > 0)
                    {
                        // Handle duplicate emails by appending a number
                        foreach (DataRow row in duplicates.Rows)
                        {
                            string duplicateEmail = row["Email"].ToString();
                            
                            // Get all users with this email
                            string getUsersSql = $"SELECT UserID FROM Users WHERE Email = {EscapeString(duplicateEmail)} ORDER BY UserID";
                            DataTable users = db.ExecuteQuery(getUsersSql);
                            
                            // Keep first user, modify others
                            for (int i = 1; i < users.Rows.Count; i++)
                            {
                                int userId = Convert.ToInt32(users.Rows[i]["UserID"]);
                                string newEmail = $"{duplicateEmail.Split('@')[0]}_{i}@{duplicateEmail.Split('@')[1]}";
                                
                                string updateSql = $"UPDATE Users SET Email = {EscapeString(newEmail)} WHERE UserID = {userId}";
                                db.ExecuteNonQuery(updateSql);
                            }
                        }
                    }
                    
                    // Now add the unique constraint
                    string alterSql = "ALTER TABLE Users ADD CONSTRAINT UK_Users_Email UNIQUE (Email)";
                    db.ExecuteNonQuery(alterSql);
                }
            }
            catch (Exception)
            {
                // Constraint might already exist or other error occurred
                // Fail silently to avoid breaking the application
            }
        }
        
        // Ensure admin user exists
        public void EnsureAdminExists()
        {
            try
            {
                // First ensure email unique constraint
                EnsureEmailUniqueConstraint();
                
                // First, try to add the Role column if it doesn't exist
                if (!CheckIfRoleColumnExists())
                {
                    string alterSql = "ALTER TABLE Users ADD Role VARCHAR(50) DEFAULT 'user'";
                    db.ExecuteNonQuery(alterSql);
                }

                // Check if admin user exists
                string sql = "SELECT COUNT(*) FROM Users WHERE Role = 'admin'";
                int count = Convert.ToInt32(db.ExecuteScalar(sql));

                if (count == 0)
                {
                    // Create admin user
                    string checkUserSql = "SELECT COUNT(*) FROM Users WHERE Username = 'admin'";
                    int userCount = Convert.ToInt32(db.ExecuteScalar(checkUserSql));

                    if (userCount == 0)
                    {
                        // Insert new admin user
                        Register("admin", "admin123", "Administrator", "admin@musiclibrary.com", "admin");
                    }
                    else
                    {
                        // Update existing user to admin
                        string updateSql = "UPDATE Users SET Role = 'admin' WHERE Username = 'admin'";
                        db.ExecuteNonQuery(updateSql);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
} 