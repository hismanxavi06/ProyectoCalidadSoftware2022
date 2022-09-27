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
    public partial class Form1 : Form
    {
        public Form1()
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
            else
            {
                button5.Enabled = false;
                button5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sesion Sesion = new Sesion();
            Sesion.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //botones del menu
        private void button2_Click(object sender, EventArgs e)//Boton productos
        {
            this.Hide();
            Productos consulta = new Productos();
            consulta.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)//Inventario
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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
