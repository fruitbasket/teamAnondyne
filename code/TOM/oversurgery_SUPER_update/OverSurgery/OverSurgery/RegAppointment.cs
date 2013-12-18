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
    public partial class RegAppointment : Form
    {
        public RegAppointment()
        {
            InitializeComponent();
        }

        private void RegAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            //opens main screen form on close
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBpatientDS);
        }

        private void RegAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBtimetableDS.Timetable' table. You can move, or remove it, as needed.
            this.timetableTableAdapter.Fill(this.myDBtimetableDS.Timetable);
            // TODO: This line of code loads data into the 'myDBStaffDS.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.myDBStaffDS.Staff);
            // TODO: This line of code loads data into the 'myDBpatientDS.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.myDBpatientDS.Patient);
            
            //adds values to combo box for staff search
            string[] roles = new string[] { "DR", "Nurse" };
            comboBoxRole.Items.AddRange(roles);
            string[] times = new string[] {"09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00",
                                            "14:30", "15:00", "15:30", "16:00", "16:30"};
            comboBoxTimes.Items.AddRange(times);
        }

        private void buttonStaffSearch_Click(object sender, EventArgs e)
        {
            //sql query for searching for staff and binding data to the datagrid
            this.staffDataGridView.AutoGenerateColumns = true;
            this.staffDataGridView.DataSource = this.staffTableAdapter.GetDataBy(comboBoxRole.Text, textBoxStaffFName.Text, textBoxStaffLName.Text);
        }

        /*private void buttonContinue_Click(object sender, EventArgs e)
        {
            //creates new patient object and assigns searched for patient id to it
            //switches to next tab
            ClassPatient patient = new ClassPatient();
            patient._patientID = Convert.ToInt32(patientDataGridView.Rows[0].Cells[0].Value);
            patient._title = patientDataGridView.Rows[0].Cells[1].Value.ToString();
            patient._firstName = patientDataGridView.Rows[0].Cells[2].Value.ToString();
            patient._lastName = patientDataGridView.Rows[0].Cells[3].Value.ToString();

            //this.patientDataGridView.AutoGenerateColumns = true;
            //this.patientDataGridView1.DataSource = this.patientTableAdapter.GetDataBy3(patient._firstName, patient._lastName);

            textBoxAPTitle.Text = patient._title;
            textBoxAPFName.Text = patient._firstName;
            textBoxAPLName.Text = patient._lastName;
            tabControl.SelectedIndex = 1;
        }*/

        private void buttonSContinue_Click(object sender, EventArgs e)
        {
            //creates new staff object and assigns searched for staff id to it
            //switches to next tab
            ClassGlobal.staff._staffID = Convert.ToInt32(staffDataGridView.Rows[0].Cells[0].Value);
            ClassGlobal.staff._staffRole = staffDataGridView.Rows[0].Cells[3].Value.ToString();
            ClassGlobal.staff._firstName = staffDataGridView.Rows[0].Cells[1].Value.ToString();
            ClassGlobal.staff._lastName = staffDataGridView.Rows[0].Cells[2].Value.ToString();

            textBoxASRole.Text = ClassGlobal.staff._staffRole;
            textBoxASFName.Text = ClassGlobal.staff._firstName;
            textBoxASLName.Text = ClassGlobal.staff._lastName;

            textBoxAPTitle.Text = ClassGlobal.patient._title;
            textBoxAPFName.Text = ClassGlobal.patient._firstName;
            textBoxAPLName.Text = ClassGlobal.patient._lastName;

            tabControl.SelectedIndex = 1;
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.timetableTableAdapter.InsertQuery(ClassGlobal.staff._staffID, ClassGlobal.patient._patientID, dateTimePicker1.Text, comboBoxTimes.Text);
            this.timetableTableAdapter.Update(this.myDBtimetableDS.Timetable);

            this.Close();
        }
    }
}
