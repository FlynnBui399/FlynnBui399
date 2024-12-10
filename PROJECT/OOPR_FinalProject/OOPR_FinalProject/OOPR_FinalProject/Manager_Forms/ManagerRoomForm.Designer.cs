namespace OOPR_FinalProject
{
    partial class ManagerRoomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerRoomForm));
            main_panel = new System.Windows.Forms.Panel();
            room_table = new System.Windows.Forms.DataGridView();
            delete_btn = new System.Windows.Forms.Button();
            save_btn = new System.Windows.Forms.Button();
            rstatus_cbbox = new System.Windows.Forms.ComboBox();
            edit_btn = new System.Windows.Forms.Button();
            rstatus_label = new System.Windows.Forms.Label();
            roomtype_label = new System.Windows.Forms.Label();
            rname_label = new System.Windows.Forms.Label();
            rtype_cbbox = new System.Windows.Forms.ComboBox();
            rname_txtbox = new System.Windows.Forms.TextBox();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            logout_label = new System.Windows.Forms.Label();
            room_panel = new System.Windows.Forms.Panel();
            room_icon = new System.Windows.Forms.PictureBox();
            rooms_label = new System.Windows.Forms.Label();
            category_panel = new System.Windows.Forms.Panel();
            category_icon = new System.Windows.Forms.PictureBox();
            category_label = new System.Windows.Forms.Label();
            background_panel = new System.Windows.Forms.Panel();
            report_panel = new System.Windows.Forms.Panel();
            report_icon = new System.Windows.Forms.PictureBox();
            report_label = new System.Windows.Forms.Label();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)room_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            room_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)room_icon).BeginInit();
            category_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)category_icon).BeginInit();
            background_panel.SuspendLayout();
            report_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)report_icon).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = System.Drawing.Color.Ivory;
            main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            main_panel.Controls.Add(room_table);
            main_panel.Controls.Add(delete_btn);
            main_panel.Controls.Add(save_btn);
            main_panel.Controls.Add(rstatus_cbbox);
            main_panel.Controls.Add(edit_btn);
            main_panel.Controls.Add(rstatus_label);
            main_panel.Controls.Add(roomtype_label);
            main_panel.Controls.Add(rname_label);
            main_panel.Controls.Add(rtype_cbbox);
            main_panel.Controls.Add(rname_txtbox);
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
            // 
            // room_table
            // 
            room_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            room_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            room_table.BackgroundColor = System.Drawing.Color.Ivory;
            room_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            room_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            room_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            room_table.DefaultCellStyle = dataGridViewCellStyle2;
            room_table.GridColor = System.Drawing.Color.Snow;
            room_table.Location = new System.Drawing.Point(3, 186);
            room_table.Name = "room_table";
            room_table.RowHeadersWidth = 51;
            room_table.Size = new System.Drawing.Size(1009, 320);
            room_table.TabIndex = 13;
            room_table.CellClick += room_table_CellClick;
            room_table.CellContentClick += room_table_CellContentClick;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = System.Drawing.Color.DarkGreen;
            delete_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            delete_btn.ForeColor = System.Drawing.Color.Snow;
            delete_btn.Location = new System.Drawing.Point(663, 120);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new System.Drawing.Size(132, 39);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = System.Drawing.Color.DarkGreen;
            save_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            save_btn.ForeColor = System.Drawing.Color.Snow;
            save_btn.Location = new System.Drawing.Point(466, 120);
            save_btn.Name = "save_btn";
            save_btn.Size = new System.Drawing.Size(132, 39);
            save_btn.TabIndex = 11;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // rstatus_cbbox
            // 
            rstatus_cbbox.Font = new System.Drawing.Font("Candara", 12F);
            rstatus_cbbox.FormattingEnabled = true;
            rstatus_cbbox.Items.AddRange(new object[] { "Booked", "Available" });
            rstatus_cbbox.Location = new System.Drawing.Point(673, 69);
            rstatus_cbbox.Name = "rstatus_cbbox";
            rstatus_cbbox.Size = new System.Drawing.Size(151, 32);
            rstatus_cbbox.TabIndex = 10;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = System.Drawing.Color.DarkGreen;
            edit_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            edit_btn.ForeColor = System.Drawing.Color.Snow;
            edit_btn.Location = new System.Drawing.Point(269, 120);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new System.Drawing.Size(132, 39);
            edit_btn.TabIndex = 9;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // rstatus_label
            // 
            rstatus_label.AutoSize = true;
            rstatus_label.Cursor = System.Windows.Forms.Cursors.Hand;
            rstatus_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rstatus_label.ForeColor = System.Drawing.Color.Black;
            rstatus_label.Location = new System.Drawing.Point(673, 42);
            rstatus_label.Name = "rstatus_label";
            rstatus_label.Size = new System.Drawing.Size(68, 24);
            rstatus_label.TabIndex = 7;
            rstatus_label.Text = "Status:";
            // 
            // roomtype_label
            // 
            roomtype_label.AutoSize = true;
            roomtype_label.Cursor = System.Windows.Forms.Cursors.Hand;
            roomtype_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            roomtype_label.ForeColor = System.Drawing.Color.Black;
            roomtype_label.Location = new System.Drawing.Point(454, 42);
            roomtype_label.Name = "roomtype_label";
            roomtype_label.Size = new System.Drawing.Size(111, 24);
            roomtype_label.TabIndex = 6;
            roomtype_label.Text = "Room Type:";
            // 
            // rname_label
            // 
            rname_label.AutoSize = true;
            rname_label.Cursor = System.Windows.Forms.Cursors.Hand;
            rname_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rname_label.ForeColor = System.Drawing.Color.Black;
            rname_label.Location = new System.Drawing.Point(219, 42);
            rname_label.Name = "rname_label";
            rname_label.Size = new System.Drawing.Size(65, 24);
            rname_label.TabIndex = 5;
            rname_label.Text = "Name:";
            // 
            // rtype_cbbox
            // 
            rtype_cbbox.Font = new System.Drawing.Font("Candara", 12F);
            rtype_cbbox.FormattingEnabled = true;
            rtype_cbbox.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            rtype_cbbox.Location = new System.Drawing.Point(454, 69);
            rtype_cbbox.Name = "rtype_cbbox";
            rtype_cbbox.Size = new System.Drawing.Size(151, 32);
            rtype_cbbox.TabIndex = 4;
            // 
            // rname_txtbox
            // 
            rname_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            rname_txtbox.Location = new System.Drawing.Point(219, 69);
            rname_txtbox.Name = "rname_txtbox";
            rname_txtbox.Size = new System.Drawing.Size(182, 32);
            rname_txtbox.TabIndex = 1;
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
            // room_panel
            // 
            room_panel.BackColor = System.Drawing.Color.Teal;
            room_panel.Controls.Add(room_icon);
            room_panel.Controls.Add(rooms_label);
            room_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            room_panel.Location = new System.Drawing.Point(0, 104);
            room_panel.Name = "room_panel";
            room_panel.Size = new System.Drawing.Size(157, 54);
            room_panel.TabIndex = 2;
            // 
            // room_icon
            // 
            room_icon.Image = (System.Drawing.Image)resources.GetObject("room_icon.Image");
            room_icon.Location = new System.Drawing.Point(3, 2);
            room_icon.Name = "room_icon";
            room_icon.Size = new System.Drawing.Size(50, 50);
            room_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            room_icon.TabIndex = 1;
            room_icon.TabStop = false;
            // 
            // rooms_label
            // 
            rooms_label.AutoSize = true;
            rooms_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rooms_label.ForeColor = System.Drawing.Color.Snow;
            rooms_label.Location = new System.Drawing.Point(56, 13);
            rooms_label.Name = "rooms_label";
            rooms_label.Size = new System.Drawing.Size(69, 24);
            rooms_label.TabIndex = 0;
            rooms_label.Text = "Rooms";
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
            category_panel.TabIndex = 3;
            category_panel.Click += category_Click;
            // 
            // category_icon
            // 
            category_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            category_icon.Image = (System.Drawing.Image)resources.GetObject("category_icon.Image");
            category_icon.Location = new System.Drawing.Point(3, 1);
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
            // background_panel
            // 
            background_panel.BackColor = System.Drawing.Color.Snow;
            background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            background_panel.Controls.Add(logo_icon);
            background_panel.Controls.Add(title_label);
            background_panel.Controls.Add(logout_panel);
            background_panel.Controls.Add(main_panel);
            background_panel.Controls.Add(room_panel);
            background_panel.Controls.Add(category_panel);
            background_panel.Controls.Add(report_panel);
            background_panel.Location = new System.Drawing.Point(12, 12);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1176, 576);
            background_panel.TabIndex = 5;
            // 
            // report_panel
            // 
            report_panel.BackColor = System.Drawing.Color.Snow;
            report_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            report_panel.Controls.Add(report_icon);
            report_panel.Controls.Add(report_label);
            report_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            report_panel.Location = new System.Drawing.Point(0, 272);
            report_panel.Name = "report_panel";
            report_panel.Size = new System.Drawing.Size(157, 54);
            report_panel.TabIndex = 4;
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
            // ManagerRoomForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ManagerRoomForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ManagerRoomForm";
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)room_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            room_panel.ResumeLayout(false);
            room_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)room_icon).EndInit();
            category_panel.ResumeLayout(false);
            category_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)category_icon).EndInit();
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            report_panel.ResumeLayout(false);
            report_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)report_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label rstatus_label;
        private System.Windows.Forms.Label roomtype_label;
        private System.Windows.Forms.Label rname_label;
        private System.Windows.Forms.ComboBox rtype_cbbox;
        private System.Windows.Forms.TextBox rname_txtbox;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.PictureBox logout_icon;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Panel room_panel;
        private System.Windows.Forms.PictureBox room_icon;
        private System.Windows.Forms.Label rooms_label;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.PictureBox category_icon;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.ComboBox rstatus_cbbox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DataGridView room_table;
        private System.Windows.Forms.Panel report_panel;
        private System.Windows.Forms.PictureBox report_icon;
        private System.Windows.Forms.Label report_label;
    }
}