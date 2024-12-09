namespace DASA_FinalProject_01
{
    partial class Exercise02Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise02Form));
            panelBackground = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panelex2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            input_groupBox = new System.Windows.Forms.GroupBox();
            btnDel = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            txtId = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            taskname_lb = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnClear = new System.Windows.Forms.Button();
            btnDone = new System.Windows.Forms.Button();
            todo_lb = new System.Windows.Forms.Label();
            lstTask = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.PictureBox();
            btnReturn = new System.Windows.Forms.Button();
            panelBackground.SuspendLayout();
            panelex2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            input_groupBox.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.BackColor = System.Drawing.Color.Snow;
            panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelBackground.Controls.Add(btnReturn);
            panelBackground.Controls.Add(label1);
            panelBackground.Controls.Add(panelex2);
            panelBackground.Controls.Add(label4);
            panelBackground.Controls.Add(label3);
            panelBackground.Controls.Add(label2);
            panelBackground.Controls.Add(btnExit);
            panelBackground.Location = new System.Drawing.Point(12, 15);
            panelBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new System.Drawing.Size(1043, 572);
            panelBackground.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(424, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(203, 35);
            label1.TabIndex = 2;
            label1.Text = "FINAL PROJECT";
            // 
            // panelex2
            // 
            panelex2.BackColor = System.Drawing.Color.PowderBlue;
            panelex2.Controls.Add(panel3);
            panelex2.Controls.Add(label9);
            panelex2.Controls.Add(label8);
            panelex2.Controls.Add(label10);
            panelex2.Controls.Add(panel1);
            panelex2.Controls.Add(panel2);
            panelex2.Location = new System.Drawing.Point(-1, 39);
            panelex2.Name = "panelex2";
            panelex2.Size = new System.Drawing.Size(1041, 503);
            panelex2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new System.Drawing.Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(380, 96);
            panel3.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(106, 45);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(263, 42);
            label14.TabIndex = 29;
            label14.Text = "removes the first task from the list \r\nas it is considered completed.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label13.Location = new System.Drawing.Point(4, 45);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(107, 21);
            label13.TabIndex = 28;
            label13.Text = "Done Button:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(115, 24);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(136, 21);
            label12.TabIndex = 27;
            label12.Text = "deletes any tasks.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label11.Location = new System.Drawing.Point(126, 38);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(0, 21);
            label11.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(4, 24);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 21);
            label5.TabIndex = 25;
            label5.Text = "Delete Button:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(98, 23);
            label6.TabIndex = 8;
            label6.Text = "Instruction";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(-1, 458);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(208, 21);
            label9.TabIndex = 8;
            label9.Text = "23110052 - Bui Tran Tan Phat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(0, 479);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(213, 21);
            label8.TabIndex = 7;
            label8.Text = "23110053 - Nguyen Nhat Phat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold);
            label10.Location = new System.Drawing.Point(0, 437);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 21);
            label10.TabIndex = 9;
            label10.Text = "Team 03";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            panel1.Controls.Add(input_groupBox);
            panel1.Location = new System.Drawing.Point(49, 139);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(389, 199);
            panel1.TabIndex = 18;
            // 
            // input_groupBox
            // 
            input_groupBox.BackColor = System.Drawing.Color.Honeydew;
            input_groupBox.Controls.Add(btnDel);
            input_groupBox.Controls.Add(btnEdit);
            input_groupBox.Controls.Add(txtId);
            input_groupBox.Controls.Add(btnAdd);
            input_groupBox.Controls.Add(txtName);
            input_groupBox.Controls.Add(label7);
            input_groupBox.Controls.Add(taskname_lb);
            input_groupBox.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            input_groupBox.Location = new System.Drawing.Point(13, 16);
            input_groupBox.Name = "input_groupBox";
            input_groupBox.Size = new System.Drawing.Size(363, 167);
            input_groupBox.TabIndex = 19;
            input_groupBox.TabStop = false;
            input_groupBox.Text = "Input daily tasks";
            // 
            // btnDel
            // 
            btnDel.BackColor = System.Drawing.Color.DarkSlateGray;
            btnDel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDel.ForeColor = System.Drawing.Color.Snow;
            btnDel.Location = new System.Drawing.Point(258, 117);
            btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new System.Drawing.Size(80, 34);
            btnDel.TabIndex = 26;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEdit.ForeColor = System.Drawing.Color.Snow;
            btnEdit.Location = new System.Drawing.Point(136, 117);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(80, 34);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtId
            // 
            txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtId.Enabled = false;
            txtId.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtId.Location = new System.Drawing.Point(54, 29);
            txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "1";
            txtId.Size = new System.Drawing.Size(62, 32);
            txtId.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            btnAdd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.Snow;
            btnAdd.Location = new System.Drawing.Point(14, 117);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(80, 34);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtName.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtName.Location = new System.Drawing.Point(64, 69);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Task to do (<=20 digits)";
            txtName.Size = new System.Drawing.Size(212, 29);
            txtName.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(18, 34);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 21);
            label7.TabIndex = 17;
            label7.Text = "ID:";
            // 
            // taskname_lb
            // 
            taskname_lb.AutoSize = true;
            taskname_lb.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            taskname_lb.Location = new System.Drawing.Point(14, 73);
            taskname_lb.Name = "taskname_lb";
            taskname_lb.Size = new System.Drawing.Size(46, 21);
            taskname_lb.TabIndex = 16;
            taskname_lb.Text = "Task:";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDone);
            panel2.Controls.Add(todo_lb);
            panel2.Controls.Add(lstTask);
            panel2.Location = new System.Drawing.Point(517, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(484, 496);
            panel2.TabIndex = 24;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.DarkSlateGray;
            btnClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.ForeColor = System.Drawing.Color.Snow;
            btnClear.Location = new System.Drawing.Point(311, 447);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(105, 45);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear list";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDone
            // 
            btnDone.BackColor = System.Drawing.Color.DarkSlateGray;
            btnDone.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDone.ForeColor = System.Drawing.Color.Snow;
            btnDone.Location = new System.Drawing.Point(88, 447);
            btnDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDone.Name = "btnDone";
            btnDone.Size = new System.Drawing.Size(105, 45);
            btnDone.TabIndex = 23;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // todo_lb
            // 
            todo_lb.AutoSize = true;
            todo_lb.BackColor = System.Drawing.Color.MediumAquamarine;
            todo_lb.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold);
            todo_lb.Location = new System.Drawing.Point(183, 2);
            todo_lb.Name = "todo_lb";
            todo_lb.Size = new System.Drawing.Size(116, 31);
            todo_lb.TabIndex = 24;
            todo_lb.Text = "To-do List";
            // 
            // lstTask
            // 
            lstTask.BackColor = System.Drawing.Color.Honeydew;
            lstTask.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lstTask.FormattingEnabled = true;
            lstTask.ItemHeight = 24;
            lstTask.Location = new System.Drawing.Point(19, 32);
            lstTask.Name = "lstTask";
            lstTask.Size = new System.Drawing.Size(452, 412);
            lstTask.TabIndex = 23;
            lstTask.SelectedIndexChanged += lstTask_SelectedIndexChanged;
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
            label3.Location = new System.Drawing.Point(45, 8);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 24);
            label3.TabIndex = 5;
            label3.Text = "Exercise 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(952, 545);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 24);
            label2.TabIndex = 3;
            label2.Text = "TEAM 03";
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnExit.Image = (System.Drawing.Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new System.Drawing.Point(996, -2);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(44, 41);
            btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 4;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = System.Drawing.Color.OrangeRed;
            btnReturn.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold);
            btnReturn.ForeColor = System.Drawing.Color.Snow;
            btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            btnReturn.Location = new System.Drawing.Point(5, 5);
            btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new System.Drawing.Size(37, 29);
            btnReturn.TabIndex = 27;
            btnReturn.Text = "<<";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // Exercise02Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1067, 600);
            Controls.Add(panelBackground);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Exercise02Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Excercise02Form";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            panelex2.ResumeLayout(false);
            panelex2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            input_groupBox.ResumeLayout(false);
            input_groupBox.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel panelex2;
        private System.Windows.Forms.GroupBox input_groupBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label taskname_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstTask;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label todo_lb;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReturn;
    }
}