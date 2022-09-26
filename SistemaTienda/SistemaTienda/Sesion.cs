using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaTienda
{
    public partial class Sesion : Form
    {
        //Conectamos a la Base de datos
        BaseDeDatos bd = new BaseDeDatos();

        public Sesion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Inicio = new Form1();
            Inicio.Show();
        }

        private void Sesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = bd.selectstring("select nombreusuario from usuario where nombreusuario = '" + txtUsuario.Text + "'");
            string contraseña = bd.selectstring("select contraseña from usuario where contraseña = '" + txtContraseña.Text + "'");

            //ToolTip
            ToolTip msUsuario = new ToolTip();
            msUsuario.ShowAlways = true;
            msUsuario.SetToolTip(txtUsuario, "Ingrese su usuario");
            ToolTip msContraseña = new ToolTip();
            msContraseña.ShowAlways = true;
            msContraseña.SetToolTip(txtContraseña, "Ingrese su contraseña");

            if (txtUsuario.TextLength > 0 && txtContraseña.TextLength > 0)
            {
                if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Llene los campos correspondientes para acceder");
            }
        }
    }
}
