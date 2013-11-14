using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OverSurgery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //opens first form, the window for logging into the system
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            //checks if first successful login and then opens the main screen
            if(GlobalVars.loginClose)
            {
                Application.Run(new MainScreen());
            }
            
        }

    }
}
