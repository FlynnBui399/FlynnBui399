namespace OOPR_FinalProject
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            panel1 = new System.Windows.Forms.Panel();
            clear_label = new System.Windows.Forms.Label();
            cancel_label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pass_label = new System.Windows.Forms.Label();
            user_label = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            btnSignUp = new System.Windows.Forms.Button();
            title_label = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Ivory;
            panel1.Controls.Add(clear_label);
            panel1.Controls.Add(cancel_label);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pass_label);
            panel1.Controls.Add(user_label);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(title_label);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(664, 542);
            panel1.TabIndex = 20;
            // 
            // clear_label
            // 
            clear_label.AutoSize = true;
            clear_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            clear_label.Location = new System.Drawing.Point(538, 416);
            clear_label.Name = "clear_label";
            clear_label.Size = new System.Drawing.Size(61, 28);
            clear_label.TabIndex = 27;
            clear_label.Text = "Clear";
            clear_label.Click += clear_label_Click;
            // 
            // cancel_label
            // 
            cancel_label.AutoSize = true;
            cancel_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            cancel_label.Location = new System.Drawing.Point(303, 500);
            cancel_label.Name = "cancel_label";
            cancel_label.Size = new System.Drawing.Size(75, 28);
            cancel_label.TabIndex = 26;
            cancel_label.Text = "Cancel";
            cancel_label.Click += cancel_label_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Candara", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(167, 178);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(351, 41);
            label1.TabIndex = 25;
            label1.Text = "Sign Up For Guest Only";
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
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold);
            pass_label.Location = new System.Drawing.Point(73, 340);
            pass_label.Name = "pass_label";
            pass_label.Size = new System.Drawing.Size(109, 28);
            pass_label.TabIndex = 18;
            pass_label.Text = "Password";
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold);
            user_label.Location = new System.Drawing.Point(71, 249);
            user_label.Name = "user_label";
            user_label.Size = new System.Drawing.Size(113, 28);
            user_label.TabIndex = 17;
            user_label.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Candara", 12F);
            txtPassword.Location = new System.Drawing.Point(60, 381);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(539, 32);
            txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Candara", 12F);
            txtUsername.Location = new System.Drawing.Point(60, 288);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(539, 32);
            txtUsername.TabIndex = 15;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = System.Drawing.Color.ForestGreen;
            btnSignUp.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSignUp.Location = new System.Drawing.Point(254, 432);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(173, 50);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
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
            // SignUpForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(688, 566);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SignUpForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sign_up_btn;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cancel_label;
        private System.Windows.Forms.Label clear_label;
    }
}