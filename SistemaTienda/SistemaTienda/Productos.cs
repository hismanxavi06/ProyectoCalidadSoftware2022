using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTienda
{
    public partial class Productos : Form
    {
        //Conectamos a la Base de datos
        BaseDeDatos bd = new BaseDeDatos();

        private void Productos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.SelectDataTable("select * from inventario");
            timer1.Enabled = true;
        }

        public Productos()
        {
            InitializeComponent();
            if (Datos.Ac == "Admin")
            {
                //Damos acceso a todos los botones
            }
            if (Datos.Ac == "Usuario")
            {
                button5.Enabled = false;
                button5.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        //botones del menu
        private void button2_Click(object sender, EventArgs e)//productos
        {
            this.Hide();
            Productos consulta = new Productos();
            consulta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//Inventario
        {
            this.Hide();
            Inventario consulta = new Inventario();
            consulta.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
