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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBpatientDS);
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBpatientDS.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.myDBpatientDS.Patient);
            ClassGlobal.bookAp = false;
            ClassGlobal.exPres = false;
        }

        private void buttonSearch(object sender, EventArgs e)
        {
            //sql query for searching for patient and binding data to the datagrid
            //this.patientTableAdapter.Fill(this.patientTableAdapter.GetDataBy2(textBoxFirstName.Text, textBoxLastName.Text, textBoxPostCode.Text, textBoxDOB.Text));
            this.patientDataGridView.AutoGenerateColumns = true;
            this.patientDataGridView.DataSource = this.patientTableAdapter.GetDataBy2(textBoxPFirstName.Text, textBoxPLastName.Text, textBoxPPostCode.Text, textBoxPDOB.Text);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            //creates new patient object and assigns searched for patient id to it
            //switches to next tab
            ClassPatient patient = new ClassPatient();
            patient._patientID = Convert.ToInt32(patientDataGridView.Rows[0].Cells[0].Value);
            patient._title = patientDataGridView.Rows[0].Cells[1].Value.ToString();
            patient._firstName = patientDataGridView.Rows[0].Cells[2].Value.ToString();
            patient._lastName = patientDataGridView.Rows[0].Cells[3].Value.ToString();
        }

        private void SearchPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClassGlobal.bookAp != true && ClassGlobal.exPres != true)
            {
                MainScreen mainMenu = new MainScreen();
                mainMenu.Show();
            }
        }

        private void buttonContinue_Click_1(object sender, EventArgs e)
        {
            ClassGlobal.patient._patientID = Convert.ToInt32(patientDataGridView.Rows[0].Cells[0].Value);
            ClassGlobal.patient._title = patientDataGridView.Rows[0].Cells[1].Value.ToString();
            ClassGlobal.patient._firstName = patientDataGridView.Rows[0].Cells[2].Value.ToString();
            ClassGlobal.patient._lastName = patientDataGridView.Rows[0].Cells[3].Value.ToString();
            ClassGlobal.bookAp = true;

            this.Close();
            RegAppointment reg = new RegAppointment();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassGlobal.exPres = true;
            this.Close();
            Prescription pres = new Prescription();
            pres.Show();
        }

        public void buttonPatientSearch_Click(object sender, EventArgs e)
        {
            this.patientDataGridView.AutoGenerateColumns = true;
            this.patientDataGridView.DataSource = this.patientTableAdapter.GetDataBy2(textBoxPFirstName.Text, textBoxPLastName.Text, textBoxPPostCode.Text, textBoxPDOB.Text);
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
