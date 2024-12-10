namespace OOPR_FinalProject
{
    partial class GuestInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestInfoForm));
            background_panel = new System.Windows.Forms.Panel();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            logout_label = new System.Windows.Forms.Label();
            main_panel = new System.Windows.Forms.Panel();
            detail_txtbox = new System.Windows.Forms.TextBox();
            edit_btn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            gender_cbbox = new System.Windows.Forms.ComboBox();
            contact_txtbox = new System.Windows.Forms.TextBox();
            txtFullname = new System.Windows.Forms.TextBox();
            save_btn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            contact_lb = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            info_panel = new System.Windows.Forms.Panel();
            info_icon = new System.Windows.Forms.PictureBox();
            info_label = new System.Windows.Forms.Label();
            booking_panel = new System.Windows.Forms.Panel();
            booking_icon = new System.Windows.Forms.PictureBox();
            booking_label = new System.Windows.Forms.Label();
            background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            main_panel.SuspendLayout();
            info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)info_icon).BeginInit();
            booking_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booking_icon).BeginInit();
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
            background_panel.Controls.Add(info_panel);
            background_panel.Controls.Add(booking_panel);
            background_panel.Location = new System.Drawing.Point(12, 12);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1176, 576);
            background_panel.TabIndex = 2;
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
            main_panel.Controls.Add(detail_txtbox);
            main_panel.Controls.Add(edit_btn);
            main_panel.Controls.Add(label4);
            main_panel.Controls.Add(gender_cbbox);
            main_panel.Controls.Add(contact_txtbox);
            main_panel.Controls.Add(txtFullname);
            main_panel.Controls.Add(save_btn);
            main_panel.Controls.Add(label3);
            main_panel.Controls.Add(contact_lb);
            main_panel.Controls.Add(label1);
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
            // 
            // detail_txtbox
            // 
            detail_txtbox.Enabled = false;
            detail_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            detail_txtbox.Location = new System.Drawing.Point(155, 217);
            detail_txtbox.Name = "detail_txtbox";
            detail_txtbox.Size = new System.Drawing.Size(600, 32);
            detail_txtbox.TabIndex = 3;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = System.Drawing.Color.DarkGreen;
            edit_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            edit_btn.ForeColor = System.Drawing.Color.Snow;
            edit_btn.Location = new System.Drawing.Point(477, 145);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new System.Drawing.Size(123, 40);
            edit_btn.TabIndex = 9;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(477, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 24);
            label4.TabIndex = 8;
            label4.Text = "Gender:";
            // 
            // gender_cbbox
            // 
            gender_cbbox.Font = new System.Drawing.Font("Candara", 12F);
            gender_cbbox.FormattingEnabled = true;
            gender_cbbox.Items.AddRange(new object[] { "Male", "Female" });
            gender_cbbox.Location = new System.Drawing.Point(560, 38);
            gender_cbbox.Name = "gender_cbbox";
            gender_cbbox.Size = new System.Drawing.Size(117, 32);
            gender_cbbox.TabIndex = 7;
            // 
            // contact_txtbox
            // 
            contact_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            contact_txtbox.Location = new System.Drawing.Point(217, 76);
            contact_txtbox.Name = "contact_txtbox";
            contact_txtbox.Size = new System.Drawing.Size(216, 32);
            contact_txtbox.TabIndex = 6;
            // 
            // txtFullname
            // 
            txtFullname.Font = new System.Drawing.Font("Candara", 12F);
            txtFullname.Location = new System.Drawing.Point(217, 37);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new System.Drawing.Size(216, 32);
            txtFullname.TabIndex = 5;
            txtFullname.TextChanged += txtFullname_TextChanged;
            // 
            // save_btn
            // 
            save_btn.BackColor = System.Drawing.Color.DarkGreen;
            save_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            save_btn.ForeColor = System.Drawing.Color.Snow;
            save_btn.Location = new System.Drawing.Point(310, 145);
            save_btn.Name = "save_btn";
            save_btn.Size = new System.Drawing.Size(123, 40);
            save_btn.TabIndex = 4;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(477, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 20);
            label3.TabIndex = 2;
            // 
            // contact_lb
            // 
            contact_lb.AutoSize = true;
            contact_lb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            contact_lb.Location = new System.Drawing.Point(130, 84);
            contact_lb.Name = "contact_lb";
            contact_lb.Size = new System.Drawing.Size(81, 24);
            contact_lb.TabIndex = 1;
            contact_lb.Text = "Contact:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(121, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // info_panel
            // 
            info_panel.BackColor = System.Drawing.Color.Teal;
            info_panel.Controls.Add(info_icon);
            info_panel.Controls.Add(info_label);
            info_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            info_panel.Location = new System.Drawing.Point(0, 104);
            info_panel.Name = "info_panel";
            info_panel.Size = new System.Drawing.Size(157, 54);
            info_panel.TabIndex = 2;
            // 
            // info_icon
            // 
            info_icon.Image = (System.Drawing.Image)resources.GetObject("info_icon.Image");
            info_icon.Location = new System.Drawing.Point(3, 2);
            info_icon.Name = "info_icon";
            info_icon.Size = new System.Drawing.Size(50, 50);
            info_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            info_icon.TabIndex = 1;
            info_icon.TabStop = false;
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            info_label.ForeColor = System.Drawing.Color.Snow;
            info_label.Location = new System.Drawing.Point(65, 13);
            info_label.Name = "info_label";
            info_label.Size = new System.Drawing.Size(45, 24);
            info_label.TabIndex = 0;
            info_label.Text = "Info";
            // 
            // booking_panel
            // 
            booking_panel.BackColor = System.Drawing.Color.Snow;
            booking_panel.Controls.Add(booking_icon);
            booking_panel.Controls.Add(booking_label);
            booking_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            booking_panel.Location = new System.Drawing.Point(0, 193);
            booking_panel.Name = "booking_panel";
            booking_panel.Size = new System.Drawing.Size(157, 54);
            booking_panel.TabIndex = 3;
            booking_panel.Click += booking_Click;
            // 
            // booking_icon
            // 
            booking_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            booking_icon.Image = (System.Drawing.Image)resources.GetObject("booking_icon.Image");
            booking_icon.Location = new System.Drawing.Point(3, 2);
            booking_icon.Name = "booking_icon";
            booking_icon.Size = new System.Drawing.Size(50, 50);
            booking_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            booking_icon.TabIndex = 1;
            booking_icon.TabStop = false;
            booking_icon.Click += booking_Click;
            // 
            // booking_label
            // 
            booking_label.AutoSize = true;
            booking_label.Cursor = System.Windows.Forms.Cursors.Hand;
            booking_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            booking_label.ForeColor = System.Drawing.Color.Black;
            booking_label.Location = new System.Drawing.Point(65, 15);
            booking_label.Name = "booking_label";
            booking_label.Size = new System.Drawing.Size(81, 24);
            booking_label.TabIndex = 0;
            booking_label.Text = "Booking";
            booking_label.Click += booking_Click;
            // 
            // GuestInfoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "GuestInfoForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GuestInfoForm";
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)info_icon).EndInit();
            booking_panel.ResumeLayout(false);
            booking_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booking_icon).EndInit();
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
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.PictureBox info_icon;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Panel booking_panel;
        private System.Windows.Forms.PictureBox booking_icon;
        private System.Windows.Forms.Label booking_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.ComboBox gender_cbbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contact_txtbox;
        private System.Windows.Forms.Label contact_lb;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox detail_txtbox;
    }
}