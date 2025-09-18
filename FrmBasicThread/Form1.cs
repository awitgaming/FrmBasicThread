using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class frmBasicThread : Form
    {
       
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Join();
            ThreadB.Join();

            lblShow.Text = "     -End of Thread-";
            Console.WriteLine("-End Of Thread-");


        }
    }
}
