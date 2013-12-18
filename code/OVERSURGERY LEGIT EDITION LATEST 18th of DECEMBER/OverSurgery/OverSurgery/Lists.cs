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
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }

        private void Lists_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen main = new MainScreen();
            main.Show();
 
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBpatientDS);

        }

        private void Lists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBStaffDS.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.myDBStaffDS.Staff);
            // TODO: This line of code loads data into the 'myDBpatientDS.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.myDBpatientDS.Patient);

        }
    }
}
