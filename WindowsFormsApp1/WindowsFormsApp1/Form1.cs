using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;



namespace WindowsFormsApp1
{

    
    public partial class NoPython : Form
    {

        string mes = "";
        string mes1 = "Python 3 не установлен. Для запуска приложения установите Python 3.";
        string mes2 = "Не найдены файлы для запуска.";
        
        public NoPython()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
