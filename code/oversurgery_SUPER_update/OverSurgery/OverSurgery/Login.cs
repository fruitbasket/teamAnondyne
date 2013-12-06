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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {   
            ClassReceptionist user = new ClassReceptionist();
            user._username = receptionistDataGridView.Rows[0].Cells[1].Value.ToString();
            user._password = receptionistDataGridView.Rows[0].Cells[2].Value.ToString();
            
            if (user._username == textboxUsername.Text && user._password == textboxPassword.Text)
            {
                MainScreen Screen = new MainScreen();
                this.Visible = false;
                Screen.Visible = true;
                ClassGlobalVars.loginClose = true;
            }
            else
            {
                labelError.Text = "Incorrect username or password!";
                //checking if empty fields upon login attempt 
                if (textboxPassword.Text == "" && textboxUsername.Text == "")
                {
                    labelError.Text = "Enter your username and password!";
                }
                else
                {
                    if (textboxUsername.Text == "")
                    {
                        labelError.Text = "Enter your username!";
                    }
                    if (textboxPassword.Text == "")
                    {
                        labelError.Text = "Enter your password!";
                    }
                } 
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void receptionistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receptionistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBreceptionistDS);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBreceptionistDS.Receptionist' table. You can move, or remove it, as needed.
            this.receptionistTableAdapter.Fill(this.myDBreceptionistDS.Receptionist);

        }

    }
}
