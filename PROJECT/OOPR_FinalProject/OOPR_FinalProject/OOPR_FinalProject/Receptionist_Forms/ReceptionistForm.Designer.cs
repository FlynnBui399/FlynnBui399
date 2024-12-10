namespace OOPR_FinalProject
{
    partial class ReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistForm));
            checkout_label = new System.Windows.Forms.Label();
            checkout_panel = new System.Windows.Forms.Panel();
            checkout_icon = new System.Windows.Forms.PictureBox();
            checkin_icon = new System.Windows.Forms.PictureBox();
            checkin_label = new System.Windows.Forms.Label();
            checkin_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_label = new System.Windows.Forms.Label();
            background_panel = new System.Windows.Forms.Panel();
            main_panel = new System.Windows.Forms.Panel();
            recepshow_txtbox = new System.Windows.Forms.TextBox();
            credit_label = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            checkout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkout_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkin_icon).BeginInit();
            checkin_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            logout_panel.SuspendLayout();
            background_panel.SuspendLayout();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkout_label
            // 
            checkout_label.AutoSize = true;
            checkout_label.Cursor = System.Windows.Forms.Cursors.Hand;
            checkout_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkout_label.ForeColor = System.Drawing.Color.Black;
            checkout_label.Location = new System.Drawing.Point(59, 15);
            checkout_label.Name = "checkout_label";
            checkout_label.Size = new System.Drawing.Size(97, 24);
            checkout_label.TabIndex = 0;
            checkout_label.Text = "Check Out";
            checkout_label.Click += checkout_Click;
            // 
            // checkout_panel
            // 
            checkout_panel.BackColor = System.Drawing.Color.Transparent;
            checkout_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            checkout_panel.Controls.Add(checkout_icon);
            checkout_panel.Controls.Add(checkout_label);
            checkout_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            checkout_panel.Location = new System.Drawing.Point(0, 193);
            checkout_panel.Name = "checkout_panel";
            checkout_panel.Size = new System.Drawing.Size(157, 54);
            checkout_panel.TabIndex = 3;
            checkout_panel.Click += checkout_Click;
            // 
            // checkout_icon
            // 
            checkout_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            checkout_icon.Image = (System.Drawing.Image)resources.GetObject("checkout_icon.Image");
            checkout_icon.Location = new System.Drawing.Point(3, 1);
            checkout_icon.Name = "checkout_icon";
            checkout_icon.Size = new System.Drawing.Size(50, 50);
            checkout_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            checkout_icon.TabIndex = 1;
            checkout_icon.TabStop = false;
            checkout_icon.Click += checkout_Click;
            // 
            // checkin_icon
            // 
            checkin_icon.Image = (System.Drawing.Image)resources.GetObject("checkin_icon.Image");
            checkin_icon.Location = new System.Drawing.Point(3, 1);
            checkin_icon.Name = "checkin_icon";
            checkin_icon.Size = new System.Drawing.Size(50, 50);
            checkin_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            checkin_icon.TabIndex = 1;
            checkin_icon.TabStop = false;
            checkin_icon.Click += checkin_Click;
            // 
            // checkin_label
            // 
            checkin_label.AutoSize = true;
            checkin_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkin_label.ForeColor = System.Drawing.Color.Black;
            checkin_label.Location = new System.Drawing.Point(59, 13);
            checkin_label.Name = "checkin_label";
            checkin_label.Size = new System.Drawing.Size(82, 24);
            checkin_label.TabIndex = 0;
            checkin_label.Text = "Check In";
            checkin_label.Click += checkin_Click;
            // 
            // checkin_panel
            // 
            checkin_panel.BackColor = System.Drawing.Color.Snow;
            checkin_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            checkin_panel.Controls.Add(checkin_icon);
            checkin_panel.Controls.Add(checkin_label);
            checkin_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            checkin_panel.Location = new System.Drawing.Point(0, 104);
            checkin_panel.Name = "checkin_panel";
            checkin_panel.Size = new System.Drawing.Size(157, 54);
            checkin_panel.TabIndex = 2;
            checkin_panel.Click += checkin_Click;
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
            logout_icon.Click += logout_Click;
            // 
            // logo_icon
            // 
            logo_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            logo_icon.Image = (System.Drawing.Image)resources.GetObject("logo_icon.Image");
            logo_icon.Location = new System.Drawing.Point(43, 17);
            logo_icon.Name = "logo_icon";
            logo_icon.Size = new System.Drawing.Size(67, 62);
            logo_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo_icon.TabIndex = 23;
            logo_icon.TabStop = false;
            logo_icon.Click += logo_Click;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new System.Drawing.Font("Candara", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            title_label.Location = new System.Drawing.Point(442, 5);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(539, 54);
            title_label.TabIndex = 4;
            title_label.Text = "Hotel Management System";
            // 
            // logout_panel
            // 
            logout_panel.BackColor = System.Drawing.Color.DarkCyan;
            logout_panel.Controls.Add(logout_icon);
            logout_panel.Controls.Add(logout_label);
            logout_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            logout_panel.Location = new System.Drawing.Point(-1, 518);
            logout_panel.Name = "logout_panel";
            logout_panel.Size = new System.Drawing.Size(157, 54);
            logout_panel.TabIndex = 1;
            logout_panel.Click += logout_Click;
            // 
            // logout_label
            // 
            logout_label.AutoSize = true;
            logout_label.Cursor = System.Windows.Forms.Cursors.Hand;
            logout_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            logout_label.ForeColor = System.Drawing.Color.Snow;
            logout_label.Location = new System.Drawing.Point(65, 13);
            logout_label.Name = "logout_label";
            logout_label.Size = new System.Drawing.Size(85, 28);
            logout_label.TabIndex = 0;
            logout_label.Text = "LogOut";
            logout_label.Click += logout_Click;
            // 
            // background_panel
            // 
            background_panel.BackColor = System.Drawing.Color.Snow;
            background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            background_panel.Controls.Add(logo_icon);
            background_panel.Controls.Add(title_label);
            background_panel.Controls.Add(logout_panel);
            background_panel.Controls.Add(main_panel);
            background_panel.Controls.Add(checkin_panel);
            background_panel.Controls.Add(checkout_panel);
            background_panel.Location = new System.Drawing.Point(12, 12);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1176, 576);
            background_panel.TabIndex = 4;
            // 
            // main_panel
            // 
            main_panel.BackColor = System.Drawing.Color.Ivory;
            main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            main_panel.Controls.Add(recepshow_txtbox);
            main_panel.Controls.Add(credit_label);
            main_panel.Controls.Add(pictureBox1);
            main_panel.Controls.Add(label1);
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
            // 
            // recepshow_txtbox
            // 
            recepshow_txtbox.BackColor = System.Drawing.SystemColors.Info;
            recepshow_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            recepshow_txtbox.Enabled = false;
            recepshow_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            recepshow_txtbox.ForeColor = System.Drawing.SystemColors.WindowText;
            recepshow_txtbox.Location = new System.Drawing.Point(261, 61);
            recepshow_txtbox.Multiline = true;
            recepshow_txtbox.Name = "recepshow_txtbox";
            recepshow_txtbox.Size = new System.Drawing.Size(488, 56);
            recepshow_txtbox.TabIndex = 11;
            // 
            // credit_label
            // 
            credit_label.Cursor = System.Windows.Forms.Cursors.Hand;
            credit_label.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            credit_label.ForeColor = System.Drawing.Color.Black;
            credit_label.Location = new System.Drawing.Point(6, 480);
            credit_label.Name = "credit_label";
            credit_label.Size = new System.Drawing.Size(1004, 28);
            credit_label.TabIndex = 10;
            credit_label.Text = "Creation of Adam by Michelangelo";
            credit_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(5, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1005, 353);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Cursor = System.Windows.Forms.Cursors.Hand;
            label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1004, 51);
            label1.TabIndex = 7;
            label1.Text = "Welcome to the Hotel Management System, designed to streamline operations and enhance guest satisfaction.\r\nYour job here is check in and check out. Good Luck!\r\n\r\n";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceptionistForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ReceptionistForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ReceptionistForm";
            checkout_panel.ResumeLayout(false);
            checkout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkout_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkin_icon).EndInit();
            checkin_panel.ResumeLayout(false);
            checkin_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label checkout_label;
        private System.Windows.Forms.Panel checkout_panel;
        private System.Windows.Forms.PictureBox checkout_icon;
        private System.Windows.Forms.PictureBox checkin_icon;
        private System.Windows.Forms.Label checkin_label;
        private System.Windows.Forms.Panel checkin_panel;
        private System.Windows.Forms.PictureBox logout_icon;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label credit_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recepshow_txtbox;
    }
}