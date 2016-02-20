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
            this.inventarioYBodegaToolStripMenuItem.Visible = false;
            this.controlDeUsuariosToolStripMenuItem.Visible = false;
            this.clientesToolStripMenuItem.Visible = false;
        }

        public void egresoManual() {
            if (!this.MdiChildren.Contains(Modulo.egreso))
            {
                Egreso e = new Egreso();
                e.MdiParent = this;
                e.StartPosition = FormStartPosition.CenterScreen;
                e.Show();
            }
            else
            {
                Modulo.egreso.Focus();
            }

        }
        public void egresoOrden() {
            if (!this.MdiChildren.Contains(Modulo.egresoOrden))
            {
                EgresoOrden e = new EgresoOrden();
                e.MdiParent = this;
                e.StartPosition = FormStartPosition.CenterScreen;
                e.Show();
            }
            else
            {
                Modulo.egresoOrden.Focus();
            }

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
        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.admUsuario))
            {
                AdmUsuario admU = new AdmUsuario();
                admU.MdiParent = this;
                admU.StartPosition = FormStartPosition.CenterScreen;
                admU.Show();
            }
            else
            {
                Modulo.admUsuario.Focus();
            }
        }
        public void cerrarSesion()
        {
            Modulo.usuario = null;

            this.lblConexion.ForeColor = Color.Red;
            this.lblConexion.Text = "NO CONECTADO";
            this.lblStatusUser.Text = "";
            this.cerrarSesionToolStripMenuItem.Enabled = false;
            this.iniciarSesionToolStripMenuItem.Enabled = true;
            MessageBox.Show("Sesion cerrada correctamente", "¡Correcto!");
            desactivarModulos();
        }
        public void iniciarSesion()
        {
            this.lblConexion.ForeColor = Color.Green;
            this.lblConexion.Text = "CONECTADO COMO: ";
            this.lblStatusUser.Text = "" + Modulo.usuario.RUT;
            this.cerrarSesionToolStripMenuItem.Enabled = true;
            this.iniciarSesionToolStripMenuItem.Enabled = false;

            MessageBox.Show("¡BIENVENIDO!\nNOMBRE: " + Modulo.usuario.NOMBRE + "\nRUT: " + Modulo.usuario.RUT, "¡Correcto!");
            activarModulos();

        }

        public void activarModulos()
        {
            switch (Modulo.usuario.NIVEL)
            {
                case 64:setAdministrar();return;
                case 32: setFinanzas(); return;
                case 16: setBodega(); return;
                case 8: setOperador(); return;
                case 4: setTrabajador(); return;


            }

        }
        public void setAdministrar()
        {
            controlDeUsuariosToolStripMenuItem.Visible = true;
            inventarioYBodegaToolStripMenuItem.Visible = true;
            ordenesDeTrabajoToolStripMenuItem.Visible = true;
            clientesToolStripMenuItem.Visible = true;
        }
        public void setBodega()
        {
            inventarioYBodegaToolStripMenuItem.Visible = true;
        }

        public void setFinanzas()
        {
        }

        public void setOperador()
        {
          
        }

 
        public void setTrabajador()
        {
           
        }


        public void desactivarModulos()
        {
            controlDeUsuariosToolStripMenuItem.Visible = false;
            inventarioYBodegaToolStripMenuItem.Visible = false;
            ordenesDeTrabajoToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = false;

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Count()>0)
            {
                MessageBox.Show(this,"Cierre todas las ventanas antes de cerrar sesion", "¡Advertencia!");
                return;
            }

            cerrarSesion();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Modulo.usuario!= null)
            {
                MessageBox.Show(this, "Debe cerrar sesion antes de cerrar el programa", "¡Advertencia!");
                e.Cancel = true;
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modulo.usuario != null)
            {
                MessageBox.Show(this, "Debe cerrar sesion antes de cerrar el programa", "¡Advertencia!");
                return;
            }
            else { this.Dispose(); }
        }

        

      

        private void verCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.catalogo))
            {
                Catalogo cat = new Catalogo();
                cat.MdiParent = this;
                cat.StartPosition = FormStartPosition.CenterScreen;
                cat.Show();
            }
            else
            {
                Modulo.catalogo.Focus();
            }
        }

      
        private void administrarCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.admCatalogo))
            {
                AdmCatalogo cat =new AdmCatalogo();
                cat.MdiParent = this;
                cat.StartPosition = FormStartPosition.CenterScreen;
                cat.Show();
            }
            else
            {
                Modulo.admCatalogo.Focus();
            }
        }

        private void verBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.bodega))
            {
                Bodega bod = new Bodega();
                bod.MdiParent = this;
                bod.StartPosition = FormStartPosition.CenterScreen;
                bod.Show();
            }
            else
            {
                Modulo.bodega.Focus();
            }
        }

        private void ingresarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.ingresarMuestra))
            {
                IngresarMuestra cat = new IngresarMuestra();
                cat.MdiParent = this;
                cat.StartPosition = FormStartPosition.CenterScreen;
                cat.Show();
            }
            else
            {
                Modulo.ingresarMuestra.Focus();
            }
        }

        private void ingresarNuevaRequisicionToolStripMenuItem_Click(object sender, EventArgs e) { 
        
            if (!this.MdiChildren.Contains(Modulo.ingresarRequisicion))
            {
                IngresarRequisicion ingres = new IngresarRequisicion();
                ingres.MdiParent = this;
                ingres.StartPosition = FormStartPosition.CenterScreen;
                ingres.Show();
            }
            else
            {
                Modulo.ingresarRequisicion.Focus();
            }
        }
        public void pickOrden()
        {

            if (!this.MdiChildren.Contains(Modulo.ingresarOrdenTrabajo))
            {
                IngresarOrdenTrabajo io = new IngresarOrdenTrabajo();
                
                io.MdiParent = this;
                io.StartPosition = FormStartPosition.CenterScreen;
                io.Show();
            }
            else
            {
                Modulo.ingresarOrdenTrabajo.Focus();
            }

          
        }
        private void ingresarOrdenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PickOrdenTrabajo pick = new PickOrdenTrabajo();
         
            pick.ShowDialog();

        }
        public void cargarAdminClientes()
        {
            if (!this.MdiChildren.Contains(Modulo.admCliente))
            {
                AdmCliente adm = new AdmCliente();
                adm.MdiParent = this;
                adm.StartPosition = FormStartPosition.CenterScreen;
                adm.Show();
            }
            else
            {
                Modulo.admCliente.Focus();
            }
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cargarAdminClientes();
        }

        private void descontarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.egreso ))
            {
                Egreso des = new Egreso();
                des.MdiParent = this;
                des.StartPosition = FormStartPosition.CenterScreen;
                des.Show();
            }
            else
            {
                Modulo.egreso.Focus();
            }
        }

        private void verOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.estadoOrden))
            {
                EstadoOrden es = new EstadoOrden();
                es.MdiParent = this;
                es.StartPosition = FormStartPosition.CenterScreen;
                es.Show();
            }
            else
            {
                Modulo.egreso.Focus();
            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void ingresarActivoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarExistenciasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.ingresarMuestra))
            {
                IngresarMuestra cat = new IngresarMuestra();
                cat.MdiParent = this;
                cat.StartPosition = FormStartPosition.CenterScreen;
                cat.Show();
            }
            else
            {
                Modulo.ingresarMuestra.Focus();
            }
        }

        private void ingresarExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.ingresarMuestra))
            {
                IngresarMuestra cat = new IngresarMuestra();
                cat.MdiParent = this;
                cat.StartPosition = FormStartPosition.CenterScreen;
                cat.Show();
            }
            else
            {
                Modulo.ingresarMuestra.Focus();
            }
        }

        private void administrarCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.admCatalogo))
            {
                AdmCatalogo cat = new AdmCatalogo();
                cat.MdiParent = this;
                cat.StartPosition = FormStartPosition.CenterScreen;
                cat.Show();
            }
            else
            {
                Modulo.admCatalogo.Focus();
            }
        }

        private void verCatalogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(Modulo.catalogo))
            {
                Catalogo cat = new Catalogo();
                cat.MdiParent = this;
                cat.StartPosition = FormStartPosition.CenterScreen;
                cat.Show();
            }
            else
            {
                Modulo.catalogo.Focus();
            }
        }

        private void egresoDeExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PickEgreso eg = new PickEgreso();
            eg.ShowDialog();
        }

        private void ingresarActivoFijoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

