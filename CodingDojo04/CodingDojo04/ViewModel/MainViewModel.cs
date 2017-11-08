using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace CodingDojo04.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private string firstName = "";
        private string lastName = "";
        private int sSn;
        private DateTime date = DateTime.Now;

        private bool isClickable;
        private ObservableCollection<UserViewModel> users = new ObservableCollection<UserViewModel>();

        RelayCommand clickBtnCommand;
        RelayCommand clickSaveBtnCommand;
        RelayCommand clickLoadBtnCommand;

        public ObservableCollection<UserViewModel> Users
        {
            get { return users; }
            set
            {
                users = value;
            }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int SSN
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
        public RelayCommand ClickSaveBtnCommand { get => clickSaveBtnCommand; set => clickSaveBtnCommand = value; }
        public RelayCommand ClickLoadBtnCommand { get => clickLoadBtnCommand; set => clickLoadBtnCommand = value; }

        public MainViewModel()
        {
            //ClickBtnCommand = new RelayCommand(new Action(ExecuteAdd), new Func<bool>(CanExecuteAdd));
            ClickBtnCommand = new RelayCommand(new Action(ExecuteAdd), () => { if (lastName.Length > 2) { return true; } else { return false; } });
            ClickSaveBtnCommand = new RelayCommand(new Action(ExecuteSave), new Func<bool>(CanExecuteSave));
            ClickLoadBtnCommand = new RelayCommand(new Action(ExecuteLoad), new Func<bool>(CanExecuteLoad));
        }

        private void ExecuteLoad()
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ian\Documents\MyFile.csv");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ian\Documents\MyFile.csv");

            
            foreach (string line in lines)
            {
                
                string[] userFromFile = line.Split(',');

                string[] date = userFromFile[3].Split('.');
                DateTime birthDate = new DateTime(Int32.Parse(date[2]), Int32.Parse(date[1]), Int32.Parse(date[0]));
                
                UserViewModel user = new UserViewModel(userFromFile[2], userFromFile[1], birthDate, Int32.Parse(userFromFile[0]));

                Users.Add(user);
            }
        }

        private void ExecuteSave()
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] lines = new string[users.Count];

            int i = 0;
            foreach (var item in users)
            {
                lines[i] = item.SSN + "," + item.LastName + "," + item.FirstName + "," + item.Date.Day + "." + item.Date.Month + "." + item.Date.Year;
                i++;
            }
            File.WriteAllLines(myDocPath + @"\MyFile.csv", lines);
        }

        private bool CanExecuteAdd()
        {
            if (LastName.Length > 2)
            {
                return true;
            }
            return false;
        }

        private bool CanExecuteLoad()
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"C:\Users\Ian\Documents\MyFile.csv");
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }

        private bool CanExecuteSave()
        {
            if (Users.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void ExecuteAdd()
        {
            UserViewModel user = new UserViewModel(firstName, lastName , date, sSn);

            Users.Add(user);
        }
    }
}