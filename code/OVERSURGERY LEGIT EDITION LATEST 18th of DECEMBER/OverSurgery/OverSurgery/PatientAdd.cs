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

            TextBox[] textBoxPatClear = { titleTextBox, firstNameTextBox,lastNameTextBox, addressTextBox, postCodeTextBox, 
                                        landLineNumberTextBox, mobileNumberTextBox, emailTextBox};

            for (int i = 0; i < textBoxPatClear.Length; i++)
            {
                textBoxPatClear[i].Clear();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxesPat = { titleTextBox, firstNameTextBox,lastNameTextBox, addressTextBox, postCodeTextBox, 
                                       landLineNumberTextBox, mobileNumberTextBox, emailTextBox};

            for (int i = 0; i < textBoxesPat.Length; i++)
            {
                if (textBoxesPat[i].Text.Equals(""))
                {
                    MessageBox.Show("Please Fill in all data entry fields.",
                    "Error");
                    return;
                }
            }

                this.patientTableAdapter.InsertPatientQuery(titleTextBox.Text,
                                                firstNameTextBox.Text,
                                                lastNameTextBox.Text,
                                                addressTextBox.Text,
                                                postCodeTextBox.Text,
                                                //dateOfBirthTextBox.Text,
                                                dateTimePicker1.Text,
                                                Convert.ToInt32(landLineNumberTextBox.Text),
                                                Convert.ToInt32(mobileNumberTextBox.Text),
                                                emailTextBox.Text);

                    this.Validate();
                    this.patientBindingSource.EndEdit();
                    this.patientTableAdapter.Update(this.myDBpatientDS.Patient);

                    //update the form's content from DB
                    this.patientTableAdapter.Fill(this.myDBpatientDS.Patient);

                    this.Close();
        }

        private void PatientAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
        }
    }
}
