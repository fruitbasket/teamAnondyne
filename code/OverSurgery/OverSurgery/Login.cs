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
            Receptionist test1 = new Receptionist();
            
            if (test1.Login(textboxUsername.Text, textboxPassword.Text))
            {
                this.Close();                
                GlobalVars.loginClose = true;
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

    }
}
