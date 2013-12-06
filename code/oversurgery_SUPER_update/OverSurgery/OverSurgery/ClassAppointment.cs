using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Appointment
    {
        private string timeSlot;
        private DateTime date;

        public string _timeSlot
        {
            get
            {
                return timeSlot;
            }
            set
            {
                timeSlot = value;
            }
        }

        public DateTime _date
        {
            get
            {

                return date;

            }

            set
            {
                date = value;

            }
        }

        public void AppointmentBook()
        {

        }
    }
}
