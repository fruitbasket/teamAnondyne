using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    class ClassStaff
    {
        //Staff variables
        private int staffID;
        private string firstName;
        private string lastName;
        private string staffRole;
        private string Availbility;

        // Staff Properties
        public int _staffID
        {
            get
            {
                return staffID;
            }
            set
            {
                staffID = value;
            }
        }

        public string _firstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string _lastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string _staffRole
        {
            get
            {
                return staffRole;
            }
            set
            {
                staffRole = value;
            }
        }

        public string _Availbility
        {
            get
            {
                return Availbility;
            }
            set
            {
                Availbility = value;
            }
        }

        // Staff methods
        public void staffSearch()
        {


        }

    }
}
