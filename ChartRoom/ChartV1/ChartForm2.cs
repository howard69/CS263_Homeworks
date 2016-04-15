using CharLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartV1
{
    public partial class ChartForm2 : Form, ISubject, IObserver
    {
        private List<IObserver> AllMessage;
        private MessageData message;

        public ChartForm2()
        {
            InitializeComponent();
            AllMessage = new List<IObserver>();
            this.message = new MessageData();
            this.RegisterObserver(this);
        }

        private void ChartForm2_Load(object sender, EventArgs e)
        {
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

        private void SentButton_Click_1(object sender, EventArgs e)
        {
            SentMessage();
        }
    }
}