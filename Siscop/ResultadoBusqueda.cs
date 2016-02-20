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
    public partial class ResultadoBusqueda : Form
    {
        public ResultadoBusqueda()
        {
            InitializeComponent();
        }

        public ResultadoBusqueda(Producto p)
        {
            InitializeComponent();
            this.prod = p;
            rellenarGrilla();
            this.tipoBusqueda = "";
               
        }

        public ResultadoBusqueda(Producto p,String e)
        {
            InitializeComponent();
            this.prod = p;
            rellenarGrilla();
            this.tipoBusqueda = e;
        }
        private Producto prod;

        private String tipoBusqueda = "";

        private void ResultadoBusqueda_Load(object sender, EventArgs e)
        {
        
        }

        private void rellenarGrilla()
        {


            //this.dgvProducto.Rows.Insert
            NegocioCuenta negC = new NegocioCuenta();
            prod.CUENTA = negC.getNombreCuenta(prod.CUENTA) + " (" + prod.CUENTA + ")";


            this.dgvProducto.Rows.Add(prod.NOMBRE,
            prod.PROVEEDOR_NOMBRE,
            prod.TIPOEQUIPAMIENTO_NOMBRE,
            prod.CUENTA,
            prod.CODIGOMC,
            prod.CODIGOPRELUDE);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.tipoBusqueda.Equals("ingresarExistencia"))
            {
                Modulo.ingresarMuestra.cargarProducto(prod);
                 this.Dispose();
            }
            if (this.tipoBusqueda.Equals("catalogo"))
            {
                Modulo.admCatalogo.cargarProducto(prod);
                this.Dispose();
            }
            
        }
    }
}
