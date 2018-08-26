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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 o = new Class2();
            //MessageBox.Show(o.MethodA());
        }
    }


    abstract class BaseClass
    {
        public virtual void MethodA()
        {
        }
        public virtual void MethodB()
        {
        }
    }
    class Class1 : BaseClass
    {
        public void MethodA(string arg)
        {
        }
        public override void MethodB()
        {
        }
    }
    class Class2 : Class1
    {
        new public void MethodB()
        {
        }
    }
}
