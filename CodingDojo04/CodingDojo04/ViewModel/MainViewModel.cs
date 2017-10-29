using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;

namespace CodingDojo04.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private string firstName = "";
        private string lastName = "";
        private int sSn;
        private string date;
        private bool isClickable;

        RelayCommand clickBtnCommand;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public bool IsClickable
        {
            get { return isClickable; }
            set { isClickable = value; }
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
            //add logic to add the data to the list
            throw new NotImplementedException();
        }
    }
}