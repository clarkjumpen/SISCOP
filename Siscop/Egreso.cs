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
    public partial class Egreso : Form
    {
        public Egreso()
        {
            InitializeComponent();
        }

        private void btnBuscarMC_Click(object sender, EventArgs e)
        {
            
        }

        private void Egreso_Load(object sender, EventArgs e)
        {
            Modulo.egreso = this;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.egreso = null;
            this.Dispose();
             
        }
    }
}
