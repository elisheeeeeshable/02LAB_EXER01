using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02LAB_EXER01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            QueuingForm queuingForm = new QueuingForm();
            CashierWindowQueueForm cashierForm = new CashierWindowQueueForm();

            cashierForm.Show();
            Application.Run(queuingForm);
            Application.Run(new QueuingForm());
        }
    }
}
