using System;
using System.Drawing;
using System.Windows.Forms;

namespace WIPR_FinalProject_Entity.Classes
{
    public static class DataGridViewHelper
    {
        /// <summary>
        /// Setup Unicode font for DataGridView to display Vietnamese characters properly
        /// </summary>
        /// <param name="dgv">DataGridView to configure</param>
        /// <param name="size">Font size (default is 10)</param>
        public static void SetupVietnameseFont(this DataGridView dgv, float size = 10.0f)
        {
            // Setup appropriate Unicode font for DataGridView
            Font vietnameseFont = new Font("Segoe UI", size, FontStyle.Regular);
            
            // Apply font to DataGridView
            dgv.Font = vietnameseFont;
            dgv.DefaultCellStyle.Font = vietnameseFont;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", size, FontStyle.Bold);
            
            // Configure properties for DataGridView to better display Unicode
            dgv.DefaultCellStyle.Padding = new Padding(3);
            dgv.RowHeadersDefaultCellStyle.Font = vietnameseFont;
        }
    }
} 