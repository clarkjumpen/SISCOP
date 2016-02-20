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
    public partial class PickEgreso : Form
    {
        public PickEgreso()
        {
            InitializeComponent();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.cmbClase.SelectedIndex==0)
            {
                MessageBox.Show(this, "Seleccione la clase de egreso", "Error!");
                return;
            }
            if (this.cmbClase.SelectedItem.ToString().Trim().Equals("Egreso desde una Orden"))
            {
                Modulo.Menu.egresoOrden();
            }
            if (this.cmbClase.SelectedItem.ToString().Trim().Equals("Egreso Manual"))
            {
                Modulo.Menu.egresoManual();
            }

            this.Dispose();
        }

        private void PickEgreso_Load(object sender, EventArgs e)
        {
            this.cmbClase.SelectedIndex = 0;
        }
    }
}
