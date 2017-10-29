using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;

namespace CodingDojo04.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private string firstName = "";
        private string lastName = "";
        private int sSn;
        private string date;

        private bool isClickable;
        private ObservableCollection<MainViewModel> users = new ObservableCollection<MainViewModel>();


        RelayCommand clickBtnCommand;

        public ObservableCollection<MainViewModel> Users
        {
            get { return users; }
            set
            {
                users = value;
            }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

       public int Ssn
        {
            get { return sSn; }
            set { sSn = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public bool IsClickable
        {
            get { return isClickable; }
            set { isClickable = value; }
        }

        public RelayCommand ClickBtnCommand { get => clickBtnCommand; set => clickBtnCommand = value; }

        public MainViewModel()
        {
            //ClickBtnCommand = new RelayCommand(new Action(ExecuteAdd), new Func<bool>(CanExecuteAdd));
            ClickBtnCommand = new RelayCommand(new Action(ExecuteAdd), () => { if (LastName.Length > 2) { return true; } else { return false; } });
        }

        private bool CanExecuteAdd()
        {
            if (LastName.Length > 2)
            {
                return true;
            }
            return false;
        }

        private void ExecuteAdd()
        {
            MainViewModel user = new MainViewModel();
            user.firstName = "Ian";
            user.lastName = "Burrows";
            user.sSn = 123;
            user.date = "2017-10-29";

            Users.Add(user);
            //add logic to add the data to the list
            
        }
    }
}