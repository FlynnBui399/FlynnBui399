namespace OOPR_FinalProject
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            background_panel = new System.Windows.Forms.Panel();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            logout_label = new System.Windows.Forms.Label();
            main_panel = new System.Windows.Forms.Panel();
            managershow_txtbox = new System.Windows.Forms.TextBox();
            credit_label = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            category_panel = new System.Windows.Forms.Panel();
            category_icon = new System.Windows.Forms.PictureBox();
            category_label = new System.Windows.Forms.Label();
            report_panel = new System.Windows.Forms.Panel();
            report_icon = new System.Windows.Forms.PictureBox();
            report_label = new System.Windows.Forms.Label();
            room_panel = new System.Windows.Forms.Panel();
            room_icon = new System.Windows.Forms.PictureBox();
            room_label = new System.Windows.Forms.Label();
            background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            category_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)category_icon).BeginInit();
            report_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)report_icon).BeginInit();
            room_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)room_icon).BeginInit();
            SuspendLayout();
            // 
            // background_panel
            // 
            background_panel.BackColor = System.Drawing.Color.Snow;
            background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            background_panel.Controls.Add(logo_icon);
            background_panel.Controls.Add(title_label);
            background_panel.Controls.Add(logout_panel);
            background_panel.Controls.Add(main_panel);
            background_panel.Controls.Add(category_panel);
            background_panel.Controls.Add(report_panel);
            background_panel.Controls.Add(room_panel);
            background_panel.Location = new System.Drawing.Point(12, 12);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1176, 576);
            background_panel.TabIndex = 1;
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
            // main_panel
            // 
            main_panel.BackColor = System.Drawing.Color.Ivory;
            main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            main_panel.Controls.Add(managershow_txtbox);
            main_panel.Controls.Add(credit_label);
            main_panel.Controls.Add(pictureBox1);
            main_panel.Controls.Add(label1);
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
            // 
            // managershow_txtbox
            // 
            managershow_txtbox.BackColor = System.Drawing.SystemColors.Info;
            managershow_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            managershow_txtbox.Enabled = false;
            managershow_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            managershow_txtbox.Location = new System.Drawing.Point(285, 68);
            managershow_txtbox.Multiline = true;
            managershow_txtbox.Name = "managershow_txtbox";
            managershow_txtbox.Size = new System.Drawing.Size(488, 56);
            managershow_txtbox.TabIndex = 7;
            // 
            // credit_label
            // 
            credit_label.Cursor = System.Windows.Forms.Cursors.Hand;
            credit_label.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            credit_label.ForeColor = System.Drawing.Color.Black;
            credit_label.Location = new System.Drawing.Point(8, 482);
            credit_label.Name = "credit_label";
            credit_label.Size = new System.Drawing.Size(1004, 28);
            credit_label.TabIndex = 6;
            credit_label.Text = "Starry Night by Van Gogh";
            credit_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1005, 339);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Cursor = System.Windows.Forms.Cursors.Hand;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(3, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1004, 43);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the Hotel Management System, designed to streamline operations and enhance guest satisfaction.\r\nYour job here is manage rooms and view reports. Good Luck!\r\n\r\n";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category_panel
            // 
            category_panel.BackColor = System.Drawing.Color.Snow;
            category_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            category_panel.Controls.Add(category_icon);
            category_panel.Controls.Add(category_label);
            category_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            category_panel.Location = new System.Drawing.Point(0, 191);
            category_panel.Name = "category_panel";
            category_panel.Size = new System.Drawing.Size(157, 54);
            category_panel.TabIndex = 26;
            category_panel.Click += category_Click;
            // 
            // category_icon
            // 
            category_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            category_icon.Image = (System.Drawing.Image)resources.GetObject("category_icon.Image");
            category_icon.Location = new System.Drawing.Point(3, 2);
            category_icon.Name = "category_icon";
            category_icon.Size = new System.Drawing.Size(50, 50);
            category_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            category_icon.TabIndex = 1;
            category_icon.TabStop = false;
            category_icon.Click += category_Click;
            // 
            // category_label
            // 
            category_label.AutoSize = true;
            category_label.Cursor = System.Windows.Forms.Cursors.Hand;
            category_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            category_label.ForeColor = System.Drawing.Color.Black;
            category_label.Location = new System.Drawing.Point(56, 15);
            category_label.Name = "category_label";
            category_label.Size = new System.Drawing.Size(101, 24);
            category_label.TabIndex = 0;
            category_label.Text = "Categories";
            category_label.Click += category_Click;
            // 
            // report_panel
            // 
            report_panel.BackColor = System.Drawing.Color.Snow;
            report_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            report_panel.Controls.Add(report_icon);
            report_panel.Controls.Add(report_label);
            report_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            report_panel.ForeColor = System.Drawing.Color.DarkOrange;
            report_panel.Location = new System.Drawing.Point(0, 272);
            report_panel.Name = "report_panel";
            report_panel.Size = new System.Drawing.Size(157, 54);
            report_panel.TabIndex = 27;
            report_panel.Click += report_Click;
            // 
            // report_icon
            // 
            report_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            report_icon.Image = (System.Drawing.Image)resources.GetObject("report_icon.Image");
            report_icon.Location = new System.Drawing.Point(3, 1);
            report_icon.Name = "report_icon";
            report_icon.Size = new System.Drawing.Size(50, 50);
            report_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            report_icon.TabIndex = 1;
            report_icon.TabStop = false;
            report_icon.Click += report_Click;
            // 
            // report_label
            // 
            report_label.AutoSize = true;
            report_label.Cursor = System.Windows.Forms.Cursors.Hand;
            report_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            report_label.ForeColor = System.Drawing.Color.Black;
            report_label.Location = new System.Drawing.Point(56, 15);
            report_label.Name = "report_label";
            report_label.Size = new System.Drawing.Size(77, 24);
            report_label.TabIndex = 0;
            report_label.Text = "Reports";
            report_label.Click += report_Click;
            // 
            // room_panel
            // 
            room_panel.BackColor = System.Drawing.Color.Snow;
            room_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            room_panel.Controls.Add(room_icon);
            room_panel.Controls.Add(room_label);
            room_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            room_panel.Location = new System.Drawing.Point(0, 104);
            room_panel.Name = "room_panel";
            room_panel.Size = new System.Drawing.Size(157, 54);
            room_panel.TabIndex = 25;
            room_panel.Click += room_Click;
            // 
            // room_icon
            // 
            room_icon.Image = (System.Drawing.Image)resources.GetObject("room_icon.Image");
            room_icon.Location = new System.Drawing.Point(3, 1);
            room_icon.Name = "room_icon";
            room_icon.Size = new System.Drawing.Size(50, 50);
            room_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            room_icon.TabIndex = 1;
            room_icon.TabStop = false;
            room_icon.Click += room_Click;
            // 
            // room_label
            // 
            room_label.AutoSize = true;
            room_label.BackColor = System.Drawing.Color.Transparent;
            room_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            room_label.ForeColor = System.Drawing.Color.Black;
            room_label.Location = new System.Drawing.Point(56, 13);
            room_label.Name = "room_label";
            room_label.Size = new System.Drawing.Size(69, 24);
            room_label.TabIndex = 0;
            room_label.Text = "Rooms";
            room_label.Click += room_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ManagerForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ManagerForm";
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            category_panel.ResumeLayout(false);
            category_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)category_icon).EndInit();
            report_panel.ResumeLayout(false);
            report_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)report_icon).EndInit();
            room_panel.ResumeLayout(false);
            room_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)room_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.PictureBox logout_icon;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label credit_label;
        private System.Windows.Forms.Panel report_panel;
        private System.Windows.Forms.PictureBox report_icon;
        private System.Windows.Forms.Label report_label;
        private System.Windows.Forms.Panel room_panel;
        private System.Windows.Forms.PictureBox room_icon;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.PictureBox category_icon;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.TextBox managershow_txtbox;
    }
}