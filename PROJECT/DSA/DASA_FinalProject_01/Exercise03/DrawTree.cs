using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASA_FinalProject_01
{
    internal class DrawTree
    {
        public void DrawingTree(Graphics g, BST.TreeNode node, int x, int y, int Space, BST.TreeNode foundNode)
        {
            Pen pen = new Pen(Color.Black, 3);
            if (node == null)
                return;

            string value_digit = node.Value.ToString();
            int width = (value_digit.Length == 1) ? 40 : (value_digit.Length == 2 ? 40 : 45);
            g.FillEllipse(Brushes.Turquoise, x - width / 2, y - width / 2, width, width);
            pen = (node == foundNode) ? new Pen(Color.Red, 3) : new Pen(Color.Black, 3);
            g.DrawEllipse(pen, x - width / 2, y - width / 2, width, width);

            if (value_digit.Length == 1)
            {
                g.DrawString(node.Value.ToString(), new Font("FiraCode", 10, FontStyle.Bold), Brushes.Black, x - 7, y - 10);
            }
            else if (value_digit.Length == 2)
            {
                g.DrawString(node.Value.ToString(), new Font("FiraCode", 10, FontStyle.Bold), Brushes.Black, x - 14, y - 10);
            }
            else if (value_digit.Length >= 3)
            {
                g.DrawString(node.Value.ToString(), new Font("FiraCode", 10, FontStyle.Bold), Brushes.Black, x - 15, y - 7);
            }

            Pen LinePen = new Pen(Color.Black, 3);
            if (node.Left != null)
            {
                g.DrawLine(LinePen, x, y + width / 2, x - Space, y + width);
                DrawingTree(g, node.Left, x - Space, y + width, Space / 2, foundNode);
            }

            if (node.Right != null)
            {
                g.DrawLine(LinePen, x, y + width / 2, x + Space, y + width);
                DrawingTree(g, node.Right, x + Space, y + width, Space / 2, foundNode);
            }
           
        }
    }
}
