using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelo;
namespace Siscop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Modulo.login = this;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Modulo.login = null;
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioUsuario nu = new NegocioUsuario();

            if (this.txtRut.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese su rut", "Error, falta informacion");
                this.txtRut.Focus();
                return;
            }

            if (this.txtClave.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese su clave", "Error, falta informacion");
                this.txtClave.Focus();
                return;
            }

            if (nu.IniciarSesion(this.txtRut.Text.Trim(), this.txtClave.Text.Trim()) == false)
            {

                MessageBox.Show(this, "Rut /clave incorrectos", "Error, no se encuentra el usuario");
                limpiarCampos();
                return;

            }

            if (nu.estaBloqueado(this.txtRut.Text.Trim()) == true)
            {
                MessageBox.Show(this, "El Usuario: "+ this.txtRut.Text.Trim()+"\nse encuentra BLOQUEADO\nPorfavor, contacte a un administrador", "Error, acceso denegado");
                limpiarCampos();
                return;
            }

            Usuario u = nu.getUsuario(this.txtRut.Text.Trim());
            Modulo.usuario = u;
            Modulo.Menu.iniciarSesion();

            this.Dispose();
            Modulo.login = null;
        }
      

        private void limpiarCampos()
        {
            this.txtRut.Text = "";
            this.txtClave.Text = "";
            this.txtRut.Focus();

        }
    }

}
