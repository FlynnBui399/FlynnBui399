namespace OOPR_FinalProject.Manager_Forms
{
    partial class ManagerCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerCategoryForm));
            main_panel = new System.Windows.Forms.Panel();
            delete_btn = new System.Windows.Forms.Button();
            save_btn = new System.Windows.Forms.Button();
            cost_txtbox = new System.Windows.Forms.TextBox();
            edit_btn = new System.Windows.Forms.Button();
            category_txtbox = new System.Windows.Forms.TextBox();
            category_table = new System.Windows.Forms.DataGridView();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            logout_label = new System.Windows.Forms.Label();
            room_panel = new System.Windows.Forms.Panel();
            room_icon = new System.Windows.Forms.PictureBox();
            room_label = new System.Windows.Forms.Label();
            category_panel = new System.Windows.Forms.Panel();
            category_icon = new System.Windows.Forms.PictureBox();
            category_label = new System.Windows.Forms.Label();
            background_panel = new System.Windows.Forms.Panel();
            report_panel = new System.Windows.Forms.Panel();
            report_icon = new System.Windows.Forms.PictureBox();
            report_label = new System.Windows.Forms.Label();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)category_table).BeginInit();
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
            main_panel.Controls.Add(delete_btn);
            main_panel.Controls.Add(save_btn);
            main_panel.Controls.Add(cost_txtbox);
            main_panel.Controls.Add(edit_btn);
            main_panel.Controls.Add(category_txtbox);
            main_panel.Controls.Add(category_table);
            main_panel.ForeColor = System.Drawing.Color.Black;
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
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
            // cost_txtbox
            // 
            cost_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            cost_txtbox.Location = new System.Drawing.Point(565, 76);
            cost_txtbox.Name = "cost_txtbox";
            cost_txtbox.PlaceholderText = "Cost";
            cost_txtbox.Size = new System.Drawing.Size(237, 32);
            cost_txtbox.TabIndex = 10;
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
            // category_txtbox
            // 
            category_txtbox.Font = new System.Drawing.Font("Candara", 12F);
            category_txtbox.Location = new System.Drawing.Point(273, 76);
            category_txtbox.Name = "category_txtbox";
            category_txtbox.PlaceholderText = "Catogories Name";
            category_txtbox.Size = new System.Drawing.Size(237, 32);
            category_txtbox.TabIndex = 1;
            // 
            // category_table
            // 
            category_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            category_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            category_table.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            category_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            category_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            category_table.DefaultCellStyle = dataGridViewCellStyle2;
            category_table.GridColor = System.Drawing.Color.Snow;
            category_table.Location = new System.Drawing.Point(3, 189);
            category_table.Name = "category_table";
            category_table.RowHeadersWidth = 51;
            category_table.Size = new System.Drawing.Size(1009, 320);
            category_table.TabIndex = 0;
            category_table.CellClick += category_table_CellClick;
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
            logo_icon.Click += report_Click;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new System.Drawing.Font("Candara", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            title_label.ForeColor = System.Drawing.Color.Black;
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
            room_panel.BackColor = System.Drawing.Color.Snow;
            room_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            room_panel.Controls.Add(room_icon);
            room_panel.Controls.Add(room_label);
            room_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            room_panel.Location = new System.Drawing.Point(0, 104);
            room_panel.Name = "room_panel";
            room_panel.Size = new System.Drawing.Size(157, 54);
            room_panel.TabIndex = 2;
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
            // category_panel
            // 
            category_panel.BackColor = System.Drawing.Color.Teal;
            category_panel.Controls.Add(category_icon);
            category_panel.Controls.Add(category_label);
            category_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            category_panel.Location = new System.Drawing.Point(0, 191);
            category_panel.Name = "category_panel";
            category_panel.Size = new System.Drawing.Size(157, 54);
            category_panel.TabIndex = 3;
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
            // 
            // category_label
            // 
            category_label.AutoSize = true;
            category_label.Cursor = System.Windows.Forms.Cursors.Hand;
            category_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            category_label.ForeColor = System.Drawing.Color.Snow;
            category_label.Location = new System.Drawing.Point(56, 15);
            category_label.Name = "category_label";
            category_label.Size = new System.Drawing.Size(101, 24);
            category_label.TabIndex = 0;
            category_label.Text = "Categories";
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
            background_panel.TabIndex = 5;
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
            report_panel.TabIndex = 24;
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
            // ManagerCategoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            ForeColor = System.Drawing.Color.DarkOrange;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ManagerCategoryForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ManagerCategoryForm";
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)category_table).EndInit();
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
        private System.Windows.Forms.TextBox category_txtbox;
        private System.Windows.Forms.DataGridView category_table;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.PictureBox logout_icon;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.Panel room_panel;
        private System.Windows.Forms.PictureBox room_icon;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.PictureBox category_icon;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.TextBox cost_txtbox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Panel report_panel;
        private System.Windows.Forms.PictureBox report_icon;
        private System.Windows.Forms.Label report_label;
    }
}