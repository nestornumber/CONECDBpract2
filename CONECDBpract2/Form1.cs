using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONECDBpract2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 objcat = new Form2();
            objcat.MdiParent = this;
            objcat.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
