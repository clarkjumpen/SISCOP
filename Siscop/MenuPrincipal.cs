using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siscop
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Modulo.Menu = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.cerrarSesionToolStripMenuItem.Enabled = false;

            this.ordenesDeTrabajoToolStripMenuItem.Visible = false;
            this.presupuestoToolStripMenuItem.Visible = false;
            this.requisicionToolStripMenuItem.Visible = false;
            this.inventarioYBodegaToolStripMenuItem.Visible = false;
            this.controlDeUsuariosToolStripMenuItem.Visible = false;
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.login))
            {
                Login admE = new Login();
                admE.MdiParent = this;
                admE.StartPosition = FormStartPosition.CenterScreen;
                admE.Show();
            }
            else
            {
                Modulo.login.Focus();
            }
        }

        public void cerrarSesion() {

            this.lblConexion.ForeColor = Color.Red;
            this.lblConexion.Text = "NO CONECTADO";
            this.lblStatusUser.Text = "";
            this.cerrarSesionToolStripMenuItem.Enabled = false;
            this.iniciarSesionToolStripMenuItem.Enabled = true;
            MessageBox.Show("Sesion cerrada correctamente","¡Correcto!");
            desactivarModulos();
        }
        public void iniciarSesion()
        {
            this.lblConexion.ForeColor = Color.Green;
            this.lblConexion.Text = "CONECTADO COMO: ";
            this.lblStatusUser.Text = "" + Modulo.usuario.RUT;
            this.cerrarSesionToolStripMenuItem.Enabled = true;
            this.iniciarSesionToolStripMenuItem.Enabled = false;

            MessageBox.Show("¡BIENVENIDO!\nNOMBRE: "+Modulo.usuario.NOMBRE+"\nRUT: "+Modulo.usuario.RUT ,"¡Correcto!");
            activarModulos();

        }

        public void activarModulos()
        {
            switch (Modulo.usuario.NIVEL)
            {
                case 64: return; // setAdministrar();
                case 32: return; // setBodega();
                case 16: return; //setFinanzas();
                case 8: return; //setReportes();
                case 4: return; //setOperador();


            }

        }

        public void desactivarModulos()
        {
            controlDeUsuariosToolStripMenuItem.Visible = false;
            inventarioYBodegaToolStripMenuItem.Visible = false;
            requisicionToolStripMenuItem.Visible = false;
            presupuestoToolStripMenuItem.Visible = false;
            ordenesDeTrabajoToolStripMenuItem.Enabled = false;

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.MdiChildren.Contains(Modulo.login))
            {
                MessageBox.Show("Cierre todas las ventanas antes de cerrar sesion", "¡Advertencia!");
                return;
            }

            cerrarSesion();
        }
    }
}
