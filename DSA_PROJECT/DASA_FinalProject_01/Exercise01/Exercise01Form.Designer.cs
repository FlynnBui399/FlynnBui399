namespace DASA_FinalProject_01
{
    partial class Excercise01Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excercise01Form));
            panelBackground = new System.Windows.Forms.Panel();
            btnReturn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            cmbSortOrder = new System.Windows.Forms.ComboBox();
            btnSort = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            txtIDToRemove = new System.Windows.Forms.TextBox();
            btnRemoveAll = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            input_groupBox = new System.Windows.Forms.GroupBox();
            txtName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtPosition = new System.Windows.Forms.TextBox();
            ID_label = new System.Windows.Forms.Label();
            lstEmployees = new System.Windows.Forms.ListBox();
            btnSearch = new System.Windows.Forms.Button();
            btnRemoveFirst = new System.Windows.Forms.Button();
            btnRemoveLast = new System.Windows.Forms.Button();
            btnPrint = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.PictureBox();
            panelBackground.SuspendLayout();
            panelMain.SuspendLayout();
            groupBox1.SuspendLayout();
            input_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.BackColor = System.Drawing.Color.Snow;
            panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelBackground.Controls.Add(btnReturn);
            panelBackground.Controls.Add(label4);
            panelBackground.Controls.Add(label3);
            panelBackground.Controls.Add(panelMain);
            panelBackground.Controls.Add(label1);
            panelBackground.Controls.Add(label2);
            panelBackground.Controls.Add(btnExit);
            panelBackground.Location = new System.Drawing.Point(12, 15);
            panelBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new System.Drawing.Size(1039, 572);
            panelBackground.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = System.Drawing.Color.OrangeRed;
            btnReturn.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold);
            btnReturn.ForeColor = System.Drawing.Color.Snow;
            btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnReturn.Location = new System.Drawing.Point(3, 0);
            btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new System.Drawing.Size(37, 29);
            btnReturn.TabIndex = 26;
            btnReturn.Text = "<<";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
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
            label3.Location = new System.Drawing.Point(44, 4);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 24);
            label3.TabIndex = 5;
            label3.Text = "Exercise 1";
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.Ivory;
            panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMain.Controls.Add(label10);
            panelMain.Controls.Add(cmbSortOrder);
            panelMain.Controls.Add(btnSort);
            panelMain.Controls.Add(label9);
            panelMain.Controls.Add(txtIDToRemove);
            panelMain.Controls.Add(btnRemoveAll);
            panelMain.Controls.Add(groupBox1);
            panelMain.Controls.Add(input_groupBox);
            panelMain.Controls.Add(lstEmployees);
            panelMain.Controls.Add(btnSearch);
            panelMain.Controls.Add(btnRemoveFirst);
            panelMain.Controls.Add(btnRemoveLast);
            panelMain.Controls.Add(btnPrint);
            panelMain.Controls.Add(btnAdd);
            panelMain.Location = new System.Drawing.Point(-2, 32);
            panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1039, 511);
            panelMain.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(518, 140);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(43, 15);
            label10.TabIndex = 25;
            label10.Text = "Order:";
            // 
            // cmbSortOrder
            // 
            cmbSortOrder.FormattingEnabled = true;
            cmbSortOrder.Location = new System.Drawing.Point(518, 158);
            cmbSortOrder.Name = "cmbSortOrder";
            cmbSortOrder.Size = new System.Drawing.Size(111, 28);
            cmbSortOrder.TabIndex = 24;
            // 
            // btnSort
            // 
            btnSort.BackColor = System.Drawing.Color.Teal;
            btnSort.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSort.ForeColor = System.Drawing.Color.Snow;
            btnSort.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnSort.Location = new System.Drawing.Point(387, 143);
            btnSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(116, 57);
            btnSort.TabIndex = 23;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(518, 55);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 15);
            label9.TabIndex = 22;
            label9.Text = "ID To Remove:";
            // 
            // txtIDToRemove
            // 
            txtIDToRemove.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtIDToRemove.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtIDToRemove.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtIDToRemove.Location = new System.Drawing.Point(518, 74);
            txtIDToRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtIDToRemove.Name = "txtIDToRemove";
            txtIDToRemove.PlaceholderText = "ID To Remove";
            txtIDToRemove.Size = new System.Drawing.Size(111, 29);
            txtIDToRemove.TabIndex = 21;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.BackColor = System.Drawing.Color.Teal;
            btnRemoveAll.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemoveAll.ForeColor = System.Drawing.Color.Snow;
            btnRemoveAll.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnRemoveAll.Location = new System.Drawing.Point(387, 54);
            btnRemoveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new System.Drawing.Size(116, 57);
            btnRemoveAll.TabIndex = 20;
            btnRemoveAll.Text = "Remove";
            btnRemoveAll.UseVisualStyleBackColor = false;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            groupBox1.Location = new System.Drawing.Point(14, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(224, 72);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Team 03";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(6, 48);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(213, 21);
            label8.TabIndex = 7;
            label8.Text = "23110053 - Nguyen Nhat Phat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(6, 22);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(207, 21);
            label5.TabIndex = 6;
            label5.Text = "23110052 - Bui Tran Tan Phat";
            // 
            // input_groupBox
            // 
            input_groupBox.Controls.Add(txtName);
            input_groupBox.Controls.Add(label7);
            input_groupBox.Controls.Add(txtID);
            input_groupBox.Controls.Add(label6);
            input_groupBox.Controls.Add(txtPosition);
            input_groupBox.Controls.Add(ID_label);
            input_groupBox.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            input_groupBox.Location = new System.Drawing.Point(16, 48);
            input_groupBox.Name = "input_groupBox";
            input_groupBox.Size = new System.Drawing.Size(365, 235);
            input_groupBox.TabIndex = 18;
            input_groupBox.TabStop = false;
            input_groupBox.Text = "Input the Employee info";
            // 
            // txtName
            // 
            txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtName.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtName.Location = new System.Drawing.Point(122, 110);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Employee Name";
            txtName.Size = new System.Drawing.Size(212, 29);
            txtName.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(13, 189);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(84, 24);
            label7.TabIndex = 17;
            label7.Text = "Position:";
            // 
            // txtID
            // 
            txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtID.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtID.Location = new System.Drawing.Point(122, 43);
            txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Employee ID";
            txtID.Size = new System.Drawing.Size(212, 29);
            txtID.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(13, 112);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 24);
            label6.TabIndex = 16;
            label6.Text = "Name:";
            // 
            // txtPosition
            // 
            txtPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPosition.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPosition.Location = new System.Drawing.Point(122, 187);
            txtPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.PlaceholderText = "Employee Position";
            txtPosition.Size = new System.Drawing.Size(212, 29);
            txtPosition.TabIndex = 12;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ID_label.Location = new System.Drawing.Point(13, 45);
            ID_label.Name = "ID_label";
            ID_label.Size = new System.Drawing.Size(34, 24);
            ID_label.TabIndex = 15;
            ID_label.Text = "ID:";
            // 
            // lstEmployees
            // 
            lstEmployees.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 24;
            lstEmployees.Location = new System.Drawing.Point(643, 49);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new System.Drawing.Size(377, 436);
            lstEmployees.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            btnSearch.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSearch.ForeColor = System.Drawing.Color.Snow;
            btnSearch.Location = new System.Drawing.Point(197, 290);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(184, 42);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search Employee";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRemoveFirst
            // 
            btnRemoveFirst.BackColor = System.Drawing.Color.DarkSlateGray;
            btnRemoveFirst.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemoveFirst.ForeColor = System.Drawing.Color.Snow;
            btnRemoveFirst.Location = new System.Drawing.Point(16, 340);
            btnRemoveFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRemoveFirst.Name = "btnRemoveFirst";
            btnRemoveFirst.Size = new System.Drawing.Size(154, 42);
            btnRemoveFirst.TabIndex = 9;
            btnRemoveFirst.Text = "Remove First Employee";
            btnRemoveFirst.UseVisualStyleBackColor = false;
            btnRemoveFirst.Click += btnRemoveFirst_Click;
            // 
            // btnRemoveLast
            // 
            btnRemoveLast.BackColor = System.Drawing.Color.DarkSlateGray;
            btnRemoveLast.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemoveLast.ForeColor = System.Drawing.Color.Snow;
            btnRemoveLast.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnRemoveLast.Location = new System.Drawing.Point(197, 340);
            btnRemoveLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRemoveLast.Name = "btnRemoveLast";
            btnRemoveLast.Size = new System.Drawing.Size(184, 42);
            btnRemoveLast.TabIndex = 8;
            btnRemoveLast.Text = "Remove Last Employee";
            btnRemoveLast.UseVisualStyleBackColor = false;
            btnRemoveLast.Click += btnRemoveLast_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = System.Drawing.Color.DarkCyan;
            btnPrint.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPrint.ForeColor = System.Drawing.Color.Snow;
            btnPrint.Location = new System.Drawing.Point(734, 4);
            btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(194, 42);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print Employees";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            btnAdd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.Snow;
            btnAdd.Location = new System.Drawing.Point(16, 290);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(154, 42);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.Image = (System.Drawing.Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new System.Drawing.Point(992, -5);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(40, 40);
            btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 4;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // Excercise01Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1063, 600);
            Controls.Add(panelBackground);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Excercise01Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Excercise01Form";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            input_groupBox.ResumeLayout(false);
            input_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox input_groupBox;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDToRemove;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cmbSortOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReturn;
    }
}

