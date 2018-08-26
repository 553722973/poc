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

namespace Base
{
    public partial class AnysnTest : Form
    {
        public AnysnTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargador cargador = new Cargador(mess =>
            {
                this.Invoke(new Action(() => Print(mess)));
            });
            cargador.DoSomething();
        }
        private void Print(string mess)
        {
            textBox1.Text += mess + "\r\n";
        }
    }
    public class Cargador
    {
        int count = 0;
        Action<string> OutPrintHandler;
        public Cargador(Action<string> printHandler)
        {
            OutPrintHandler = printHandler;
        }
        public async void DoSomething()
        {
            var result = Work().Result;
            OutPrintHandler.Invoke("执行完毕:" + result.ToString());
        }
        async Task<int> Work()
        {
            return await Task<int>.Run(() =>
            {
                count = 5;
                while (count > 0)
                {
                    string mess = "正在做第[" + count.ToString() + "]件事情";
                    OutPrintHandler.Invoke(mess);
                    Thread.Sleep(1000 * 1);
                    count--;
                }
                return 100;
            });
        }
    }
}