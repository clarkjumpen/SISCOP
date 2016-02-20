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
    public partial class PickOrdenTrabajo : Form
    {
        public PickOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void PickOrdenTrabajo_Load(object sender, EventArgs e)
        {
            cargarTipo();
        }

        private void cargarTipo()
        {
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            
           
            List<String> lista = negO.getTipoOrdenes();
            this.cmbTipoOrden.Items.Clear();
            this.cmbTipoOrden.Items.Add("Seleccione...");
            this.cmbTipoOrden.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbTipoOrden.Items.Add(ss);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoOrden.SelectedItem.Equals("Seleccione..."))
            {
                MessageBox.Show(this, "Seleccione un tipo de orden", "Error");
                return;
            }
            
            Modulo.tipoOrden = this.cmbTipoOrden.SelectedItem.ToString().Trim();
            Modulo.Menu.pickOrden();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
