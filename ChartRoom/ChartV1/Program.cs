using CharLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartV1
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChartForm mainForm = new ChartForm();
            //mainForm.RegisterObserver(new ChartClient1());
            //mainForm.RegisterObserver(new ChartClient2());
            mainForm.RegisterObserver(new ChartForm2());

            Application.Run(mainForm);
        }
    }
}