using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverSurgery
{
    class ClassPatient
    {
        // Patient Variables
        private int patientID;
        private string title;
        private string firstName;
        private string lastName;
        private string address;
        private string postCode;
        private string dateOfBirth;
        private int landlineNumber;
        private int mobileNumber;
        private string email;

        //Patient Properties
        public int _patientID
        {
            get
            {
                return patientID;
            }
            set
            {
                patientID = value;
            }
        }

        public string _title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
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

        public string _address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string _postCode
        {
            get
            {
                return postCode;
            }
            set
            {
                postCode = value;
            }
        }

        public string _dateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public int _landlineNumber
        {
            get
            {
                return landlineNumber;
            }
            set
            {
                landlineNumber = value;
            }
        }

        public int _mobileNumber
        {
            get
            {
                return mobileNumber;
            }
            set
            {
                mobileNumber = value;
            }
        }

        public string _email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        // Patient Class Methods
        public void patientRegister()
        {

        }

        public void patientSearch()
        {

        }
    }
}
