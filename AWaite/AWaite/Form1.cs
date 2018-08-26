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

namespace AWaite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => DoSomeThing());
            Write("结束");
        }
        void DoSomeThing()
        {
            while (true)
            {
                Write("运行");
                Thread.Sleep(1000);
            }
        }

        void Write(string mess)
        {
            this.BeginInvoke(new Action<string>(info =>
            {
                labelMess.Text += info + "\r\n";
            }), mess);
        }
    }
}
