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
    public partial class PickCliente : Form
    {
        public PickCliente()
        {
            InitializeComponent();
            cargarClientes();
        }

        private void PickCliente_Load(object sender, EventArgs e)
        {

        }

        private void cargarClientes()
        {
            NegocioCliente negU = new NegocioCliente();

            List<Cliente> clientes = negU.getClientes();
            this.lstClientes.Items.Clear();
            foreach (Cliente u in clientes)
            {
                this.lstClientes.Items.Add(u.RUT + ' ' + u.NOMBRE);
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.lstClientes.SelectedItem != null)
            {
                Modulo.rutCliente = this.lstClientes.SelectedItem.ToString().Split(' ')[0];
            }

            Modulo.ingresarOrdenTrabajo.cargarCliente();
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Modulo.Menu.cargarAdminClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (this.lstClientes.SelectedItem != null)
            {
                Modulo.rutCliente = this.lstClientes.SelectedItem.ToString().Split(' ')[0];
            }

            Modulo.ingresarOrdenTrabajo.cargarCliente();
            this.Dispose();
        }
    }
}
