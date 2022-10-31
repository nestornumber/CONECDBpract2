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
    public partial class Form2 : Form
    {

        clstransacciones objtransacciones = new clstransacciones();

        public void consulta()
        {


            dataGridView1.DataSource = objtransacciones.consulta("select * from productos");


        }
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string codigo = this.textBox1.Text;
            string nombre = this.textBox2.Text;
            string precio = this.textBox3.Text;

            string sql = "insert into Productos values('"+codigo+"','"+nombre+"','"+precio+"');";

        objtransacciones.ejecutarcomando(sql);

            consulta();

        }
    }
}
