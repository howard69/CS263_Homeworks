using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharLibrary
{
    public class MessageData : EventArgs
    {
        public string LineString { get; set; }

        public MessageData()
        {
        }

        public MessageData(MessageData message)
        {
            this.LineString = message.LineString;
        }

        public MessageData Clone()
        {
            return new MessageData(this);
        }
    }
}