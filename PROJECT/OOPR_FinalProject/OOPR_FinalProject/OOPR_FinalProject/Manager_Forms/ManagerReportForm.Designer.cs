namespace OOPR_FinalProject
{
    partial class ManagerReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerReportForm));
            category_label = new System.Windows.Forms.Label();
            category_panel = new System.Windows.Forms.Panel();
            category_icon = new System.Windows.Forms.PictureBox();
            room_icon = new System.Windows.Forms.PictureBox();
            room_label = new System.Windows.Forms.Label();
            room_panel = new System.Windows.Forms.Panel();
            report_icon = new System.Windows.Forms.PictureBox();
            report_label = new System.Windows.Forms.Label();
            report_panel = new System.Windows.Forms.Panel();
            main_panel = new System.Windows.Forms.Panel();
            customer_label = new System.Windows.Forms.Label();
            date_label = new System.Windows.Forms.Label();
            rp_customer_cbbox = new System.Windows.Forms.ComboBox();
            income_date = new System.Windows.Forms.DateTimePicker();
            panel5 = new System.Windows.Forms.Panel();
            rp_cusincome_panel = new System.Windows.Forms.Panel();
            rp_cusincome_label = new System.Windows.Forms.Label();
            rp_cusincome_ttlabel = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            rp_dailyincome_panel = new System.Windows.Forms.Panel();
            rp_dailyincome_label = new System.Windows.Forms.Label();
            rp_dailyincome_ttlabel = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            rp_finance_panel = new System.Windows.Forms.Panel();
            rp_finance_label = new System.Windows.Forms.Label();
            rp_finance_ttlabel = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            rp_customer_panel = new System.Windows.Forms.Panel();
            rp_customer_label = new System.Windows.Forms.Label();
            rp_customer_ttlabel = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            rp_room_panel = new System.Windows.Forms.Panel();
            rp_room_label = new System.Windows.Forms.Label();
            rp_room_ttlabel = new System.Windows.Forms.Label();
            logout_icon = new System.Windows.Forms.PictureBox();
            logout_label = new System.Windows.Forms.Label();
            logo_icon = new System.Windows.Forms.PictureBox();
            title_label = new System.Windows.Forms.Label();
            logout_panel = new System.Windows.Forms.Panel();
            background_panel = new System.Windows.Forms.Panel();
            category_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)category_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room_icon).BeginInit();
            room_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)report_icon).BeginInit();
            report_panel.SuspendLayout();
            main_panel.SuspendLayout();
            panel5.SuspendLayout();
            rp_cusincome_panel.SuspendLayout();
            panel4.SuspendLayout();
            rp_dailyincome_panel.SuspendLayout();
            panel3.SuspendLayout();
            rp_finance_panel.SuspendLayout();
            panel2.SuspendLayout();
            rp_customer_panel.SuspendLayout();
            panel1.SuspendLayout();
            rp_room_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            logout_panel.SuspendLayout();
            background_panel.SuspendLayout();
            SuspendLayout();
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
            category_icon.Location = new System.Drawing.Point(3, 1);
            category_icon.Name = "category_icon";
            category_icon.Size = new System.Drawing.Size(50, 50);
            category_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            category_icon.TabIndex = 1;
            category_icon.TabStop = false;
            category_icon.Click += category_Click;
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
            // report_icon
            // 
            report_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            report_icon.Image = (System.Drawing.Image)resources.GetObject("report_icon.Image");
            report_icon.Location = new System.Drawing.Point(3, 2);
            report_icon.Name = "report_icon";
            report_icon.Size = new System.Drawing.Size(50, 50);
            report_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            report_icon.TabIndex = 1;
            report_icon.TabStop = false;
            // 
            // report_label
            // 
            report_label.AutoSize = true;
            report_label.Cursor = System.Windows.Forms.Cursors.Hand;
            report_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            report_label.ForeColor = System.Drawing.Color.Snow;
            report_label.Location = new System.Drawing.Point(56, 15);
            report_label.Name = "report_label";
            report_label.Size = new System.Drawing.Size(77, 24);
            report_label.TabIndex = 0;
            report_label.Text = "Reports";
            // 
            // report_panel
            // 
            report_panel.BackColor = System.Drawing.Color.Teal;
            report_panel.Controls.Add(report_icon);
            report_panel.Controls.Add(report_label);
            report_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            report_panel.ForeColor = System.Drawing.Color.DarkOrange;
            report_panel.Location = new System.Drawing.Point(0, 272);
            report_panel.Name = "report_panel";
            report_panel.Size = new System.Drawing.Size(157, 54);
            report_panel.TabIndex = 27;
            // 
            // main_panel
            // 
            main_panel.BackColor = System.Drawing.Color.Ivory;
            main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            main_panel.Controls.Add(customer_label);
            main_panel.Controls.Add(date_label);
            main_panel.Controls.Add(rp_customer_cbbox);
            main_panel.Controls.Add(income_date);
            main_panel.Controls.Add(panel5);
            main_panel.Controls.Add(panel4);
            main_panel.Controls.Add(panel3);
            main_panel.Controls.Add(panel2);
            main_panel.Controls.Add(panel1);
            main_panel.Location = new System.Drawing.Point(156, 62);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1017, 514);
            main_panel.TabIndex = 0;
            // 
            // customer_label
            // 
            customer_label.AutoSize = true;
            customer_label.BackColor = System.Drawing.Color.Transparent;
            customer_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            customer_label.ForeColor = System.Drawing.Color.Black;
            customer_label.Location = new System.Drawing.Point(403, 226);
            customer_label.Name = "customer_label";
            customer_label.Size = new System.Drawing.Size(98, 24);
            customer_label.TabIndex = 8;
            customer_label.Text = "Customer:";
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.BackColor = System.Drawing.Color.Transparent;
            date_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            date_label.ForeColor = System.Drawing.Color.Black;
            date_label.Location = new System.Drawing.Point(403, 165);
            date_label.Name = "date_label";
            date_label.Size = new System.Drawing.Size(55, 24);
            date_label.TabIndex = 7;
            date_label.Text = "Date:";
            // 
            // rp_customer_cbbox
            // 
            rp_customer_cbbox.FormattingEnabled = true;
            rp_customer_cbbox.Location = new System.Drawing.Point(400, 260);
            rp_customer_cbbox.Name = "rp_customer_cbbox";
            rp_customer_cbbox.Size = new System.Drawing.Size(250, 28);
            rp_customer_cbbox.TabIndex = 5;
            rp_customer_cbbox.SelectedIndexChanged += rp_customer_cbbox_SelectedIndexChanged;
            // 
            // income_date
            // 
            income_date.CalendarFont = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            income_date.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            income_date.Location = new System.Drawing.Point(400, 197);
            income_date.Name = "income_date";
            income_date.Size = new System.Drawing.Size(250, 26);
            income_date.TabIndex = 4;
            income_date.ValueChanged += income_date_ValueChanged;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.DimGray;
            panel5.Controls.Add(rp_cusincome_panel);
            panel5.Location = new System.Drawing.Point(762, 107);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(250, 141);
            panel5.TabIndex = 3;
            // 
            // rp_cusincome_panel
            // 
            rp_cusincome_panel.BackColor = System.Drawing.Color.Snow;
            rp_cusincome_panel.Controls.Add(rp_cusincome_label);
            rp_cusincome_panel.Controls.Add(rp_cusincome_ttlabel);
            rp_cusincome_panel.Location = new System.Drawing.Point(3, 3);
            rp_cusincome_panel.Name = "rp_cusincome_panel";
            rp_cusincome_panel.Size = new System.Drawing.Size(244, 135);
            rp_cusincome_panel.TabIndex = 6;
            // 
            // rp_cusincome_label
            // 
            rp_cusincome_label.BackColor = System.Drawing.Color.Transparent;
            rp_cusincome_label.Font = new System.Drawing.Font("Candara", 13.8F);
            rp_cusincome_label.ForeColor = System.Drawing.Color.Black;
            rp_cusincome_label.Location = new System.Drawing.Point(3, 56);
            rp_cusincome_label.Name = "rp_cusincome_label";
            rp_cusincome_label.Size = new System.Drawing.Size(238, 49);
            rp_cusincome_label.TabIndex = 8;
            rp_cusincome_label.Text = "report";
            rp_cusincome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rp_cusincome_ttlabel
            // 
            rp_cusincome_ttlabel.AutoSize = true;
            rp_cusincome_ttlabel.BackColor = System.Drawing.Color.Transparent;
            rp_cusincome_ttlabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            rp_cusincome_ttlabel.ForeColor = System.Drawing.Color.Black;
            rp_cusincome_ttlabel.Location = new System.Drawing.Point(37, 10);
            rp_cusincome_ttlabel.Name = "rp_cusincome_ttlabel";
            rp_cusincome_ttlabel.Size = new System.Drawing.Size(186, 24);
            rp_cusincome_ttlabel.TabIndex = 7;
            rp_cusincome_ttlabel.Text = "Income by Customer";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel4.Controls.Add(rp_dailyincome_panel);
            panel4.Location = new System.Drawing.Point(605, 355);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(250, 141);
            panel4.TabIndex = 2;
            // 
            // rp_dailyincome_panel
            // 
            rp_dailyincome_panel.BackColor = System.Drawing.Color.Snow;
            rp_dailyincome_panel.Controls.Add(rp_dailyincome_label);
            rp_dailyincome_panel.Controls.Add(rp_dailyincome_ttlabel);
            rp_dailyincome_panel.Location = new System.Drawing.Point(3, 3);
            rp_dailyincome_panel.Name = "rp_dailyincome_panel";
            rp_dailyincome_panel.Size = new System.Drawing.Size(244, 135);
            rp_dailyincome_panel.TabIndex = 6;
            // 
            // rp_dailyincome_label
            // 
            rp_dailyincome_label.BackColor = System.Drawing.Color.Transparent;
            rp_dailyincome_label.Font = new System.Drawing.Font("Candara", 13.8F);
            rp_dailyincome_label.ForeColor = System.Drawing.Color.Black;
            rp_dailyincome_label.Location = new System.Drawing.Point(3, 66);
            rp_dailyincome_label.Name = "rp_dailyincome_label";
            rp_dailyincome_label.Size = new System.Drawing.Size(238, 49);
            rp_dailyincome_label.TabIndex = 9;
            rp_dailyincome_label.Text = "report";
            rp_dailyincome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rp_dailyincome_ttlabel
            // 
            rp_dailyincome_ttlabel.AutoSize = true;
            rp_dailyincome_ttlabel.BackColor = System.Drawing.Color.Transparent;
            rp_dailyincome_ttlabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            rp_dailyincome_ttlabel.ForeColor = System.Drawing.Color.Black;
            rp_dailyincome_ttlabel.Location = new System.Drawing.Point(64, 10);
            rp_dailyincome_ttlabel.Name = "rp_dailyincome_ttlabel";
            rp_dailyincome_ttlabel.Size = new System.Drawing.Size(121, 24);
            rp_dailyincome_ttlabel.TabIndex = 8;
            rp_dailyincome_ttlabel.Text = "Daily Income";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.ForestGreen;
            panel3.Controls.Add(rp_finance_panel);
            panel3.Location = new System.Drawing.Point(219, 355);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(250, 141);
            panel3.TabIndex = 1;
            // 
            // rp_finance_panel
            // 
            rp_finance_panel.BackColor = System.Drawing.Color.Snow;
            rp_finance_panel.Controls.Add(rp_finance_label);
            rp_finance_panel.Controls.Add(rp_finance_ttlabel);
            rp_finance_panel.Location = new System.Drawing.Point(3, 3);
            rp_finance_panel.Name = "rp_finance_panel";
            rp_finance_panel.Size = new System.Drawing.Size(244, 135);
            rp_finance_panel.TabIndex = 6;
            // 
            // rp_finance_label
            // 
            rp_finance_label.BackColor = System.Drawing.Color.Transparent;
            rp_finance_label.Font = new System.Drawing.Font("Candara", 13.8F);
            rp_finance_label.ForeColor = System.Drawing.Color.Black;
            rp_finance_label.Location = new System.Drawing.Point(3, 66);
            rp_finance_label.Name = "rp_finance_label";
            rp_finance_label.Size = new System.Drawing.Size(238, 49);
            rp_finance_label.TabIndex = 8;
            rp_finance_label.Text = "report";
            rp_finance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rp_finance_ttlabel
            // 
            rp_finance_ttlabel.AutoSize = true;
            rp_finance_ttlabel.BackColor = System.Drawing.Color.Transparent;
            rp_finance_ttlabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            rp_finance_ttlabel.ForeColor = System.Drawing.Color.Black;
            rp_finance_ttlabel.Location = new System.Drawing.Point(47, 10);
            rp_finance_ttlabel.Name = "rp_finance_ttlabel";
            rp_finance_ttlabel.Size = new System.Drawing.Size(159, 24);
            rp_finance_ttlabel.TabIndex = 1;
            rp_finance_ttlabel.Text = "Bookings Finance";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Gold;
            panel2.Controls.Add(rp_customer_panel);
            panel2.Location = new System.Drawing.Point(400, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(250, 141);
            panel2.TabIndex = 1;
            // 
            // rp_customer_panel
            // 
            rp_customer_panel.BackColor = System.Drawing.Color.Snow;
            rp_customer_panel.Controls.Add(rp_customer_label);
            rp_customer_panel.Controls.Add(rp_customer_ttlabel);
            rp_customer_panel.Location = new System.Drawing.Point(3, 3);
            rp_customer_panel.Name = "rp_customer_panel";
            rp_customer_panel.Size = new System.Drawing.Size(244, 135);
            rp_customer_panel.TabIndex = 6;
            // 
            // rp_customer_label
            // 
            rp_customer_label.BackColor = System.Drawing.Color.Transparent;
            rp_customer_label.Font = new System.Drawing.Font("Candara", 13.8F);
            rp_customer_label.ForeColor = System.Drawing.Color.Black;
            rp_customer_label.Location = new System.Drawing.Point(2, 52);
            rp_customer_label.Name = "rp_customer_label";
            rp_customer_label.Size = new System.Drawing.Size(238, 49);
            rp_customer_label.TabIndex = 8;
            rp_customer_label.Text = "report";
            rp_customer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rp_customer_ttlabel
            // 
            rp_customer_ttlabel.AutoSize = true;
            rp_customer_ttlabel.BackColor = System.Drawing.Color.Transparent;
            rp_customer_ttlabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            rp_customer_ttlabel.ForeColor = System.Drawing.Color.Black;
            rp_customer_ttlabel.Location = new System.Drawing.Point(71, 9);
            rp_customer_ttlabel.Name = "rp_customer_ttlabel";
            rp_customer_ttlabel.Size = new System.Drawing.Size(101, 24);
            rp_customer_ttlabel.TabIndex = 6;
            rp_customer_ttlabel.Text = "Customers";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Red;
            panel1.Controls.Add(rp_room_panel);
            panel1.Location = new System.Drawing.Point(8, 107);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(250, 141);
            panel1.TabIndex = 0;
            // 
            // rp_room_panel
            // 
            rp_room_panel.BackColor = System.Drawing.Color.Snow;
            rp_room_panel.Controls.Add(rp_room_label);
            rp_room_panel.Controls.Add(rp_room_ttlabel);
            rp_room_panel.Location = new System.Drawing.Point(3, 3);
            rp_room_panel.Name = "rp_room_panel";
            rp_room_panel.Size = new System.Drawing.Size(244, 135);
            rp_room_panel.TabIndex = 0;
            // 
            // rp_room_label
            // 
            rp_room_label.BackColor = System.Drawing.Color.Transparent;
            rp_room_label.Font = new System.Drawing.Font("Candara", 13.8F);
            rp_room_label.ForeColor = System.Drawing.Color.Black;
            rp_room_label.Location = new System.Drawing.Point(3, 55);
            rp_room_label.Name = "rp_room_label";
            rp_room_label.Size = new System.Drawing.Size(238, 49);
            rp_room_label.TabIndex = 7;
            rp_room_label.Text = "report";
            rp_room_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rp_room_ttlabel
            // 
            rp_room_ttlabel.AutoSize = true;
            rp_room_ttlabel.BackColor = System.Drawing.Color.Transparent;
            rp_room_ttlabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            rp_room_ttlabel.ForeColor = System.Drawing.Color.Black;
            rp_room_ttlabel.Location = new System.Drawing.Point(88, 7);
            rp_room_ttlabel.Name = "rp_room_ttlabel";
            rp_room_ttlabel.Size = new System.Drawing.Size(69, 24);
            rp_room_ttlabel.TabIndex = 6;
            rp_room_ttlabel.Text = "Rooms";
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
            // background_panel
            // 
            background_panel.BackColor = System.Drawing.Color.Snow;
            background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            background_panel.Controls.Add(report_panel);
            background_panel.Controls.Add(logo_icon);
            background_panel.Controls.Add(title_label);
            background_panel.Controls.Add(logout_panel);
            background_panel.Controls.Add(main_panel);
            background_panel.Controls.Add(room_panel);
            background_panel.Controls.Add(category_panel);
            background_panel.Location = new System.Drawing.Point(12, 12);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1176, 576);
            background_panel.TabIndex = 2;
            // 
            // ManagerReportForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1200, 600);
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ManagerReportForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ManagerReportForm";
            category_panel.ResumeLayout(false);
            category_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)category_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)room_icon).EndInit();
            room_panel.ResumeLayout(false);
            room_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)report_icon).EndInit();
            report_panel.ResumeLayout(false);
            report_panel.PerformLayout();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            panel5.ResumeLayout(false);
            rp_cusincome_panel.ResumeLayout(false);
            rp_cusincome_panel.PerformLayout();
            panel4.ResumeLayout(false);
            rp_dailyincome_panel.ResumeLayout(false);
            rp_dailyincome_panel.PerformLayout();
            panel3.ResumeLayout(false);
            rp_finance_panel.ResumeLayout(false);
            rp_finance_panel.PerformLayout();
            panel2.ResumeLayout(false);
            rp_customer_panel.ResumeLayout(false);
            rp_customer_panel.PerformLayout();
            panel1.ResumeLayout(false);
            rp_room_panel.ResumeLayout(false);
            rp_room_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            background_panel.ResumeLayout(false);
            background_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.PictureBox category_icon;
        private System.Windows.Forms.PictureBox room_icon;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Panel room_panel;
        private System.Windows.Forms.PictureBox report_icon;
        private System.Windows.Forms.Label report_label;
        private System.Windows.Forms.Panel report_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox logout_icon;
        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox rp_customer_cbbox;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel rp_cusincome_panel;
        private System.Windows.Forms.Panel rp_dailyincome_panel;
        private System.Windows.Forms.Panel rp_finance_panel;
        private System.Windows.Forms.Panel rp_customer_panel;
        private System.Windows.Forms.Panel rp_room_panel;
        private System.Windows.Forms.Label rp_cusincome_ttlabel;
        private System.Windows.Forms.Label rp_dailyincome_ttlabel;
        private System.Windows.Forms.Label rp_finance_ttlabel;
        private System.Windows.Forms.Label rp_customer_ttlabel;
        private System.Windows.Forms.Label rp_room_ttlabel;
        private System.Windows.Forms.Label rp_cusincome_label;
        private System.Windows.Forms.Label rp_dailyincome_label;
        private System.Windows.Forms.Label rp_finance_label;
        private System.Windows.Forms.Label rp_customer_label;
        private System.Windows.Forms.Label rp_room_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label customer_label;
    }
}