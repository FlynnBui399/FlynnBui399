namespace DASA_FinalProject_01
{
    partial class Exercise03Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise03Form));
            panelBackground = new System.Windows.Forms.Panel();
            btnExit = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            btnClear = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnReset = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            txtTwoChildNodeCount = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            txtOneChildNodeCount = new System.Windows.Forms.TextBox();
            txtLeafCount = new System.Windows.Forms.TextBox();
            txtNCout = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            txtDepth = new System.Windows.Forms.TextBox();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            input_groupBox = new System.Windows.Forms.GroupBox();
            btnDel = new System.Windows.Forms.Button();
            txtValue = new System.Windows.Forms.TextBox();
            btnInsert = new System.Windows.Forms.Button();
            ID_label = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            drawingBox = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnReturn = new System.Windows.Forms.Button();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            panelMain.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            input_groupBox.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drawingBox).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.BackColor = System.Drawing.Color.Snow;
            panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelBackground.Controls.Add(btnReturn);
            panelBackground.Controls.Add(btnExit);
            panelBackground.Controls.Add(label4);
            panelBackground.Controls.Add(label3);
            panelBackground.Controls.Add(panelMain);
            panelBackground.Controls.Add(label1);
            panelBackground.Controls.Add(label2);
            panelBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            panelBackground.Location = new System.Drawing.Point(12, 12);
            panelBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new System.Drawing.Size(1039, 572);
            panelBackground.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.Image = (System.Drawing.Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new System.Drawing.Point(1000, -2);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(35, 32);
            btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 6;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(5, 547);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(234, 21);
            label4.TabIndex = 5;
            label4.Text = "Data Structures and Algorithms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(48, 4);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 24);
            label3.TabIndex = 5;
            label3.Text = "Exercise 3";
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.Ivory;
            panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMain.Controls.Add(btnClear);
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(label9);
            panelMain.Controls.Add(label8);
            panelMain.Controls.Add(label10);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(panel2);
            panelMain.Location = new System.Drawing.Point(-2, 32);
            panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1039, 511);
            panelMain.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.Teal;
            btnClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.ForeColor = System.Drawing.Color.Transparent;
            btnClear.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnClear.Location = new System.Drawing.Point(638, 465);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(143, 41);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear Tree";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Teal;
            panel4.Controls.Add(groupBox1);
            panel4.Location = new System.Drawing.Point(40, 191);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(355, 247);
            panel4.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Ivory;
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtTwoChildNodeCount);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtOneChildNodeCount);
            groupBox1.Controls.Add(txtLeafCount);
            groupBox1.Controls.Add(txtNCout);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtDepth);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label11);
            groupBox1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(333, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // btnReset
            // 
            btnReset.BackColor = System.Drawing.Color.Teal;
            btnReset.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            btnReset.ForeColor = System.Drawing.Color.Snow;
            btnReset.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnReset.Location = new System.Drawing.Point(169, 175);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(79, 39);
            btnReset.TabIndex = 41;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            label12.Location = new System.Drawing.Point(66, 150);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(95, 21);
            label12.TabIndex = 40;
            label12.Text = "Input value:";
            // 
            // txtTwoChildNodeCount
            // 
            txtTwoChildNodeCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtTwoChildNodeCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTwoChildNodeCount.Enabled = false;
            txtTwoChildNodeCount.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtTwoChildNodeCount.Location = new System.Drawing.Point(212, 97);
            txtTwoChildNodeCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTwoChildNodeCount.Name = "txtTwoChildNodeCount";
            txtTwoChildNodeCount.Size = new System.Drawing.Size(44, 28);
            txtTwoChildNodeCount.TabIndex = 39;
            txtTwoChildNodeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            label16.Location = new System.Drawing.Point(180, 75);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(107, 18);
            label16.TabIndex = 38;
            label16.Text = "Two Child Node";
            // 
            // txtOneChildNodeCount
            // 
            txtOneChildNodeCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtOneChildNodeCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOneChildNodeCount.Enabled = false;
            txtOneChildNodeCount.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtOneChildNodeCount.Location = new System.Drawing.Point(55, 97);
            txtOneChildNodeCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOneChildNodeCount.Name = "txtOneChildNodeCount";
            txtOneChildNodeCount.Size = new System.Drawing.Size(44, 28);
            txtOneChildNodeCount.TabIndex = 37;
            txtOneChildNodeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeafCount
            // 
            txtLeafCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtLeafCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtLeafCount.Enabled = false;
            txtLeafCount.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtLeafCount.Location = new System.Drawing.Point(279, 26);
            txtLeafCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLeafCount.Name = "txtLeafCount";
            txtLeafCount.Size = new System.Drawing.Size(44, 28);
            txtLeafCount.TabIndex = 35;
            txtLeafCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNCout
            // 
            txtNCout.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtNCout.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNCout.Enabled = false;
            txtNCout.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtNCout.Location = new System.Drawing.Point(167, 27);
            txtNCout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNCout.Name = "txtNCout";
            txtNCout.Size = new System.Drawing.Size(44, 28);
            txtNCout.TabIndex = 34;
            txtNCout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            label15.Location = new System.Drawing.Point(24, 75);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(106, 18);
            label15.TabIndex = 33;
            label15.Text = "One Child Node";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            label14.Location = new System.Drawing.Point(111, 31);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(52, 18);
            label14.TabIndex = 32;
            label14.Text = "Nodes:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            label13.Location = new System.Drawing.Point(223, 31);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(55, 18);
            label13.TabIndex = 31;
            label13.Text = "Leaves:";
            // 
            // txtDepth
            // 
            txtDepth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtDepth.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDepth.Enabled = false;
            txtDepth.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtDepth.Location = new System.Drawing.Point(58, 25);
            txtDepth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDepth.Name = "txtDepth";
            txtDepth.Size = new System.Drawing.Size(44, 28);
            txtDepth.TabIndex = 29;
            txtDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSearch.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearch.Location = new System.Drawing.Point(167, 146);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "value";
            txtSearch.Size = new System.Drawing.Size(65, 29);
            txtSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.Teal;
            btnSearch.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.Snow;
            btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnSearch.Location = new System.Drawing.Point(79, 175);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(79, 39);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            label11.Location = new System.Drawing.Point(6, 29);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(51, 18);
            label11.TabIndex = 26;
            label11.Text = "Depth:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(2, 462);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(208, 21);
            label9.TabIndex = 28;
            label9.Text = "23110052 - Bui Tran Tan Phat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(3, 483);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(213, 21);
            label8.TabIndex = 27;
            label8.Text = "23110053 - Nguyen Nhat Phat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label10.Location = new System.Drawing.Point(3, 441);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 21);
            label10.TabIndex = 29;
            label10.Text = "Team 03";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Teal;
            panel1.Controls.Add(input_groupBox);
            panel1.Location = new System.Drawing.Point(60, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(303, 136);
            panel1.TabIndex = 19;
            // 
            // input_groupBox
            // 
            input_groupBox.BackColor = System.Drawing.Color.Ivory;
            input_groupBox.Controls.Add(btnDel);
            input_groupBox.Controls.Add(txtValue);
            input_groupBox.Controls.Add(btnInsert);
            input_groupBox.Controls.Add(ID_label);
            input_groupBox.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            input_groupBox.Location = new System.Drawing.Point(10, 10);
            input_groupBox.Name = "input_groupBox";
            input_groupBox.Size = new System.Drawing.Size(279, 114);
            input_groupBox.TabIndex = 19;
            input_groupBox.TabStop = false;
            input_groupBox.Text = "Input Value";
            // 
            // btnDel
            // 
            btnDel.BackColor = System.Drawing.Color.Teal;
            btnDel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDel.ForeColor = System.Drawing.Color.Snow;
            btnDel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnDel.Location = new System.Drawing.Point(162, 68);
            btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new System.Drawing.Size(76, 32);
            btnDel.TabIndex = 25;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // txtValue
            // 
            txtValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtValue.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtValue.Location = new System.Drawing.Point(163, 26);
            txtValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtValue.Name = "txtValue";
            txtValue.Size = new System.Drawing.Size(84, 29);
            txtValue.TabIndex = 11;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = System.Drawing.Color.Teal;
            btnInsert.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnInsert.ForeColor = System.Drawing.Color.Snow;
            btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnInsert.Location = new System.Drawing.Point(38, 68);
            btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(76, 32);
            btnInsert.TabIndex = 24;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ID_label.Location = new System.Drawing.Point(13, 27);
            ID_label.Name = "ID_label";
            ID_label.Size = new System.Drawing.Size(144, 24);
            ID_label.TabIndex = 15;
            ID_label.Text = "Enter the value:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(401, 34);
            panel3.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(230, 4);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(163, 24);
            label7.TabIndex = 26;
            label7.Text = "Inorder Traversal.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Candara", 12F);
            label6.Location = new System.Drawing.Point(58, 4);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(177, 24);
            label6.TabIndex = 30;
            label6.Text = "this exercise is using";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(8, 4);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 24);
            label5.TabIndex = 26;
            label5.Text = "Note:";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Teal;
            panel2.Controls.Add(drawingBox);
            panel2.Location = new System.Drawing.Point(406, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(629, 457);
            panel2.TabIndex = 20;
            // 
            // drawingBox
            // 
            drawingBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            drawingBox.BackColor = System.Drawing.Color.WhiteSmoke;
            drawingBox.Location = new System.Drawing.Point(2, 2);
            drawingBox.Name = "drawingBox";
            drawingBox.Size = new System.Drawing.Size(623, 452);
            drawingBox.TabIndex = 26;
            drawingBox.TabStop = false;
            drawingBox.Paint += drawingBox_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(433, -1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(203, 35);
            label1.TabIndex = 2;
            label1.Text = "FINAL PROJECT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(933, 545);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 24);
            label2.TabIndex = 3;
            label2.Text = "TEAM 03";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = System.Drawing.Color.OrangeRed;
            btnReturn.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold);
            btnReturn.ForeColor = System.Drawing.Color.Snow;
            btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnReturn.Location = new System.Drawing.Point(5, 2);
            btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new System.Drawing.Size(37, 29);
            btnReturn.TabIndex = 28;
            btnReturn.Text = "<<";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // Exercise03Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1063, 597);
            Controls.Add(panelBackground);
            ForeColor = System.Drawing.Color.Coral;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Exercise03Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Exercise03";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            input_groupBox.ResumeLayout(false);
            input_groupBox.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drawingBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox input_groupBox;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOneChildNodeCount;
        private System.Windows.Forms.TextBox txtLeafCount;
        private System.Windows.Forms.TextBox txtNCout;
        private System.Windows.Forms.TextBox txtTwoChildNodeCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturn;
    }
}