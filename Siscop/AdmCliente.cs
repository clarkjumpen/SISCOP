using Modelo;
using Negocio;
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
    public partial class AdmCliente : Form
    {
        public AdmCliente()
        {
            InitializeComponent();
            cargarClientes();
            limpiarCampos();
        }

        private void cargarClientes()
        {
            NegocioCliente negU = new NegocioCliente();

            List<Cliente> clientes = negU.getClientes();
            this.lstClientes.Items.Clear();
            foreach (Cliente u in clientes)
            {
                this.lstClientes.Items.Add(u.RUT + ' ' + u.NOMBRE );
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.admUsuario = null;
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NegocioCliente negU = new NegocioCliente();

            if (this.txtRut.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el rut", "Error, falta informacion");
                return;
            }

            if (negU.getCliente(this.txtRut.Text.Trim()).RUT != null)
            {
                MessageBox.Show(this, "¡El cliente que intenta ingresar ya existe!", "Error de duplicacion");
                return;

            }

            if (this.txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre", "Error, falta informacion");
                return;
            }

            if (this.txtDireccion.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese la direccion", "Error, falta informacion");
                return;
            }

            if (this.txtContacto.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre del representante", "Error, falta informacion");
                return;
            }

            if (this.txtCargo.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el cargo del representante", "Error, falta informacion");
                return;
            }

            if (this.txtTelefono.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el telefono", "Error, falta informacion");
                return;
            }

            if (this.txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el email", "Error, falta informacion");
                return;
            }


            Cliente c = new Cliente();
            c.RUT = this.txtRut.Text.Trim();
            c.NOMBRE = this.txtNombre.Text.Trim();
            c.DIRECCION = this.txtDireccion.Text.Trim();
            c.CARGO = this.txtCargo.Text.Trim();
            c.CONTACTO = this.txtContacto.Text.Trim();
            c.EMAIL = this.txtEmail.Text.Trim();
            c.FONO = this.txtTelefono.Text.Trim();


            negU.agregarCliente(c);
            MessageBox.Show(this, "Cliente: " + c.NOMBRE+ " ¡Agregado con exito!", "¡Exito!");
            cargarClientes();
            limpiarCampos();
        }
        private void limpiarCampos()
        {

            this.txtRut.Enabled = true;
            this.btnAgregar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;

            this.txtRut.Text = "";
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtEmail.Text = "";
            this.txtCargo.Text = "";
            this.txtContacto.Text = "";
            this.txtDireccion.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NegocioCliente negU = new NegocioCliente();


            if (this.txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre", "Error, falta informacion");
                return;
            }

            if (this.txtDireccion.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese la direccion", "Error, falta informacion");
                return;
            }

            if (this.txtContacto.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre del representante", "Error, falta informacion");
                return;
            }

            if (this.txtCargo.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el cargo del representante", "Error, falta informacion");
                return;
            }

            if (this.txtTelefono.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el telefono", "Error, falta informacion");
                return;
            }

            if (this.txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el email", "Error, falta informacion");
                return;
            }


            Cliente c = new Cliente();
            c.RUT = this.txtRut.Text.Trim();
            c.NOMBRE = this.txtNombre.Text.Trim();
            c.DIRECCION = this.txtDireccion.Text.Trim();
            c.CARGO = this.txtCargo.Text.Trim();
            c.CONTACTO = this.txtContacto.Text.Trim();
            c.EMAIL = this.txtEmail.Text.Trim();
            c.FONO = this.txtTelefono.Text.Trim();


            negU.modificarCliente(c);

            MessageBox.Show(this, "Cliente: " + c.NOMBRE + " ¡Agregado con exito!", "¡Exito!");

            cargarClientes();
            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioCliente negU = new NegocioCliente();


            DialogResult dialogResult = MessageBox.Show(this, "¿Esta seguro que desea eliminar al cliente: \n" + this.txtRut.Text.Trim() + "?", "Confirmar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                negU.eliminarCliente(this.txtRut.Text.Trim());
                MessageBox.Show(this, "Cliente: " + this.txtRut.Text.Trim() + "\n¡Eliminado con exito!", "¡Exito!");
                cargarClientes();
                limpiarCampos();
            }
        }

        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstClientes.SelectedItem != null)
            {

                buscarCliente(this.lstClientes.SelectedItem.ToString().Split(' ')[0]);
            }
        }

        private void buscarCliente(string rut)
        {

            if (rut.Equals(""))
            {
                MessageBox.Show(this, "Ingrese el rut a buscar", "Error, falta informacion");
                return;
            }



            NegocioCliente negU = new NegocioCliente();

            Cliente u = negU.getCliente(rut);

            if (u.RUT == null)
            {
                MessageBox.Show(this, "No se encontro el cliente", "Error, no hay resultados");
                return;
            }

            this.txtRut.Text = u.RUT;
            this.txtNombre.Text = u.NOMBRE;
            this.txtTelefono.Text = u.FONO;
            this.txtEmail.Text = u.EMAIL;
            this.txtCargo.Text = u.CARGO;
            this.txtContacto.Text = u.CONTACTO;
            this.txtDireccion.Text = u.DIRECCION;

           
            this.txtRut.Enabled = false;
            this.btnAgregar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCliente(this.txtBuscarRut.Text.Trim());
        }

        private void AdmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
