using FerreMaster.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FerreMaster
{
	public partial class Login : Form
	{
        Usuario usuario = new Usuario();    
        public Login()
		{
			InitializeComponent();
            
        }

        private void txtUsuario_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void txtContraseña_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, System.EventArgs e)
        {
            {
                string Usuario = txtUsuario.Text;
                string Contraseña = txtContraseña.Text;

                {
                    // Credenciales por defecto para Usuario
                    if (usuario.ValidarCredenciales(Usuario, Contraseña))
                    {
                        AbrirFormulario();
                    }
                    else
                    {
                        MostrarError();
                    }
                }
            }
        }

            // Método para mostrar el formulario y ocultar el actual
            private void AbrirFormulario()
            {
                Form ir = new Form();
                ir.Show();
                this.Hide();
            }

            // Método para mostrar el mensaje de error
            private void MostrarError()
            {
                MessageBox.Show("Error, Usuario o Contraseña Incorrectos.");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }


        

        private void lblUsuario_Click(object sender, System.EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
