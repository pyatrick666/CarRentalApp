using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; // Add this line for DataSet and DataTable
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static object someCustomerId { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcomescreen());
          
        }
    }
}
    
       
