using DudgetTracker;
using loadingpage;
using System;
using System.Windows.Forms;

namespace BudgetTracker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new load());
        }
    }
}
