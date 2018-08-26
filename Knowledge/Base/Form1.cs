using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //IDocument doc = new Document("");

            //doc.Click += doc_Click;

            //MessageBox.Show(doc[1]);
            Footer footer0 = new Footer();
            Footer footer1 = new Footer();

            MessageBox.Show( Footer.index.ToString() );

        }

        void doc_Click(string mess)
        {
            MessageBox.Show(mess);
        }

    }
    public class GoodException : ApplicationException
    {
    }
    public interface IDocument
    {
        event WorkerEventHandler Click;
        string this[int index]
        {
            get;
            set;
        }
    }
    public class Footer
    {
        public static int index = 0;
        static Footer()
        {
            index++;
        }
        public Footer()
        {
            index++;
        }
    }
    public delegate void WorkerEventHandler(string source);

    public class Document : IDocument
    {
        public Document(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get;
            set;
        }

        public event WorkerEventHandler Click;

        public string this[int index]
        {
            get
            {
                if (Click != null)
                {
                    Click("你好");
                }
                return "2";
            }
            set
            {
            }
        }
    }
}
