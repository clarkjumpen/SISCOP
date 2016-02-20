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
    public partial class PickEquipo : Form
    {
        public PickEquipo()
        {
            InitializeComponent();
        }

        private void PickEquipo_Load(object sender, EventArgs e)
        {
            cargarEquipos();
        }
        private void cargarEquipos() {

            this.lstEquipos.Items.Clear();
            NegocioEquipo negE = new NegocioEquipo();
            List<Equipo> lista = negE.getEquipos();

            foreach (Equipo eq in lista)
            {

                String nombre = eq.NUMEROSERIE + " " + eq.NOMBRE + " " + eq.MODELO;
                this.lstEquipos.Items.Add(nombre);
            }
          

        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            NegocioEquipo negE = new NegocioEquipo();
            Modulo.equipo = negE.getEquipo(this.lstEquipos.SelectedItem.ToString().Split(' ')[0]);
            Modulo.ingresarOrdenTrabajo.cargarEquipo();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cargarEquipos();
        }
    }
}
