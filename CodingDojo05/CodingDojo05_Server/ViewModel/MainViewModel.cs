using CodingDojo05_Server.TheServer;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System;

namespace CodingDojo05_Server.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private Server server;
        private const int port = 10100;
        private const string ip = "127.0.0.1";
        private bool isConnected = false;
        //private DataHandler dHandler;

        public RelayCommand ClickStartCommand { get; set; }
        public RelayCommand ClickStopCommand { get; set; }

        public ObservableCollection<string> Users { get; set; }
        public ObservableCollection<string> Messages { get; set; }
        public int NoOfReceivedMessages
        {
            get
            {
                return Messages.Count;
            }
        }
        public MainViewModel()
        {
            Users = new ObservableCollection<string>();
            Messages = new ObservableCollection<string>();

            ClickStartCommand = new RelayCommand(
                () =>
                {
                    server = new Server(ip, port, UpdateGuiWithNewMessage);
                    server.StartAccepting();
                    isConnected = true;
                },
                () => { return !isConnected; }
                );

            ClickStopCommand = new RelayCommand(
                () =>
                {
                    server.StopAccepting();
                    isConnected = false;
                },
                () =>
                {
                    return isConnected;
                }
                );

        }

        private void UpdateGuiWithNewMessage(string message)
        {
            App.Current.Dispatcher.Invoke(
                () =>
                {
                    string name = message.Split(':')[0];
                    if (!Users.Contains(name))
                    {
                        Users.Add(name);
                    }
                    Messages.Add(message);
                    RaisePropertyChanged("NoOfReceivedMessages");
                }
                );
        }
    }
}