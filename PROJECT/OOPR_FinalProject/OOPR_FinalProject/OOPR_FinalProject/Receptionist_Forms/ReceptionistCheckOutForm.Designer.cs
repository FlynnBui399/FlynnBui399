namespace OOPR_FinalProject.Receptionist_Forms
{
    partial class ReceptionistCheckOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistCheckOutForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            background_panel = new System.Windows.Forms.Panel();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            logout_label = new System.Windows.Forms.Label();
            main_panel = new System.Windows.Forms.Panel();
            reservation_table = new System.Windows.Forms.DataGridView();
            invoice_btn = new System.Windows.Forms.Button();
            customer_cbbox = new System.Windows.Forms.ComboBox();
            checkout_datepicker = new System.Windows.Forms.DateTimePicker();
            find_button = new System.Windows.Forms.Button();
            roomid_cbbox = new System.Windows.Forms.ComboBox();
            checkoutdate_label = new System.Windows.Forms.Label();
            guestid_label = new System.Windows.Forms.Label();
            roomid_label = new System.Windows.Forms.Label();
            checkin_panel = new System.Windows.Forms.Panel();
            checkin_icon = new System.Windows.Forms.PictureBox();
            checkin_label = new System.Windows.Forms.Label();
            checkout_panel = new System.Windows.Forms.Panel();
            checkout_icon = new System.Windows.Forms.PictureBox();
            checkout_label = new System.Windows.Forms.Label();
            background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservation_table).BeginInit();
            checkin_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkin_icon).BeginInit();
            checkout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkout_icon).BeginInit();
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
            background_panel.Controls.Add(checkin_panel);
            background_panel.Controls.Add(checkout_panel);
            background_panel.Location = new System.Drawing.Point(12, 12);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1176, 576);
            background_panel.TabIndex = 3;
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
            main_panel.Controls.Add(reservation_table);
            main_panel.Controls.Add(invoice_btn);
            main_panel.Controls.Add(customer_cbbox);
            main_panel.Controls.Add(checkout_datepicker);
            main_panel.Controls.Add(find_button);
            main_panel.Controls.Add(roomid_cbbox);
            main_panel.Controls.Add(checkoutdate_label);
            main_panel.Controls.Add(guestid_label);
            main_panel.Controls.Add(roomid_label);
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
            // 
            // reservation_table
            // 
            reservation_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            reservation_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            reservation_table.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            reservation_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            reservation_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            reservation_table.DefaultCellStyle = dataGridViewCellStyle2;
            reservation_table.GridColor = System.Drawing.Color.Snow;
            reservation_table.Location = new System.Drawing.Point(5, 194);
            reservation_table.Name = "reservation_table";
            reservation_table.RowHeadersWidth = 51;
            reservation_table.Size = new System.Drawing.Size(1009, 302);
            reservation_table.TabIndex = 20;
            // 
            // invoice_btn
            // 
            invoice_btn.BackColor = System.Drawing.Color.DarkGreen;
            invoice_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            invoice_btn.ForeColor = System.Drawing.Color.Snow;
            invoice_btn.Location = new System.Drawing.Point(285, 113);
            invoice_btn.Name = "invoice_btn";
            invoice_btn.Size = new System.Drawing.Size(187, 39);
            invoice_btn.TabIndex = 19;
            invoice_btn.Text = "Bills";
            invoice_btn.UseVisualStyleBackColor = false;
            invoice_btn.Click += invoice_btn_Click;
            // 
            // customer_cbbox
            // 
            customer_cbbox.Font = new System.Drawing.Font("Candara", 9F);
            customer_cbbox.FormattingEnabled = true;
            customer_cbbox.Location = new System.Drawing.Point(200, 67);
            customer_cbbox.Name = "customer_cbbox";
            customer_cbbox.Size = new System.Drawing.Size(151, 26);
            customer_cbbox.TabIndex = 18;
            // 
            // checkout_datepicker
            // 
            checkout_datepicker.Font = new System.Drawing.Font("Candara", 9F);
            checkout_datepicker.Location = new System.Drawing.Point(648, 67);
            checkout_datepicker.Name = "checkout_datepicker";
            checkout_datepicker.Size = new System.Drawing.Size(250, 26);
            checkout_datepicker.TabIndex = 12;
            // 
            // find_button
            // 
            find_button.BackColor = System.Drawing.Color.DarkGreen;
            find_button.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            find_button.ForeColor = System.Drawing.Color.Snow;
            find_button.Location = new System.Drawing.Point(522, 113);
            find_button.Name = "find_button";
            find_button.Size = new System.Drawing.Size(187, 39);
            find_button.TabIndex = 17;
            find_button.Text = "Find Reservation";
            find_button.UseVisualStyleBackColor = false;
            find_button.Click += find_button_Click;
            // 
            // roomid_cbbox
            // 
            roomid_cbbox.Font = new System.Drawing.Font("Candara", 9F);
            roomid_cbbox.FormattingEnabled = true;
            roomid_cbbox.Location = new System.Drawing.Point(424, 67);
            roomid_cbbox.Name = "roomid_cbbox";
            roomid_cbbox.Size = new System.Drawing.Size(151, 26);
            roomid_cbbox.TabIndex = 13;
            // 
            // checkoutdate_label
            // 
            checkoutdate_label.AutoSize = true;
            checkoutdate_label.Cursor = System.Windows.Forms.Cursors.Hand;
            checkoutdate_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkoutdate_label.ForeColor = System.Drawing.Color.Black;
            checkoutdate_label.Location = new System.Drawing.Point(648, 41);
            checkoutdate_label.Name = "checkoutdate_label";
            checkoutdate_label.Size = new System.Drawing.Size(146, 24);
            checkoutdate_label.TabIndex = 16;
            checkoutdate_label.Text = "Check Out Date:";
            // 
            // guestid_label
            // 
            guestid_label.AutoSize = true;
            guestid_label.Cursor = System.Windows.Forms.Cursors.Hand;
            guestid_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            guestid_label.ForeColor = System.Drawing.Color.Black;
            guestid_label.Location = new System.Drawing.Point(200, 41);
            guestid_label.Name = "guestid_label";
            guestid_label.Size = new System.Drawing.Size(86, 24);
            guestid_label.TabIndex = 14;
            guestid_label.Text = "Guest ID:";
            // 
            // roomid_label
            // 
            roomid_label.AutoSize = true;
            roomid_label.Cursor = System.Windows.Forms.Cursors.Hand;
            roomid_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            roomid_label.ForeColor = System.Drawing.Color.Black;
            roomid_label.Location = new System.Drawing.Point(424, 41);
            roomid_label.Name = "roomid_label";
            roomid_label.Size = new System.Drawing.Size(89, 24);
            roomid_label.TabIndex = 15;
            roomid_label.Text = "Room ID:";
            // 
            // checkin_panel
            // 
            checkin_panel.BackColor = System.Drawing.Color.Snow;
            checkin_panel.Controls.Add(checkin_icon);
            checkin_panel.Controls.Add(checkin_label);
            checkin_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            checkin_panel.Location = new System.Drawing.Point(0, 104);
            checkin_panel.Name = "checkin_panel";
            checkin_panel.Size = new System.Drawing.Size(157, 54);
            checkin_panel.TabIndex = 2;
            checkin_panel.Click += checkin_Click;
            // 
            // checkin_icon
            // 
            checkin_icon.Image = (System.Drawing.Image)resources.GetObject("checkin_icon.Image");
            checkin_icon.Location = new System.Drawing.Point(3, 2);
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
            // checkout_panel
            // 
            checkout_panel.BackColor = System.Drawing.Color.Teal;
            checkout_panel.Controls.Add(checkout_icon);
            checkout_panel.Controls.Add(checkout_label);
            checkout_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            checkout_panel.Location = new System.Drawing.Point(0, 193);
            checkout_panel.Name = "checkout_panel";
            checkout_panel.Size = new System.Drawing.Size(157, 54);
            checkout_panel.TabIndex = 3;
            // 
            // checkout_icon
            // 
            checkout_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            checkout_icon.Image = (System.Drawing.Image)resources.GetObject("checkout_icon.Image");
            checkout_icon.Location = new System.Drawing.Point(3, 2);
            checkout_icon.Name = "checkout_icon";
            checkout_icon.Size = new System.Drawing.Size(50, 50);
            checkout_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            checkout_icon.TabIndex = 1;
            checkout_icon.TabStop = false;
            // 
            // checkout_label
            // 
            checkout_label.AutoSize = true;
            checkout_label.Cursor = System.Windows.Forms.Cursors.Hand;
            checkout_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkout_label.ForeColor = System.Drawing.Color.Snow;
            checkout_label.Location = new System.Drawing.Point(59, 15);
            checkout_label.Name = "checkout_label";
            checkout_label.Size = new System.Drawing.Size(97, 24);
            checkout_label.TabIndex = 0;
            checkout_label.Text = "Check Out";
            // 
            // ReceptionistCheckOutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ReceptionistCheckOutForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ReceptionistCheckOutForm";
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservation_table).EndInit();
            checkin_panel.ResumeLayout(false);
            checkin_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkin_icon).EndInit();
            checkout_panel.ResumeLayout(false);
            checkout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkout_icon).EndInit();
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
        private System.Windows.Forms.Panel checkin_panel;
        private System.Windows.Forms.PictureBox checkin_icon;
        private System.Windows.Forms.Label checkin_label;
        private System.Windows.Forms.Panel checkout_panel;
        private System.Windows.Forms.PictureBox checkout_icon;
        private System.Windows.Forms.Label checkout_label;
        private System.Windows.Forms.ComboBox customer_cbbox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Label checkoutdate_label;
        private System.Windows.Forms.Label roomid_label;
        private System.Windows.Forms.Label guestid_label;
        private System.Windows.Forms.ComboBox roomid_cbbox;
        private System.Windows.Forms.DateTimePicker checkout_datepicker;
        private System.Windows.Forms.Button invoice_btn;
        private System.Windows.Forms.DataGridView reservation_table;
    }
}