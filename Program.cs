using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peace_Portal_Payroll
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

            // Run(new PayrollListForm());  for Tim's startup
            // Run(new PPMainForm());  for original startup
            Application.Run(new PPMainForm());
        }
    }
}
