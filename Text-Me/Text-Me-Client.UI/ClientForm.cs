﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Me_Client.UI
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            messageWindowUserControl.OnSendMessage += SendMessage;
            connectionUserControl.OnMessageReceived += MessageReceived;
        }

        private void MessageReceived(string receivedMessage)
        {
            messageWindowUserControl.LogReceivedMessage(receivedMessage);
        }

        private bool SendMessage(string messageToSend)
        {
            return connectionUserControl.SendMessage(messageToSend);
        }
    }
}
