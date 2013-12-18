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
    public partial class PatientAdd : Form
    {
        public PatientAdd()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBpatientDS);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBpatientDS.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.myDBpatientDS.Patient);
            
            titleTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            addressTextBox.Clear();
            postCodeTextBox.Clear();
            dateOfBirthTextBox.Clear();
            landLineNumberTextBox.Clear();
            mobileNumberTextBox.Clear();
            emailTextBox.Clear();          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.patientTableAdapter.InsertPatientQuery(titleTextBox.Text, 
                                            firstNameTextBox.Text, 
                                            lastNameTextBox.Text,
                                            addressTextBox.Text,
                                            postCodeTextBox.Text,
                                            dateOfBirthTextBox.Text,
                                            Convert.ToInt32(landLineNumberTextBox.Text),
                                            Convert.ToInt32(mobileNumberTextBox.Text),
                                            emailTextBox.Text);
            this.patientTableAdapter.Update(this.myDBpatientDS.Patient);

        }

        private void PatientAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
        }
    }
}
