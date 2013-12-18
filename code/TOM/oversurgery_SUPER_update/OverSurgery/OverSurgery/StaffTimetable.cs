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
    public partial class StaffTimetable : Form
    {
        public StaffTimetable()
        {
            InitializeComponent();
        }

        private void timetableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.timetableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBtimetableDS);

        }

        private void StaffTimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBtimetableDS.Timetable' table. You can move, or remove it, as needed.
            this.timetableTableAdapter.Fill(this.myDBtimetableDS.Timetable);
        }

        private void StaffTimetable_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
        }
    }
}
