using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DASA_FinalProject_01.Utils;

namespace DASA_FinalProject_01
{
    public partial class Excercise01Form : Form
    {
        private CircularLinkedList employeeList;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Excercise01Form()
        {
            InitializeComponent();
            cmbSortOrder.Items.Add("Ascending");
            cmbSortOrder.Items.Add("Descending");
            cmbSortOrder.SelectedIndex = 0;
            employeeList = new CircularLinkedList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id) && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                Employee employee = new Employee(id, txtName.Text, txtPosition.Text);
                employeeList.InsertAtEnd(employee);
                txtID.Clear();
                txtName.Clear();
                txtPosition.Clear();
                employeeList.PrintList(lstEmployees);
            }
            else
            {
                OurMessageBox.Show("Please enter valid employee details");
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            employeeList.RemoveFirst();
            employeeList.PrintList(lstEmployees);
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            employeeList.RemoveLast();
            employeeList.PrintList(lstEmployees);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            employeeList.PrintList(lstEmployees);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                Node foundNode = employeeList.Search(id);
                if (foundNode != null)
                {
                    OurMessageBox.Show($"Employee found: {foundNode.Data}");
                }
                else
                {
                    OurMessageBox.Show($"Employee with ID {id} not found");
                }
            }
            else
            {
                OurMessageBox.Show("Please enter a valid employee ID");
            }
        }
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                int IDToRemove = int.Parse(txtIDToRemove.Text);
                employeeList.RemoveAllByID(IDToRemove);
                employeeList.PrintList(lstEmployees);
            }
            catch (Exception ex)
            {
                OurMessageBox.Show(ex.Message);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string sortOrder = cmbSortOrder.SelectedItem.ToString();


            if (sortOrder == "Ascending")
            {
                employeeList.SelectionSort01();
            }
            else if (sortOrder == "Descending")
            {
                employeeList.SelectionSort02();
            }

            OurMessageBox.Show($"The list has been sorted in {sortOrder} order");

            employeeList.PrintList(lstEmployees);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartUpForm startUpForm= new StartUpForm();
            startUpForm.Show();
        }
    }
}
