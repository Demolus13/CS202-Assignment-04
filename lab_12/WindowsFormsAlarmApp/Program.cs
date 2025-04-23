using System;
using System.Windows.Forms;

namespace WindowsFormsAlarmApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Standard initialization for a Windows Forms application.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
