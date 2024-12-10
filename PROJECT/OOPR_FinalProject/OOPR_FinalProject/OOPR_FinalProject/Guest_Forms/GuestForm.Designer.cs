namespace OOPR_FinalProject
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            background_panel = new System.Windows.Forms.Panel();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            main_panel = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            login_label = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            viewroom_btn = new System.Windows.Forms.Button();
            background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            main_panel.SuspendLayout();
            logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            SuspendLayout();
            // 
            // background_panel
            // 
            background_panel.BackColor = System.Drawing.Color.Snow;
            background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            background_panel.Controls.Add(logo_icon);
            background_panel.Controls.Add(title_label);
            background_panel.Controls.Add(main_panel);
            background_panel.Location = new System.Drawing.Point(12, 12);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1038, 576);
            background_panel.TabIndex = 0;
            // 
            // logo_icon
            // 
            logo_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            logo_icon.Image = (System.Drawing.Image)resources.GetObject("logo_icon.Image");
            logo_icon.Location = new System.Drawing.Point(40, 5);
            logo_icon.Name = "logo_icon";
            logo_icon.Size = new System.Drawing.Size(67, 62);
            logo_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo_icon.TabIndex = 23;
            logo_icon.TabStop = false;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new System.Drawing.Font("Candara", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            title_label.Location = new System.Drawing.Point(273, 0);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(539, 54);
            title_label.TabIndex = 4;
            title_label.Text = "Hotel Management System";
            // 
            // main_panel
            // 
            main_panel.BackColor = System.Drawing.Color.Ivory;
            main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            main_panel.Controls.Add(viewroom_btn);
            main_panel.Controls.Add(label5);
            main_panel.Controls.Add(label4);
            main_panel.Controls.Add(logout_panel);
            main_panel.Controls.Add(label3);
            main_panel.Controls.Add(label2);
            main_panel.Controls.Add(label1);
            main_panel.Location = new System.Drawing.Point(-2, 47);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1038, 529);
            main_panel.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(36, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(938, 168);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(36, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(896, 72);
            label4.TabIndex = 5;
            label4.Text = "Dear Valued Guest,\r\nWe are delighted to welcome you to the Hotel! Our team is dedicated to ensuring your stay is comfortable, \r\nenjoyable, and memorable.";
            // 
            // logout_panel
            // 
            logout_panel.BackColor = System.Drawing.Color.DarkCyan;
            logout_panel.Controls.Add(logout_icon);
            logout_panel.Controls.Add(login_label);
            logout_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            logout_panel.Location = new System.Drawing.Point(848, 446);
            logout_panel.Name = "logout_panel";
            logout_panel.Size = new System.Drawing.Size(157, 54);
            logout_panel.TabIndex = 1;
            logout_panel.Click += logout_icon_Click;
            // 
            // logout_icon
            // 
            logout_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            logout_icon.Image = (System.Drawing.Image)resources.GetObject("logout_icon.Image");
            logout_icon.Location = new System.Drawing.Point(3, 3);
            logout_icon.Name = "logout_icon";
            logout_icon.Size = new System.Drawing.Size(56, 51);
            logout_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logout_icon.TabIndex = 1;
            logout_icon.TabStop = false;
            logout_icon.Click += logout_icon_Click;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Cursor = System.Windows.Forms.Cursors.Hand;
            login_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            login_label.ForeColor = System.Drawing.Color.Snow;
            login_label.Location = new System.Drawing.Point(65, 13);
            login_label.Name = "login_label";
            login_label.Size = new System.Drawing.Size(73, 28);
            login_label.TabIndex = 0;
            login_label.Text = "Log In";
            login_label.Click += logout_icon_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(36, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(302, 56);
            label3.TabIndex = 4;
            label3.Text = "Welcome to the Hotel!\r\nYour Home Away From Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(36, 455);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 24);
            label2.TabIndex = 3;
            label2.Text = "The Team03_OOPR\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(36, 353);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(599, 72);
            label1.TabIndex = 2;
            label1.Text = "Thank you for choosing our hotel. We hope you have a wonderful stay!\r\n\r\nWarm regards,";
            // 
            // viewroom_btn
            // 
            viewroom_btn.BackColor = System.Drawing.Color.SlateBlue;
            viewroom_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            viewroom_btn.ForeColor = System.Drawing.Color.Snow;
            viewroom_btn.Location = new System.Drawing.Point(856, 27);
            viewroom_btn.Name = "viewroom_btn";
            viewroom_btn.Size = new System.Drawing.Size(160, 36);
            viewroom_btn.TabIndex = 5;
            viewroom_btn.Text = "View Rooms >>";
            viewroom_btn.UseVisualStyleBackColor = false;
            viewroom_btn.Click += viewroom_btn_Click;
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1063, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "GuestForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GuestForm";
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox logout_icon;
        private System.Windows.Forms.Button viewroom_btn;
    }
}