namespace OOPR_FinalProject
{
    partial class GuestBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestBookingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            background_panel = new System.Windows.Forms.Panel();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            logout_label = new System.Windows.Forms.Label();
            main_panel = new System.Windows.Forms.Panel();
            id_lb = new System.Windows.Forms.Label();
            guestID_txtbox = new System.Windows.Forms.TextBox();
            guestname_txtbox = new System.Windows.Forms.TextBox();
            guest_lb = new System.Windows.Forms.Label();
            amount_lb = new System.Windows.Forms.Label();
            duration_lb = new System.Windows.Forms.Label();
            amount_txtbox = new System.Windows.Forms.TextBox();
            duration_txtbox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            rooms_table = new System.Windows.Forms.DataGridView();
            roomchose_cbbox = new System.Windows.Forms.ComboBox();
            checkout_datepicker = new System.Windows.Forms.DateTimePicker();
            checkin_datepicker = new System.Windows.Forms.DateTimePicker();
            checkout_label = new System.Windows.Forms.Label();
            checkin_label = new System.Windows.Forms.Label();
            book_btn = new System.Windows.Forms.Button();
            cancelroom_btn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)rooms_table).BeginInit();
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
            main_panel.Controls.Add(id_lb);
            main_panel.Controls.Add(guestID_txtbox);
            main_panel.Controls.Add(guestname_txtbox);
            main_panel.Controls.Add(guest_lb);
            main_panel.Controls.Add(amount_lb);
            main_panel.Controls.Add(duration_lb);
            main_panel.Controls.Add(amount_txtbox);
            main_panel.Controls.Add(duration_txtbox);
            main_panel.Controls.Add(label1);
            main_panel.Controls.Add(rooms_table);
            main_panel.Controls.Add(roomchose_cbbox);
            main_panel.Controls.Add(checkout_datepicker);
            main_panel.Controls.Add(checkin_datepicker);
            main_panel.Controls.Add(checkout_label);
            main_panel.Controls.Add(checkin_label);
            main_panel.Controls.Add(book_btn);
            main_panel.Controls.Add(cancelroom_btn);
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
            // 
            // id_lb
            // 
            id_lb.AutoSize = true;
            id_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            id_lb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            id_lb.ForeColor = System.Drawing.Color.Black;
            id_lb.Location = new System.Drawing.Point(50, 67);
            id_lb.Name = "id_lb";
            id_lb.Size = new System.Drawing.Size(34, 24);
            id_lb.TabIndex = 37;
            id_lb.Text = "ID:";
            // 
            // guestID_txtbox
            // 
            guestID_txtbox.Enabled = false;
            guestID_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            guestID_txtbox.Location = new System.Drawing.Point(90, 61);
            guestID_txtbox.Name = "guestID_txtbox";
            guestID_txtbox.Size = new System.Drawing.Size(41, 32);
            guestID_txtbox.TabIndex = 36;
            // 
            // guestname_txtbox
            // 
            guestname_txtbox.Enabled = false;
            guestname_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            guestname_txtbox.Location = new System.Drawing.Point(90, 23);
            guestname_txtbox.Name = "guestname_txtbox";
            guestname_txtbox.Size = new System.Drawing.Size(125, 32);
            guestname_txtbox.TabIndex = 35;
            // 
            // guest_lb
            // 
            guest_lb.AutoSize = true;
            guest_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            guest_lb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            guest_lb.ForeColor = System.Drawing.Color.Black;
            guest_lb.Location = new System.Drawing.Point(21, 26);
            guest_lb.Name = "guest_lb";
            guest_lb.Size = new System.Drawing.Size(63, 24);
            guest_lb.TabIndex = 33;
            guest_lb.Text = "Guest:";
            // 
            // amount_lb
            // 
            amount_lb.AutoSize = true;
            amount_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            amount_lb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            amount_lb.ForeColor = System.Drawing.Color.Black;
            amount_lb.Location = new System.Drawing.Point(693, 49);
            amount_lb.Name = "amount_lb";
            amount_lb.Size = new System.Drawing.Size(80, 24);
            amount_lb.TabIndex = 31;
            amount_lb.Text = "Amount";
            // 
            // duration_lb
            // 
            duration_lb.AutoSize = true;
            duration_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            duration_lb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            duration_lb.ForeColor = System.Drawing.Color.Black;
            duration_lb.Location = new System.Drawing.Point(452, 49);
            duration_lb.Name = "duration_lb";
            duration_lb.Size = new System.Drawing.Size(86, 24);
            duration_lb.TabIndex = 30;
            duration_lb.Text = "Duration";
            // 
            // amount_txtbox
            // 
            amount_txtbox.Enabled = false;
            amount_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            amount_txtbox.Location = new System.Drawing.Point(779, 43);
            amount_txtbox.Name = "amount_txtbox";
            amount_txtbox.Size = new System.Drawing.Size(182, 32);
            amount_txtbox.TabIndex = 29;
            // 
            // duration_txtbox
            // 
            duration_txtbox.Enabled = false;
            duration_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            duration_txtbox.ForeColor = System.Drawing.SystemColors.WindowText;
            duration_txtbox.Location = new System.Drawing.Point(544, 46);
            duration_txtbox.Name = "duration_txtbox";
            duration_txtbox.Size = new System.Drawing.Size(129, 32);
            duration_txtbox.TabIndex = 28;
            duration_txtbox.TextChanged += duration_txtbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = System.Windows.Forms.Cursors.Hand;
            label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(241, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 24);
            label1.TabIndex = 26;
            label1.Text = "Room:";
            // 
            // rooms_table
            // 
            rooms_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            rooms_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            rooms_table.BackgroundColor = System.Drawing.Color.Ivory;
            rooms_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            rooms_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            rooms_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            rooms_table.DefaultCellStyle = dataGridViewCellStyle2;
            rooms_table.GridColor = System.Drawing.Color.Snow;
            rooms_table.Location = new System.Drawing.Point(7, 219);
            rooms_table.Name = "rooms_table";
            rooms_table.RowHeadersWidth = 51;
            rooms_table.Size = new System.Drawing.Size(1009, 290);
            rooms_table.TabIndex = 24;
            rooms_table.CellClick += rooms_table_CellClick;
            rooms_table.CellContentClick += rooms_table_CellContentClick;
            // 
            // roomchose_cbbox
            // 
            roomchose_cbbox.Font = new System.Drawing.Font("Candara", 12F);
            roomchose_cbbox.FormattingEnabled = true;
            roomchose_cbbox.Location = new System.Drawing.Point(313, 46);
            roomchose_cbbox.Name = "roomchose_cbbox";
            roomchose_cbbox.Size = new System.Drawing.Size(115, 32);
            roomchose_cbbox.TabIndex = 20;
            roomchose_cbbox.SelectedIndexChanged += roomchose_cbbox_SelectedIndexChanged;
            roomchose_cbbox.SelectionChangeCommitted += roomchose_cbbox_SelectionChangeCommitted;
            // 
            // checkout_datepicker
            // 
            checkout_datepicker.Font = new System.Drawing.Font("Candara", 9F);
            checkout_datepicker.Location = new System.Drawing.Point(711, 102);
            checkout_datepicker.Name = "checkout_datepicker";
            checkout_datepicker.Size = new System.Drawing.Size(250, 26);
            checkout_datepicker.TabIndex = 18;
            checkout_datepicker.ValueChanged += checkout_datepicker_ValueChanged;
            // 
            // checkin_datepicker
            // 
            checkin_datepicker.Font = new System.Drawing.Font("Candara", 9F);
            checkin_datepicker.Location = new System.Drawing.Point(259, 106);
            checkin_datepicker.Name = "checkin_datepicker";
            checkin_datepicker.Size = new System.Drawing.Size(250, 26);
            checkin_datepicker.TabIndex = 17;
            checkin_datepicker.ValueChanged += checkin_datepicker_ValueChanged;
            // 
            // checkout_label
            // 
            checkout_label.AutoSize = true;
            checkout_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            checkout_label.Location = new System.Drawing.Point(559, 102);
            checkout_label.Name = "checkout_label";
            checkout_label.Size = new System.Drawing.Size(146, 24);
            checkout_label.TabIndex = 14;
            checkout_label.Text = "Check Out Date:";
            // 
            // checkin_label
            // 
            checkin_label.AutoSize = true;
            checkin_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            checkin_label.Location = new System.Drawing.Point(127, 106);
            checkin_label.Name = "checkin_label";
            checkin_label.Size = new System.Drawing.Size(131, 24);
            checkin_label.TabIndex = 13;
            checkin_label.Text = "Check In Date:";
            // 
            // book_btn
            // 
            book_btn.BackColor = System.Drawing.Color.DarkGreen;
            book_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            book_btn.ForeColor = System.Drawing.Color.Snow;
            book_btn.Location = new System.Drawing.Point(342, 162);
            book_btn.Name = "book_btn";
            book_btn.Size = new System.Drawing.Size(136, 37);
            book_btn.TabIndex = 9;
            book_btn.Text = "Book";
            book_btn.UseVisualStyleBackColor = false;
            book_btn.Click += book_btn_Click;
            // 
            // cancelroom_btn
            // 
            cancelroom_btn.BackColor = System.Drawing.Color.DarkGreen;
            cancelroom_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            cancelroom_btn.ForeColor = System.Drawing.Color.Snow;
            cancelroom_btn.Location = new System.Drawing.Point(544, 162);
            cancelroom_btn.Name = "cancelroom_btn";
            cancelroom_btn.Size = new System.Drawing.Size(136, 37);
            cancelroom_btn.TabIndex = 8;
            cancelroom_btn.Text = "Cancel";
            cancelroom_btn.UseVisualStyleBackColor = false;
            cancelroom_btn.Click += cancelroom_btn_Click;
            // 
            // info_panel
            // 
            info_panel.BackColor = System.Drawing.Color.Snow;
            info_panel.Controls.Add(info_icon);
            info_panel.Controls.Add(info_label);
            info_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            info_panel.Location = new System.Drawing.Point(0, 104);
            info_panel.Name = "info_panel";
            info_panel.Size = new System.Drawing.Size(157, 54);
            info_panel.TabIndex = 2;
            info_panel.Click += info_Click;
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
            info_icon.Click += info_Click;
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            info_label.ForeColor = System.Drawing.Color.Black;
            info_label.Location = new System.Drawing.Point(65, 13);
            info_label.Name = "info_label";
            info_label.Size = new System.Drawing.Size(45, 24);
            info_label.TabIndex = 0;
            info_label.Text = "Info";
            info_label.Click += info_Click;
            // 
            // booking_panel
            // 
            booking_panel.BackColor = System.Drawing.Color.Teal;
            booking_panel.Controls.Add(booking_icon);
            booking_panel.Controls.Add(booking_label);
            booking_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            booking_panel.Location = new System.Drawing.Point(0, 193);
            booking_panel.Name = "booking_panel";
            booking_panel.Size = new System.Drawing.Size(157, 54);
            booking_panel.TabIndex = 3;
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
            // 
            // booking_label
            // 
            booking_label.AutoSize = true;
            booking_label.Cursor = System.Windows.Forms.Cursors.Hand;
            booking_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            booking_label.ForeColor = System.Drawing.Color.Snow;
            booking_label.Location = new System.Drawing.Point(65, 15);
            booking_label.Name = "booking_label";
            booking_label.Size = new System.Drawing.Size(81, 24);
            booking_label.TabIndex = 0;
            booking_label.Text = "Booking";
            // 
            // GuestBookingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "GuestBookingForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GuestBookingForm";
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rooms_table).EndInit();
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
        private System.Windows.Forms.Button cancelroom_btn;
        private System.Windows.Forms.Button book_btn;
        private System.Windows.Forms.Label checkin_label;
        private System.Windows.Forms.Label checkout_label;
        private System.Windows.Forms.DateTimePicker checkout_datepicker;
        private System.Windows.Forms.DateTimePicker checkin_datepicker;
        private System.Windows.Forms.ComboBox roomchose_cbbox;
        private System.Windows.Forms.DataGridView rooms_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox duration_txtbox;
        private System.Windows.Forms.TextBox amount_txtbox;
        private System.Windows.Forms.Label duration_lb;
        private System.Windows.Forms.Label amount_lb;
        private System.Windows.Forms.Label guest_lb;
        private System.Windows.Forms.TextBox guestname_txtbox;
        private System.Windows.Forms.TextBox guestID_txtbox;
        private System.Windows.Forms.Label id_lb;
    }
}