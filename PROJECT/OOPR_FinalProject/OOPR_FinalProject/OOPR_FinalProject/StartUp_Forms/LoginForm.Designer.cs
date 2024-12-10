namespace OOPR_FinalProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            title_label = new System.Windows.Forms.Label();
            pass_label = new System.Windows.Forms.Label();
            user_label = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            show_cb = new System.Windows.Forms.CheckBox();
            close_btn = new System.Windows.Forms.PictureBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            receptionist_rdbtn = new System.Windows.Forms.RadioButton();
            manager_rdbtn = new System.Windows.Forms.RadioButton();
            guest_rdbtn = new System.Windows.Forms.RadioButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            sign_up_btn = new System.Windows.Forms.Button();
            sign_up_label = new System.Windows.Forms.Label();
            guest_rbutton = new System.Windows.Forms.RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new System.Drawing.Font("Candara", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            title_label.Location = new System.Drawing.Point(71, 19);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(539, 54);
            title_label.TabIndex = 2;
            title_label.Text = "Hotel Management System";
            // 
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold);
            pass_label.Location = new System.Drawing.Point(73, 328);
            pass_label.Name = "pass_label";
            pass_label.Size = new System.Drawing.Size(109, 28);
            pass_label.TabIndex = 18;
            pass_label.Text = "Password";
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold);
            user_label.Location = new System.Drawing.Point(71, 237);
            user_label.Name = "user_label";
            user_label.Size = new System.Drawing.Size(113, 28);
            user_label.TabIndex = 17;
            user_label.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Candara", 12F);
            txtPassword.Location = new System.Drawing.Point(60, 369);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new System.Drawing.Size(539, 32);
            txtPassword.TabIndex = 16;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Candara", 12F);
            txtUsername.Location = new System.Drawing.Point(60, 276);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Size = new System.Drawing.Size(539, 32);
            txtUsername.TabIndex = 15;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnLogin.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogin.Location = new System.Drawing.Point(254, 425);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(173, 50);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Ivory;
            panel1.Controls.Add(show_cb);
            panel1.Controls.Add(close_btn);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(sign_up_btn);
            panel1.Controls.Add(sign_up_label);
            panel1.Controls.Add(pass_label);
            panel1.Controls.Add(user_label);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(title_label);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(664, 542);
            panel1.TabIndex = 19;
            // 
            // show_cb
            // 
            show_cb.AutoSize = true;
            show_cb.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            show_cb.Location = new System.Drawing.Point(445, 407);
            show_cb.Name = "show_cb";
            show_cb.Size = new System.Drawing.Size(154, 26);
            show_cb.TabIndex = 25;
            show_cb.Text = "Show Password";
            show_cb.UseVisualStyleBackColor = true;
            show_cb.CheckedChanged += show_cb_CheckedChanged;
            // 
            // close_btn
            // 
            close_btn.Image = (System.Drawing.Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new System.Drawing.Point(616, 3);
            close_btn.Name = "close_btn";
            close_btn.Size = new System.Drawing.Size(43, 42);
            close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            close_btn.TabIndex = 24;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(receptionist_rdbtn);
            groupBox2.Controls.Add(manager_rdbtn);
            groupBox2.Controls.Add(guest_rdbtn);
            groupBox2.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.Location = new System.Drawing.Point(60, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(539, 66);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "You are";
            // 
            // receptionist_rdbtn
            // 
            receptionist_rdbtn.AutoSize = true;
            receptionist_rdbtn.Font = new System.Drawing.Font("Candara", 12F);
            receptionist_rdbtn.Location = new System.Drawing.Point(397, 25);
            receptionist_rdbtn.Name = "receptionist_rdbtn";
            receptionist_rdbtn.Size = new System.Drawing.Size(135, 28);
            receptionist_rdbtn.TabIndex = 2;
            receptionist_rdbtn.TabStop = true;
            receptionist_rdbtn.Text = "Receptionist";
            receptionist_rdbtn.UseVisualStyleBackColor = true;
            // 
            // manager_rdbtn
            // 
            manager_rdbtn.AutoSize = true;
            manager_rdbtn.Font = new System.Drawing.Font("Candara", 12F);
            manager_rdbtn.Location = new System.Drawing.Point(190, 25);
            manager_rdbtn.Name = "manager_rdbtn";
            manager_rdbtn.Size = new System.Drawing.Size(107, 28);
            manager_rdbtn.TabIndex = 1;
            manager_rdbtn.TabStop = true;
            manager_rdbtn.Text = "Manager";
            manager_rdbtn.UseVisualStyleBackColor = true;
            // 
            // guest_rdbtn
            // 
            guest_rdbtn.AutoSize = true;
            guest_rdbtn.Font = new System.Drawing.Font("Candara", 12F);
            guest_rdbtn.Location = new System.Drawing.Point(11, 25);
            guest_rdbtn.Name = "guest_rdbtn";
            guest_rdbtn.Size = new System.Drawing.Size(79, 28);
            guest_rdbtn.TabIndex = 0;
            guest_rdbtn.TabStop = true;
            guest_rdbtn.Text = "Guest";
            guest_rdbtn.UseVisualStyleBackColor = true;
            guest_rdbtn.CheckedChanged += guest_rdbtn_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(307, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(67, 62);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // sign_up_btn
            // 
            sign_up_btn.BackColor = System.Drawing.SystemColors.Window;
            sign_up_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            sign_up_btn.Location = new System.Drawing.Point(281, 489);
            sign_up_btn.Name = "sign_up_btn";
            sign_up_btn.Size = new System.Drawing.Size(119, 32);
            sign_up_btn.TabIndex = 21;
            sign_up_btn.Text = "Sign up";
            sign_up_btn.UseVisualStyleBackColor = false;
            sign_up_btn.Click += sign_up_btn_Click;
            // 
            // sign_up_label
            // 
            sign_up_label.AutoSize = true;
            sign_up_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            sign_up_label.Location = new System.Drawing.Point(60, 497);
            sign_up_label.Name = "sign_up_label";
            sign_up_label.Size = new System.Drawing.Size(206, 24);
            sign_up_label.TabIndex = 20;
            sign_up_label.Text = "Don't have an account?";
            // 
            // guest_rbutton
            // 
            guest_rbutton.AutoSize = true;
            guest_rbutton.Font = new System.Drawing.Font("Candara", 12F);
            guest_rbutton.Location = new System.Drawing.Point(16, 23);
            guest_rbutton.Name = "guest_rbutton";
            guest_rbutton.Size = new System.Drawing.Size(79, 28);
            guest_rbutton.TabIndex = 0;
            guest_rbutton.TabStop = true;
            guest_rbutton.Text = "Guest";
            guest_rbutton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(688, 566);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton receptionist_rdbtn;
        private System.Windows.Forms.RadioButton manager_rdbtn;
        private System.Windows.Forms.RadioButton guest_rbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sign_up_btn;
        private System.Windows.Forms.Label sign_up_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton guest_rdbtn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.CheckBox show_cb;
    }
}

