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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen mainMenu = new MainScreen();
            mainMenu.Show();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            ClassGlobal.bookAp = false;
            ClassGlobal.exPres = false;
        }
    }
}
