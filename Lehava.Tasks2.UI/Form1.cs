using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lehava.Tasks2.Core;

namespace Lehava.Tasks2.UI
{
    public partial class Form1 : Form
    {
        Main main = new Main();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            main.CreateFiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Create5Threads();
        }

        private void btnCreRem_Click(object sender, EventArgs e)
        {
            //main.DeleteAfterCreate();
            main.DeleteBigFile();
        }
    }
}
