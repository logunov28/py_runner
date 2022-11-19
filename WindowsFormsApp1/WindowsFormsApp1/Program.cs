using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Registry.CurrentUser.OpenSubKey(@"Software\Python") != null) //если путь существует
            {
                if (System.IO.File.Exists("run.pyc"))
                {
                    Process.Start("run.pyc");
                }
                else if (System.IO.File.Exists("run.pyo"))
                {
                    Process.Start("run.pyo");
                }
                else if (System.IO.File.Exists("run.pyw"))
                {
                    Process.Start("run.pyw");
                }
                else if (System.IO.File.Exists("run.py"))
                {
                    Process.Start("run.py");
                }
                else
                {
                    MessageBox.Show("Nothing to run!", "Error");
                }

            }
            else
            {
                MessageBox.Show("Python 3 is not installed!", "Error");
            }
            
        }
    }
}
