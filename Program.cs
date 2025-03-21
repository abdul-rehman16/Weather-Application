using System;
using System.Windows.Forms;

namespace Weather_Application
{
    internal static class Program
    {
        //Entry Point for the project
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
