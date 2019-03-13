using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Student
    {
        private string FirstName;
        private string LastName;
        private string Gender;
        private string Email;
        private string Contact;
        private DateTime DOB;
        private string RegNo;

        public string First_Name
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string Last_Name
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public string gender
        {
            get
            {
                return Gender;
            }

            set
            {
                Gender = value;
            }
        }

        public string Emails
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string Contacts
        {
            get
            {
                return Contact;
            }

            set
            {
                Contact = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return DOB;
            }

            set
            {
                DOB = value;
            }
        }

        public string RegistrationNo
        {
            get
            {
                return RegNo;
            }

            set
            {
                RegNo = value;
            }
        }
    }
}
