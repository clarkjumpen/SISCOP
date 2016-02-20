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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo.catalogo = null;
            this.Dispose();

        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            Modulo.catalogo = this;
            rellenarGrilla();
        }

        private void rellenarGrilla()
        {
            NegocioCuenta negC = new NegocioCuenta();
            NegocioProducto negP = new NegocioProducto();
            List<Producto> lista = negP.getListaTodosProductos();

            this.dgvProducto.Rows.Clear();
         
           
            foreach (Producto prod in lista) { this.dgvProducto.Rows.Add(prod.NOMBRE,prod.PROVEEDOR_NOMBRE,
                prod.TIPOEQUIPAMIENTO_NOMBRE,
                 prod.CUENTA = negC.getNombreCuenta(prod.CUENTA) + " (" + prod.CUENTA + ")",
                 prod.CODIGOMC,
                 prod.CODIGOPRELUDE);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            rellenarGrilla();
        }

        private void grpExistencias_Enter(object sender, EventArgs e)
        {

        }
    }
}
