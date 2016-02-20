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
    public partial class PickEncargado : Form
    {
        public PickEncargado()
        {
            InitializeComponent();
            cargarUsuarios();
        }
        private void cargarUsuarios()
        {
           
            NegocioUsuario negU = new NegocioUsuario();

            List<Usuario> usuarios = negU.getUsuarios();
            this.lstEncargados.Items.Clear();
            foreach (Usuario u in usuarios)
            {
                this.lstEncargados.Items.Add(u.RUT + ' ' + u.NOMBRE + ' ' + u.APELLIDO);
            }

        
    }

        private void PickEncargado_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.lstEncargados.SelectedItem != null)
            {
                Modulo.rutEncargado= this.lstEncargados.SelectedItem.ToString().Split(' ')[0];
            }

            Modulo.ingresarOrdenTrabajo.cargarEncargado();
            this.Dispose();
        }

        private void lstEncargados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstEncargados.SelectedItem != null)
            {
                Modulo.rutEncargado = this.lstEncargados.SelectedItem.ToString().Split(' ')[0];
            }

            Modulo.ingresarOrdenTrabajo.cargarEncargado();
            this.Dispose();
        }
    }
}
