using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverSurgery
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
        }

        private void personDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(795, 554);
            this.Name = "MainScreen";
            this.ResumeLayout(false);
            this.Hide();
        }
        
    }
}
