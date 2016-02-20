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
    public partial class IngresarMuestra : Form
    {
        public IngresarMuestra()
        {
            InitializeComponent();
        }

        private void btnBuscarMC_Click(object sender, EventArgs e)
        {
            NegocioProducto NegP = new NegocioProducto();
            NegocioCuenta negC = new NegocioCuenta();
            Producto p = NegP.getProductoMcelroy(this.txtBuscarNombre.Text.Trim(), this.txtBuscarCodMc.Text.Trim());

            if (NegP.existeProducto(this.txtBuscarCodMc.Text, this.txtBuscarCodPrelude.Text)==false)
             {
                
                MessageBox.Show(this, "No se encontraron resultados", "Error, no hay resultados");
                return;
            }
            ResultadoBusqueda rs = new ResultadoBusqueda(p, "ingresarExistencia");
            rs.StartPosition = FormStartPosition.CenterScreen;
            rs.ShowDialog();
        }

        private void btnBuscarPrelude_Click(object sender, EventArgs e)
        {
            NegocioProducto NegP = new NegocioProducto();
            NegocioCuenta negC = new NegocioCuenta();
            Producto p = NegP.getProductoPrelude(this.txtBuscarNombre.Text.Trim(), this.txtBuscarCodPrelude.Text.Trim());

            if (NegP.existeProducto(this.txtBuscarCodMc.Text, this.txtBuscarCodPrelude.Text) == false)
            {

                MessageBox.Show(this, "No se encontraron resultados", "Error, no hay resultados");
                return;
            }

            ResultadoBusqueda rs = new ResultadoBusqueda(p, "ingresarExistencia");
            rs.StartPosition = FormStartPosition.CenterScreen;
            rs.ShowDialog();
        }
        private void cargarBodegaCmb()
        {
            NegocioBodega negB = new NegocioBodega();
            List<String> lista = negB.getListaBodegas();
            this.cmbBodega.Items.Clear();
            this.cmbBodega.Items.Add("Seleccione...");
            this.cmbBodega.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbBodega.Items.Add(ss);
            }
        }

        private void IngresarExistencia_Load(object sender, EventArgs e)
        {
            Modulo.ingresarMuestra = this;
            cargarBodegaCmb();

        }
        private static Producto producto;

        public void cargarProducto(Producto prod)
        {
            

            this.dgvProducto.Rows.Clear();
            this.dgvExistencias.Rows.Clear();
            this.dgvProducto.Rows.Add(prod.NOMBRE,
            prod.PROVEEDOR_NOMBRE,
            prod.TIPOEQUIPAMIENTO_NOMBRE,
            prod.CUENTA,
            prod.CODIGOMC,
            prod.CODIGOPRELUDE);

            producto = prod;

            cargarMuestras();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.ingresarMuestra= null;
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtValorUnitario.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "¡Ingrese el valor unitario!", "Error, falta informacion");
                return;
            }
            if (this.txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "¡Ingrese la cantidad!", "Error, falta informacion");
                return;
            }

            if (this.cmbBodega.SelectedIndex==0)
            {
                MessageBox.Show(this, "Seleccione la bodega", "Error, falta informacion");
                return;
            }

            NegocioMuestra negE = new NegocioMuestra();

            Muestra mu = new Muestra();

            mu.CANTIDAD = int.Parse(this.txtCantidad.Text.Trim());
            mu.VALORINGRESOCLP = int.Parse(this.txtValorUnitario.Text.Trim());
            mu.BODEGA = this.cmbBodega.SelectedItem.ToString();

            negE.agregarMuestra(producto, mu); ;

            MessageBox.Show(this, "Se añadieron: " + mu.CANTIDAD + "\n" + producto.NOMBRE + "\nA un Precio de: " + mu.VALORINGRESOCLP, "¡Exito!");
            cargarMuestras();
            this.txtCantidad.Text = "";
            this.txtValorUnitario.Text = "";

        }
        private void limpiarCampos()
        {

            producto = null;
            this.txtCantidad.Text = "";
            this.txtValorUnitario.Text = "";
            this.cmbBodega.SelectedIndex = 0;

            this.dgvExistencias.Rows.Clear();
            this.dgvProducto.Rows.Clear();
            
        }
        private void cargarMuestras()

        {
            NegocioMuestra negE = new NegocioMuestra();
            List<Muestra> lista = negE.getMuestras(producto);
            this.dgvExistencias.Rows.Clear();
            foreach (Muestra m in lista)
            {

                this.dgvExistencias.Rows.Add(m.FECHAINGRESO,m.CANTIDAD, m.VALORINGRESOCLP, (m.CANTIDAD * m.VALORINGRESOCLP) ,m.BODEGA);
                
            }
        }
        private void calcularPromedioMuestras()
        {

            List<double> valoresUnitarios = new List<double>();
            List<double> valoresTotales = new List<double>();

            foreach (DataGridViewRow d in this.dgvExistencias.Rows)
            {
                valoresUnitarios.Add(double.Parse(d.Cells[2].Value.ToString()));
                
            }
            foreach (DataGridViewRow d in this.dgvExistencias.Rows)
            {
                valoresTotales.Add(double.Parse(d.Cells[3].Value.ToString()));

            }

            NegocioMuestra negE = new NegocioMuestra();
            double promedioUnit = negE.calcularPromedio(valoresUnitarios);
            double promedioTotal = negE.calcularPromedio(valoresTotales);
            foreach (DataGridViewRow  d in this.dgvExistencias.Rows)
            {
                d.Cells[4].Value = promedioUnit;

            }
            foreach (DataGridViewRow d in this.dgvExistencias.Rows)
            {
                d.Cells[5].Value = promedioTotal;

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtBuscarCodPrelude_Enter(object sender, EventArgs e)
        {
            this.txtBuscarCodMc.Text = "";
        }

        private void txtBuscarCodMc_Enter(object sender, EventArgs e)
        {
            this.txtBuscarCodPrelude.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
