using Modelo;
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

namespace Siscop
{
    public partial class AdmUsuario : Form
    {
        public AdmUsuario()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        private void AdmUsuario_Load(object sender, EventArgs e)
        {
            Modulo.admUsuario = this;
            limpiarCampos();
            
        }
        private void cargarUsuarios()
        {
            NegocioUsuario negU = new NegocioUsuario();

            List<Usuario> usuarios = negU.getUsuarios();
            this.lstUsuarios.Items.Clear();
            foreach (Usuario u in usuarios)
            {
                this.lstUsuarios.Items.Add(u.RUT+ ' ' + u.NOMBRE+' '+u.APELLIDO);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.admUsuario = null;
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NegocioUsuario negU = new NegocioUsuario();

            if (negU.getUsuario(this.txtRut.Text.Trim()).RUT != null)
            {
                MessageBox.Show(this, "¡El usuario que intenta ingresar ya existe!", "Error de duplicacion");
                return;

            }
            if (this.txtRut.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el rut", "Error, falta informacion");
                return;
            }

            if (this.txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre", "Error, falta informacion");
                return;
            }

            if (this.txtApellido.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el apellido", "Error, falta informacion");
                return;
            }

            if (this.rdAdministrador.Checked == false && this.rdBodeguero.Checked == false && this.rdFinanzas.Checked == false && this.rdOperador.Checked == false && this.rdTrabajador.Checked == false)
            {
                MessageBox.Show(this, "Seleccione un nivel de autorizacion", "Error, falta informacion");
                return;
            }


            Usuario u = new Usuario();
            u.RUT = this.txtRut.Text.Trim();
            u.APELLIDO = this.txtApellido.Text.Trim();
            u.NOMBRE = this.txtNombre.Text.Trim();

            int suma = 0;

            if (this.rdAdministrador.Checked == true)
            {
                suma = 64;
            }
            if (this.rdFinanzas.Checked == true)
            {
                suma = 32;
            }
            if (this.rdBodeguero.Checked == true)
            {
                suma =  16;
            }
            if (this.rdOperador.Checked == true)
            {
                suma =  8;
            }
            if (this.rdTrabajador.Checked == true)
            {
                suma =  4;
            }

            u.NIVEL = suma;

            u.CLAVE = this.txtClave.Text.Trim();
            

            if (this.chkBloqueado.Checked == true)
            {
                u.BLOQUEADO = true;
            }
            if (this.chkBloqueado.Checked == false)
            {
                u.BLOQUEADO = false;
            }


            negU.agregarUsuario(u);
            MessageBox.Show(this, "Usuario: " + u.RUT + "\n¡Agregado con exito!", "¡Exito!");
            cargarUsuarios();
            limpiarCampos();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarUsuario(this.txtBuscarRut.Text.Trim());


        }
        private void buscarUsuario(string rut)
        {

            if(rut.Equals(""))
            {
                MessageBox.Show(this, "Ingrese el rut a buscar", "Error, falta informacion");
                return;
            }



            NegocioUsuario negU = new NegocioUsuario();

            Usuario u = negU.getUsuario(rut);

            if (u.RUT == null)
            {
                MessageBox.Show(this, "No se encontro el usuario", "Error, no hay resultados");
                return;
            }

            this.txtRut.Text = u.RUT;
            this.txtNombre.Text = u.NOMBRE;
            this.txtApellido.Text = u.APELLIDO;

            if (u.NIVEL == 64)
            {
                this.rdAdministrador.Checked = true;
            }
            if (u.NIVEL == 32)
            {
                this.rdFinanzas.Checked = true;
            }
            if (u.NIVEL == 16)
            {
                this.rdBodeguero.Checked = true;
            }
            if (u.NIVEL == 8)
            {
                this.rdOperador.Checked = true;
            }
            if (u.NIVEL == 4)
            {
                this.rdTrabajador.Checked = true;
            }

            if (u.BLOQUEADO == true)
            {
                this.chkBloqueado.Checked = true;
            }
            this.txtClave.Enabled = false;
            this.btnCambiarClave.Enabled = true;
            this.txtRut.Enabled = false;
            this.btnAgregar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }
        private void lstUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstUsuarios.SelectedItem != null)
            {

                buscarUsuario(this.lstUsuarios.SelectedItem.ToString().Split(' ')[0]);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             limpiarCampos();
        }

        private void limpiarCampos(){

            this.txtBuscarRut.Text = "";
            this.txtRut.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";

            this.rdAdministrador.Checked = false;
            this.rdFinanzas.Checked = false;
            this.rdBodeguero.Checked = false;
            this.rdOperador.Checked = false;
            this.rdTrabajador.Checked = false;

            this.chkBloqueado.Checked = false;

            this.txtClave.Text = "";

            this.txtRut.Enabled = true;

            this.btnAgregar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.lstUsuarios.SelectedItem = null;
            this.btnCambiarClave.Enabled = false;
            this.txtClave.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NegocioUsuario negU = new NegocioUsuario();

           if(this.chkBloqueado.Checked == true && Modulo.usuario.RUT.Equals(this.txtRut.Text))
            {
                MessageBox.Show(this, "No se puede bloquear el usuario con el que se inicio la sesion ", "Error, denegado");
                return;
            }

            if (this.txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre", "Error, falta informacion");
                return;
            }

            if (this.txtApellido.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el apellido", "Error, falta informacion");
                return;
            }

            if (this.rdAdministrador.Checked == false && this.rdBodeguero.Checked == false && this.rdFinanzas.Checked == false && this.rdOperador.Checked == false && this.rdTrabajador.Checked == false)
            {
                MessageBox.Show(this, "Seleccione un nivel de autorizacion", "Error, falta informacion");
                return;
            }


            Usuario u = new Usuario();
            u.RUT = this.txtRut.Text.Trim();
            u.APELLIDO = this.txtApellido.Text.Trim();
            u.NOMBRE = this.txtNombre.Text.Trim();

            int suma = 0;

            if (this.rdAdministrador.Checked == true)
            {
                suma = 64;
            }
            if (this.rdFinanzas.Checked == true)
            {
                suma = 32;
            }
            if (this.rdBodeguero.Checked == true)
            {
                suma = 16;
            }
            if (this.rdOperador.Checked == true)
            {
                suma = 8;
            }
            if (this.rdTrabajador.Checked == true)
            {
                suma = 4;
            }

            u.NIVEL = suma;

            u.CLAVE = this.txtClave.Text.Trim();


            if (this.chkBloqueado.Checked == true)
            {
                u.BLOQUEADO = true;
            }
            if (this.chkBloqueado.Checked == false)
            {
                u.BLOQUEADO = false;
            }

            if (this.txtClave.Text.Trim().Equals(""))
            {
                negU.modificarUsuario(u);
            }
            else
            {
                negU.modificarUsuarioClave(u);

            }

            MessageBox.Show(this, "Usuario: " + u.RUT + "\n¡Modificado con exito!", "¡Exito!");
            cargarUsuarios();
            limpiarCampos();

        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Se ha habilitado el campo de clave\nutilice el boton modificar para guardar los cambios","¡Advertencia!");
            this.txtClave.Enabled = true;
            this.btnCambiarClave.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioUsuario negU = new NegocioUsuario();
           

            DialogResult dialogResult = MessageBox.Show(this,"¿Esta seguro que desea eliminar al usuario: \n"+this.txtRut.Text.Trim()+"?", "Confirmar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                negU.eliminarUsuario(this.txtRut.Text.Trim());
                MessageBox.Show(this, "Usuario: " + this.txtRut.Text.Trim() + "\n¡Eliminado con exito!", "¡Exito!");
                cargarUsuarios();
                limpiarCampos();
            }
        

           
        }
    }
}
