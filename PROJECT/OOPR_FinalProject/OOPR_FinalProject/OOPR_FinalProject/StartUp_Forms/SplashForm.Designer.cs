namespace OOPR_FinalProject
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            panel1 = new System.Windows.Forms.Panel();
            percentage_label = new System.Windows.Forms.Label();
            credit_label = new System.Windows.Forms.Label();
            title_label = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Ivory;
            panel1.Controls.Add(percentage_label);
            panel1.Controls.Add(credit_label);
            panel1.Controls.Add(title_label);
            panel1.Controls.Add(progressBar);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(618, 324);
            panel1.TabIndex = 0;
            // 
            // percentage_label
            // 
            percentage_label.AutoSize = true;
            percentage_label.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            percentage_label.Location = new System.Drawing.Point(283, 169);
            percentage_label.Name = "percentage_label";
            percentage_label.Size = new System.Drawing.Size(63, 49);
            percentage_label.TabIndex = 3;
            percentage_label.Text = "0%";
            // 
            // credit_label
            // 
            credit_label.AutoSize = true;
            credit_label.Font = new System.Drawing.Font("Candara", 18F);
            credit_label.Location = new System.Drawing.Point(115, 91);
            credit_label.Name = "credit_label";
            credit_label.Size = new System.Drawing.Size(389, 37);
            credit_label.TabIndex = 2;
            credit_label.Text = "Developed by Team03_OOPR";
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new System.Drawing.Font("Candara", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            title_label.Location = new System.Drawing.Point(49, 37);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(539, 54);
            title_label.TabIndex = 1;
            title_label.Text = "Hotel Management System";
            // 
            // progressBar
            // 
            progressBar.ForeColor = System.Drawing.Color.Red;
            progressBar.Location = new System.Drawing.Point(49, 221);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(539, 44);
            progressBar.TabIndex = 0;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(649, 353);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SplashForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "splash";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label credit_label;
        private System.Windows.Forms.Label percentage_label;
    }
}