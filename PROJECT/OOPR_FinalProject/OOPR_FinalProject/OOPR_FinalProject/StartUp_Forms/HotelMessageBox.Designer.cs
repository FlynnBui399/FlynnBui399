namespace OOPR_FinalProject.StartUp_Forms
{
    partial class HotelMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelMessageBox));
            panel1 = new System.Windows.Forms.Panel();
            message_label = new System.Windows.Forms.Label();
            title_label = new System.Windows.Forms.Label();
            logo_icon = new System.Windows.Forms.PictureBox();
            close_btn = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Beige;
            panel1.Controls.Add(message_label);
            panel1.Location = new System.Drawing.Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(426, 206);
            panel1.TabIndex = 0;
            // 
            // message_label
            // 
            message_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            message_label.ForeColor = System.Drawing.Color.Black;
            message_label.Location = new System.Drawing.Point(12, 9);
            message_label.MaximumSize = new System.Drawing.Size(414, 200);
            message_label.Name = "message_label";
            message_label.Size = new System.Drawing.Size(404, 191);
            message_label.TabIndex = 2;
            message_label.Text = "This is Message";
            message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            title_label.ForeColor = System.Drawing.Color.Black;
            title_label.Location = new System.Drawing.Point(40, 5);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(114, 24);
            title_label.TabIndex = 1;
            title_label.Text = "Information";
            // 
            // logo_icon
            // 
            logo_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            logo_icon.Image = (System.Drawing.Image)resources.GetObject("logo_icon.Image");
            logo_icon.Location = new System.Drawing.Point(14, 5);
            logo_icon.Name = "logo_icon";
            logo_icon.Size = new System.Drawing.Size(20, 24);
            logo_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo_icon.TabIndex = 24;
            logo_icon.TabStop = false;
            // 
            // close_btn
            // 
            close_btn.Image = (System.Drawing.Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new System.Drawing.Point(421, 2);
            close_btn.Name = "close_btn";
            close_btn.Size = new System.Drawing.Size(27, 27);
            close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // HotelMessageBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSeaGreen;
            ClientSize = new System.Drawing.Size(450, 250);
            Controls.Add(close_btn);
            Controls.Add(logo_icon);
            Controls.Add(title_label);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HotelMessageBox";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Information";
            TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.PictureBox close_btn;
    }
}