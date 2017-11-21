using CodingDojo05.Communication;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CodingDojo05.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private Client clientCommunication;
        private bool isConnected = false;

        public string ChatName { get; set; }
        public string Message { get; set; }
        public ObservableCollection<string> ReceivedMessages { get; set; }
        public RelayCommand ClickSendBtn { get; set; }
        public RelayCommand ClickConnectBtn { get; set; }

        public MainViewModel()
        {
            Message = "";
            ReceivedMessages = new ObservableCollection<string>();

            ClickConnectBtn = new RelayCommand(
                ()=>
                {
                    isConnected = true;
                    clientCommunication = new Client("127.0.0.1", 10100, new Action<string>(NewMessageRecieved), ClientDissconnected);
                },
                () =>
                {
                    return (!isConnected);
                }
                );

            ClickSendBtn = new RelayCommand(
                () =>
                {
                    clientCommunication.Send(ChatName + ": " + Message);
                    ReceivedMessages.Add("YOU: " + Message);
                },
                () =>
                {
                    return (isConnected && Message.Length >= 1);
                }
                );
        }

        private void ClientDissconnected()
        {
            isConnected = false;
            CommandManager.InvalidateRequerySuggested();
        }

        private void NewMessageRecieved(string obj)
        {
            App.Current.Dispatcher.Invoke(() =>
            {
                ReceivedMessages.Add(Message);
            });
        }
    }
}