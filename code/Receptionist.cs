﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverSurgery
{
    class Receptionist
    {
        private string username;
        private string password;

        public string _username
        {
            get
            {
                return username;
            }
            set
            {
               username = value;
            }
        }

        public string _password
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public bool Login(string inputUN, string inputPW)
        {
            if (inputUN == username && inputPW == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
