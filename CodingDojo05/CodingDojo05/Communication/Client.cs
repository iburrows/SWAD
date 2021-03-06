﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo05.Communication
{
    class Client
    {
        byte[] buffer = new byte[512];
        Socket clientSocket;
        Action<string> MessageInformer;
        Action AbortInformer;

        public Client(string ip, int port, Action<string> messageInformer, Action abortInformer)
        {
            try
            {
                this.AbortInformer = abortInformer;
                this.MessageInformer = messageInformer;
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(ip), port);
                clientSocket = client.Client;
                StartReceiving();
            }
            catch (Exception)
            {
                messageInformer("Server is not ready");
                AbortInformer();
            }
        }

        private void StartReceiving()
        {
            Task.Factory.StartNew(Receive);
        }

        private void Receive()
        {
            string message = "";
            while (!message.Equals("@quit"))
            {
                int length = clientSocket.Receive(buffer);
                message = Encoding.UTF8.GetString(buffer, 0, length);
                MessageInformer(message);
            }
            Close();
        }

        private void Close()
        {
            clientSocket.Close();
            AbortInformer();
        }

        public void Send(string message)
        {
            if (clientSocket != null)
            {
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }
        }
    }
}
