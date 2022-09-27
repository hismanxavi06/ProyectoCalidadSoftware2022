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
    public partial class Inventario : Form
    {

        //Conectamos a la Base de datos
        BaseDeDatos bd = new BaseDeDatos();

        private void Inventario_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.SelectDataTable("select * from inventario");
            timer1.Enabled = true;
            lblBienvenidoUsuario.Text = bd.selectstring("select usuario from usuario where tipousuario = '" + Datos.Ac + "'");
        }

        public Inventario()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        //Botones del menu
        private void button2_Click(object sender, EventArgs e)//Productos
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                string agregar = "insert into dbo.inventario values ('" + txtProducto.Text + "'," + txtExistencias.Text + ", '" + txtMarca.Text + "','" + txtColor.Text + "','" + txtTalla.Text + "','" + txtFabrica.Text + "','" + txtDescripcion.Text + "'," + txtPrecio.Text + ")";
                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Registro agregado correctamente");
                    //dataGridView1.DataSource = bd.SelectDataTable("Select P.id, P.nombre, P.cantidad, P.fecha, P. from dbo.registrocajachica P");
                    dataGridView1.DataSource = bd.SelectDataTable("select * from inventario");
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
            catch
            {
                MessageBox.Show("Error" + e);
            }
            txtPrecio.Clear();
            txtColor.Clear();
            txtDescripcion.Clear();
            txtExistencias.Clear();
            txtFabrica.Clear();
            txtMarca.Clear();
            txtTalla.Clear();
            txtProducto.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
