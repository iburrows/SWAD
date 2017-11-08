using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo04.Model
{
    public class User
    {
        private String firstName;
        private string lastName;
        private DateTime birthDate;
        private int ssn;

        public string Firstname {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime Birthdate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }


        public User(string firstName, string lastName, DateTime birthDate, int SSN)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.SSN = SSN;
        }
    }
}
