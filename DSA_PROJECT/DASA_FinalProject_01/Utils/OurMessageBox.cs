using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASA_FinalProject_01.Utils
{
    public partial class OurMessageBox : Form
    {
        public OurMessageBox()
        {
            InitializeComponent();
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void Show(string message)
        {
            using (OurMessageBox box = new OurMessageBox())
            {
                box.message_label.Text = message;
                box.message_label.Font = new Font("Candara", 12, FontStyle.Regular);
                box.ShowDialog();
            }
        }
        public static void Show(string message, string title)
        {
            using (OurMessageBox box = new OurMessageBox())
            {
                box.message_label.Text = message;
                box.message_label.Font = new Font("Candara", 12, FontStyle.Regular);
                box.title_label.Text = title;
                box.title_label.Font = new Font("Candara", 12, FontStyle.Regular);
                box.ShowDialog();
            }
        }
    }
}
