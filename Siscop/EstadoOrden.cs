using DataGridViewAutoFilter;
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
    public partial class EstadoOrden : Form
    {
        public EstadoOrden()
        {
            InitializeComponent();
          
        }
       
        private void EstadoOrden_Load(object sender, EventArgs e)
        {
         
            cargarOrdenes();
           // pintarOrdenes();
        }

        private void pintarOrdenes() {

            foreach(DataGridViewRow row in this.dgvOrdenes.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals("ABIERTA"))
                {
                    row.Cells[0].Style.ForeColor = Color.Green;
                }
                if (row.Cells[0].Value.ToString().Equals("CERRADA"))
                {
                    row.Cells[0].Style.ForeColor = Color.Red;
                }


            }
        }

    

        private void cargarOrdenes() {
       


           
           NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            DataTable dt = negO.getListaOrdenes();
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            this.dgvOrdenes.DataSource = bs;
            

        }

        private void dgvOrdenes_BindingContextChanged(object sender, EventArgs e)
        {
            if (dgvOrdenes.DataSource == null) return;

            foreach (DataGridViewColumn col in dgvOrdenes.Columns)
            {
                col.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
                

                String aa = col.HeaderText[0].ToString().ToUpper();
                String resto = col.HeaderText.Remove(0, 1).ToString();
                String nombre = aa + resto;
                col.HeaderText = nombre;
            }
            dgvOrdenes.AutoResizeColumns();

        }

       

       
    }
}
