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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientAdd patientAdd = new PatientAdd();
            patientAdd.Show();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegAppointment regAppointment = new RegAppointment();
            regAppointment.Show();
        }

    }
}
