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
    public partial class Staff_Ava : Form
    {
        public Staff_Ava()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBStaffDS);

        }

        private void Staff_Ava_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBStaffDS.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.myDBStaffDS.Staff);

        }
    }
}
