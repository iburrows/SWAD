using System;
using CodingDojo04.Model;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.CommandWpf;


namespace CodingDojo04.ViewModel
{

    public class UserViewModel : ViewModelBase
    {
        private User user;

        public DateTime Date
        {
            get { return user.Birthdate; }
            set { user.Birthdate = value; RaisePropertyChanged(); }
        }

        public int SSN
        {
            get { return user.SSN; }
            set { user.SSN = value; }
        }

        public string LastName
        {
            get { return user.Lastname; }
            set { user.Lastname = value; }
        }

        public string FirstName
        {
            get { return user.Firstname; }
            set { user.Firstname = value; }
        }

        public UserViewModel(string firstName, string lastName, DateTime birthDate, int ssn)
        {
            this.user = new User(firstName, lastName, birthDate, ssn);
        }
    }
}
