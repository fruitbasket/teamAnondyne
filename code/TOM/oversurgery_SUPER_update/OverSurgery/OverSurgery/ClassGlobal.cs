using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverSurgery
{
    static class ClassGlobal
    {
        public static bool bookAp;
        public static bool exPres;
        public static int formYLocation = 0;
        public static int formXLocation = 0;

        public static ClassPatient patient = new ClassPatient();

        public static ClassStaff staff = new ClassStaff();
    }
}
