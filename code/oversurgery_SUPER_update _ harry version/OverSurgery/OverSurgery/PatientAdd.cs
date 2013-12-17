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
            if (firstNameTextBox.Text == string.Empty
                || lastNameTextBox.Text == string.Empty
                || addressTextBox.Text == string.Empty
                || postCodeTextBox.Text == string.Empty
                || dateOfBirthTextBox.Text == string.Empty
                || landLineNumberTextBox.Text == string.Empty
                || mobileNumberTextBox.Text == string.Empty
                || emailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Fill in all data entry fields.",
                "Error");
            }

                DateTime Test;
                if (DateTime.TryParseExact(dateOfBirthTextBox.Text, "dd/mm/yyyy", null, DateTimeStyles.None, out Test) == true)
                {
                    MessageBox.Show("The date is in the correct format");
                 }


            else
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

                this.Validate();
                this.patientBindingSource.EndEdit();
                this.patientTableAdapter.Update(this.myDBpatientDS.Patient);
            }

        }

        private void PatientAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            DateTime Test;
            if (DateTime.TryParseExact(dat.Text, "MM/dd/yyyy", null, out Test) == true)
                Response.Write("Date OK");
            else
                Response.Write("Date Not OK");
        }
    }
}
