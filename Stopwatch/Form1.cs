using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

/* Используя Visual Studio, создайте проект по шаблону WPF Application. 
       Создайте программу секундомер. Требуется выводить показания секундомера в окне. Окно имеет 
       кнопки запуска, останова и сброса секундомера. Для реализации секундомера используйте паттерн MVP.  */

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private System.Diagnostics.Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            stopWatch = new System.Diagnostics.Stopwatch();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.label1.Text = stopWatch.Elapsed.ToString();
        }
    }
}