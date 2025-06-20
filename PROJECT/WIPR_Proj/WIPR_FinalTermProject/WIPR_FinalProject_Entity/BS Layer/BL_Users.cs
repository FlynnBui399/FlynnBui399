using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WIPR_FinalProject_Entity.BS_Layer
{
    public class BL_Users
    {
        private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();
        
        // Static variable to store current logged in user information
        public static User CurrentUser { get; private set; }
        
        // Login verification
        public bool Login(string username, string password)
        {
            try
            {
                // Hash password
                string hashedPassword = HashPassword(password);
                
                var user = musicEntity.Users.FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);
                
                if (user != null)
                {
                    // Save current user information
                    CurrentUser = new User
                    {
                        UserID = user.UserID,
                        Username = user.Username,
                        FullName = user.FullName,
                        Email = user.Email,
                        CreatedDate = user.CreatedDate,
                        LastLoginDate = DateTime.Now,
                        Role = user.Role ?? "user" // Include Role with fallback
                    };
                    
                    // Update last login time
                    UpdateLastLoginDate(CurrentUser.UserID);
                    
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
            CurrentUser = null;
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
                
                var newUser = new User
                {
                    Username = username,
                    Password = hashedPassword,
                    FullName = fullName,
                    Email = email,
                    CreatedDate = DateTime.Now,
                    LastLoginDate = DateTime.Now,
                    Role = role
                };
                
                musicEntity.Users.Add(newUser);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Request password reset
        public string RequestPasswordReset(string email)
        {
            try
            {
                // Check how many users have this email
                var usersWithEmail = musicEntity.Users.Where(u => u.Email == email).ToList();
                
                if (usersWithEmail.Count == 0)
                {
                    return null; // Email doesn't exist
                }
                
                if (usersWithEmail.Count > 1)
                {
                    // Multiple users with same email - this should not happen
                    // But handle gracefully if legacy data exists
                    return null;
                }
                
                var user = usersWithEmail.First();
                
                // Generate a random reset code (6 digit number)
                Random random = new Random();
                string resetCode = random.Next(100000, 999999).ToString();
                
                // Send reset code via email
                bool emailSent = WIPR_FinalProject_Entity.Classes.EmailHelper.SendPasswordResetCode(email, resetCode);
                
                if (emailSent)
                {
                    return resetCode;
                }
                
                return null;
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
                var usersWithEmail = musicEntity.Users.Where(u => u.Email == email).ToList();
                
                if (usersWithEmail.Count != 1)
                {
                    return false; // Should be exactly one user
                }
                
                var user = usersWithEmail.First();
                user.Password = HashPassword(newPassword);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Check if username already exists
        public bool IsUsernameExists(string username)
        {
            return musicEntity.Users.Any(u => u.Username == username);
        }
        
        // Check if email already exists
        public bool IsEmailExists(string email)
        {
            return musicEntity.Users.Any(u => u.Email == email);
        }
        
        // Update last login time
        private void UpdateLastLoginDate(int userId)
        {
            var user = musicEntity.Users.Find(userId);
            if (user != null)
            {
                user.LastLoginDate = DateTime.Now;
                musicEntity.SaveChanges();
            }
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
            var query = from u in musicEntity.Users
                        select new
                        {
                            u.UserID,
                            u.Username,
                            u.FullName,
                            u.Email,
                            u.CreatedDate,
                            u.LastLoginDate
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("UserID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("CreatedDate", typeof(DateTime));
            dt.Columns.Add("LastLoginDate", typeof(DateTime));

            foreach (var user in query)
            {
                dt.Rows.Add(
                    user.UserID,
                    user.Username ?? string.Empty,
                    user.FullName ?? string.Empty,
                    user.Email ?? string.Empty,
                    user.CreatedDate,
                    user.LastLoginDate
                );
            }

            return dt;
        }
        
        // Delete user
        public bool Delete(int userId)
        {
            try
            {
                var user = musicEntity.Users.Find(userId);
                if (user != null)
                {
                    // Remove user's playlists
                    var playlists = musicEntity.Playlists.Where(p => p.CreatorID == userId);
                    musicEntity.Playlists.RemoveRange(playlists);

                    // Remove user's favorite songs
                    var favoriteSongs = musicEntity.FavoritePlaylists.Where(f => f.UserID == userId);
                    musicEntity.FavoritePlaylists.RemoveRange(favoriteSongs);

                    // Finally remove the user
                    musicEntity.Users.Remove(user);
                    musicEntity.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Check if current user is admin
        public bool IsAdmin()
        {
            return CurrentUser?.Role?.ToLower() == "admin";
        }

        // Ensure admin user exists
        public void EnsureAdminExists()
        {
            if (!musicEntity.Users.Any(u => u.Role == "admin"))
            {
                Register("admin", "admin123", "Administrator", "admin@wipr.com", "admin");
            }
        }

        public void Insert(string username, string password, string email, string fullName, string role = "User")
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username cannot be empty.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password cannot be empty.");

            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email cannot be empty.");

            if (musicEntity.Users.Any(u => u.Username == username))
                throw new Exception("Username already exists.");

            if (musicEntity.Users.Any(u => u.Email == email))
                throw new Exception("Email already exists.");

            var user = new User
            {
                Username = username,
                Password = password, // Note: In production, password should be hashed
                Email = email,
                FullName = fullName,
                Role = role,
                CreatedDate = DateTime.Now
            };

            musicEntity.Users.Add(user);
            musicEntity.SaveChanges();
        }

        public void Update(int id, string email, string fullName, string role)
        {
            var user = musicEntity.Users.FirstOrDefault(u => u.UserID == id);
            if (user != null)
            {
                if (!string.IsNullOrWhiteSpace(email) && email != user.Email)
                {
                    if (musicEntity.Users.Any(u => u.Email == email))
                        throw new Exception("Email already exists.");
                    user.Email = email;
                }

                user.FullName = fullName;
                user.Role = role;
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public void UpdatePassword(int id, string oldPassword, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                throw new Exception("New password cannot be empty.");

            var user = musicEntity.Users.FirstOrDefault(u => u.UserID == id);
            if (user != null)
            {
                if (user.Password != oldPassword) // Note: In production, use proper password comparison
                    throw new Exception("Current password is incorrect.");

                user.Password = newPassword; // Note: In production, hash the new password
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public User Authenticate(string username, string password)
        {
            return musicEntity.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public bool IsAdmin(int userId)
        {
            var user = musicEntity.Users.FirstOrDefault(u => u.UserID == userId);
            return user?.Role?.ToLower() == "admin";
        }

        public void Dispose()
        {
            if (musicEntity != null)
            {
                musicEntity.Dispose();
                musicEntity = null;
            }
        }
    }
}
