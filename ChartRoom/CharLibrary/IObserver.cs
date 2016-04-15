using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharLibrary
{
    public interface IObserver
    {
        void UpdateMessage(object sender, EventArgs args);
    }
}