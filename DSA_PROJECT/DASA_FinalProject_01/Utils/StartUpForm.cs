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
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
            cbboxExercise.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btnExit.MouseEnter += btnExit_MouseEnter;
            this.btnExit.MouseLeave += btnExit_MouseLeave;
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Hand;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Default;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbboxExercise.SelectedItem?.ToString()))
            {
                OurMessageBox.Show("You have not selected an exercise yet! :<");
                return;
            }
            string exercise = cbboxExercise.SelectedItem.ToString();
            
            switch (exercise)
            {
                case "Exercise01":
                    Excercise01Form ex1 = new Excercise01Form();
                    ex1.Show();
                    this.Hide();
                    break;
                case "Exercise02":
                    Exercise02Form ex2 = new Exercise02Form();
                    ex2.Show();
                    this.Hide();
                    break;
                case "Exercise03":
                    Exercise03Form ex3 = new Exercise03Form();
                    ex3.Show();
                    this.Hide();
                    break;
                default:
                    OurMessageBox.Show("Invalid exercise selected");
                    break;
            }
        }
    }
}
