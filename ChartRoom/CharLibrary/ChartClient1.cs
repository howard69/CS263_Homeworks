using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharLibrary
{
    public partial class ChartClient1 : Form, IObserver, ISubject
    {
        private List<IObserver> AllMessage;
        private MessageData message;

        public ChartClient1()
        {
            InitializeComponent();
            AllMessage = new List<IObserver>();
            this.message = new MessageData();
            this.RegisterObserver(this);
        }

        private void SentMessage()
        {
            MessageData messagedata = new MessageData { };
            if (MessageTextBox.Text == string.Empty)
                messagedata.LineString = this.Text + " say：" + SentMessageTextBox.Text;
            else
                messagedata.LineString = MessageTextBox.Text + "\n" + this.Text + " say：" + SentMessageTextBox.Text;
            SentMessageTextBox.Text = string.Empty;
            this.MessageChange(messagedata);
        }

        private void SentButton_Click(object sender, EventArgs e)
        {
            SentMessage();
        }

        public void MessageChange(MessageData data)
        {
            if (data.LineString != this.message.LineString)
            {
                this.message = data.Clone();
                Notify();
            }
        }

        public void Notify()
        {
            foreach (IObserver o in AllMessage)
                o.UpdateMessage(this, this.message);
        }

        public void RegisterObserver(IObserver o)
        {
            AllMessage.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            AllMessage.Remove(o);
        }

        public void UpdateMessage(object sender, EventArgs args)
        {
            MessageData data = args as MessageData;
            MessageTextBox.Text = data.LineString.ToString();
        }

        private void ChartClient1_Load(object sender, EventArgs e)
        {
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SentMessageTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}