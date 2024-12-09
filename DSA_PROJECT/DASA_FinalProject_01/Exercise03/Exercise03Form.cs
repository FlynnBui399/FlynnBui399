using DASA_FinalProject_01.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DASA_FinalProject_01
{
    public partial class Exercise03Form : Form
    {
        private BST.TreeNode foundNode = null;
        private Bitmap drawingBitmap;
        private Graphics drawingGraphics;
        private BST bst;
        private DrawTree treeDrawer;
        public Exercise03Form()
        {
            InitializeComponent();
            bst = new BST();
            treeDrawer = new DrawTree();
            drawingBitmap = new Bitmap(drawingBox.Width, drawingBox.Height);
            drawingGraphics = Graphics.FromImage(drawingBitmap);
            drawingBox.Paint += drawingBox_Paint;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int value;
            int count_node = bst.CountNodes(bst.GetRoot());
            if (int.TryParse(txtValue.Text, out value))
            {
                if (bst.Search(value))
                {
                    OurMessageBox.Show("This value already exists in the tree. Please enter a different value");
                    txtValue.Clear();
                }
                else
                {
                    bst.Insert(value);
                    drawingGraphics.Clear(Color.White);
                    drawingBox.Invalidate();
                    txtValue.Clear();
                    txtNCout.Text = bst.CountNodes(bst.GetRoot()).ToString();
                    if(bst.CountNodes(bst.GetRoot()) <= 1)
                    {
                        txtLeafCount.Clear();
                    }
                    else {
                        txtLeafCount.Text = bst.CountLeafNodes(bst.GetRoot()).ToString();
                    }
                    
                    txtOneChildNodeCount.Text = bst.CountOneChildNodes(bst.GetRoot()).ToString();
                    txtTwoChildNodeCount.Text = bst.CountTwoChildNodes(bst.GetRoot()).ToString();
                    txtDepth.Text = bst.GetDepth(bst.GetRoot()).ToString();
                }
            }
            else
            {
                OurMessageBox.Show("Please enter a valid integer");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtValue.Text, out value))
            {
                if (!bst.Search(value))
                {
                    OurMessageBox.Show("This value does not exists int the tree. Please enter another value");
                    txtValue.Clear();
                }
                else
                {
                    bst.Delete(value);
                    drawingGraphics.Clear(Color.White);
                    drawingBox.Invalidate();
                    txtValue.Clear();
                    txtNCout.Text = bst.CountNodes(bst.GetRoot()).ToString();
                    if (bst.CountNodes(bst.GetRoot()) <= 1)
                    {
                        txtLeafCount.Clear();
                    }
                    else
                    {
                        txtLeafCount.Text = bst.CountLeafNodes(bst.GetRoot()).ToString();
                    }
                    txtOneChildNodeCount.Text = bst.CountOneChildNodes(bst.GetRoot()).ToString();
                    txtTwoChildNodeCount.Text = bst.CountTwoChildNodes(bst.GetRoot()).ToString();
                    txtDepth.Text = bst.GetDepth(bst.GetRoot()).ToString();
                }

            }
            else
            {
                OurMessageBox.Show("Please enter a valid integer");
            }
        }
        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, -10, 0);
            treeDrawer.DrawingTree(e.Graphics, bst.GetRoot(), 300, 50, 150, foundNode);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int value_searched;
            string value_search = txtSearch.Text;
            if (int.TryParse(value_search, out value_searched))
            {
                foundNode = bst.SearchingNode(value_searched);

                if (foundNode != null)
                {
                    OurMessageBox.Show("Node found!!!");
                    drawingGraphics.Clear(Color.White);
                    drawingBox.Invalidate();
                    txtSearch.Clear();
                }
                else
                {
                    OurMessageBox.Show("Not Found");
                }
            }
            else
            {
                OurMessageBox.Show("Please enter a valid integer");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foundNode = null;
            drawingGraphics.Clear(Color.White);
            drawingBox.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bst.Clear();
            drawingGraphics.Clear(Color.White);
            OurMessageBox.Show("The BST is cleared");
            drawingBox.Invalidate();
            txtNCout.Text = bst.CountNodes(bst.GetRoot()).ToString();
            txtLeafCount.Text = bst.CountLeafNodes(bst.GetRoot()).ToString();
            txtOneChildNodeCount.Text = bst.CountOneChildNodes(bst.GetRoot()).ToString();
            txtTwoChildNodeCount.Text = bst.CountTwoChildNodes(bst.GetRoot()).ToString();
            txtDepth.Text = bst.GetDepth(bst.GetRoot()).ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartUpForm startUpForm = new StartUpForm();
            startUpForm.Show();
        }
    }
}
