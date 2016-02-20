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
    public partial class AdmCatalogo : Form
    {
        public AdmCatalogo()
        {
            InitializeComponent();
            limpiarCampos();
        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NegocioProducto negP = new NegocioProducto();
            if (negP.existeProducto(this.txtCodMc.Text.Trim(), this.txtCodPrelude.Text.Trim()) == true)
            {
                MessageBox.Show(this,"¡El producto que intenta ingresar ya existe!", "Error de duplicacion");
                return;
            }

            if (this.txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre del producto", "Error, falta informacion");
                return;

            }

            if (this.txtCodMc.Text.Trim().Equals("") && this.txtCodPrelude.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Debe ingresar almenos un codigo", "Error, falta informacion");
                return;
            }
            if (this.cmbCuenta.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione la cuenta", "Error, falta informacion");
                return;
            }
            if (this.cmbProveedor.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione un proveedor", "Error, falta informacion");
                return;
            }

            if (this.cmbTipoEquip.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione un tipo de equipamiento", "Error, falta informacion");
                return;
            }

            Producto p = new Producto();
            p.NOMBRE = this.txtNombre.Text.Trim();


            p.CODIGOMC = this.txtCodMc.Text.Trim();
            p.CODIGOPRELUDE = this.txtCodPrelude.Text.Trim();

            //
            String[] numeros = this.cmbCuenta.SelectedItem.ToString().Split(' ');

            String numero = numeros[numeros.Length-1];

            String fin = numero.Split('(')[1];
            String fin2 = fin.Split(')')[0];

            //
            p.CUENTA = fin2;
            p.TIPOEQUIPAMIENTO_NOMBRE = this.cmbTipoEquip.SelectedItem.ToString();
            p.PROVEEDOR_NOMBRE = this.cmbProveedor.SelectedItem.ToString();

            negP.agregarProducto(p);

            MessageBox.Show(this, "Producto: " + p.NOMBRE + "\n¡Agregado con exito!", "¡Exito!");
            

            limpiarCampos();
        }
        private void limpiarCampos() {

            this.btnAgregar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtCodMc.Enabled = true;
            this.txtCodPrelude.Enabled = true;
            this.txtNombre.Text = "";
            this.txtCodMc.Text = "";
            this.txtCodPrelude.Text = "";
            this.cmbCuenta.SelectedIndex = 0;
            this.cmbProveedor.SelectedIndex = 0;
            this.cmbTipoEquip.SelectedIndex = 0;
            

        }

        public void cargarProducto(Producto p)
        {

            this.btnAgregar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.txtCodMc.Enabled = false;
            this.txtCodPrelude.Enabled = false;

            this.txtNombre.Text = p.NOMBRE;
            this.txtCodMc.Text = p.CODIGOMC;
            this.txtCodPrelude.Text = p.CODIGOPRELUDE;



            this.cmbCuenta.SelectedItem = p.CUENTA;


            this.cmbProveedor.SelectedItem = p.PROVEEDOR_NOMBRE;
            this.cmbTipoEquip.SelectedItem = p.TIPOEQUIPAMIENTO_NOMBRE;

        }
        private void AdmExistencia_Load(object sender, EventArgs e)
        {
            Modulo.admCatalogo = this;
            this.cargarCmb();
        }
        private void cargarCmb()
        {
            cargarProveedores();
            cargarCuentas();
            cargarTipoEquipamiento();

        }
        private void cargarProveedores()
        {
            NegocioProveedor negP = new NegocioProveedor();


            List<String> lista = negP.getListaProveedores();
            this.cmbProveedor.Items.Clear();
            this.cmbProveedor.Items.Add("Seleccione...");
            this.cmbProveedor.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbProveedor.Items.Add(ss);
            }
        }

        private void cargarCuentas()
        {

            NegocioCuenta negC = new NegocioCuenta();


            List<Cuenta> lista = negC.getListaCuentas();
            this.cmbCuenta.Items.Clear();
            this.cmbCuenta.Items.Add("Seleccione...");
            this.cmbCuenta.SelectedIndex = 0;
            foreach (Cuenta ss in lista)
            {
                this.cmbCuenta.Items.Add(ss.NOMBRE + " (" + ss.NUMERO + ")");
            }
        }

        private void cargarTipoEquipamiento()
        {

            NegocioEquipamiento negC = new NegocioEquipamiento();


            List<String> lista = negC.getListaEquipamiento();
            this.cmbTipoEquip.Items.Clear();
            this.cmbTipoEquip.Items.Add("Seleccione...");
            this.cmbTipoEquip.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbTipoEquip.Items.Add(ss);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.admCatalogo = null;
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NegocioProducto negP = new NegocioProducto();


            if (this.txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el nombre del producto", "Error, falta informacion");
                return;

            }

           
            if (this.cmbCuenta.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione la cuenta", "Error, falta informacion");
                return;
            }
            if (this.cmbProveedor.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione un proveedor", "Error, falta informacion");
                return;
            }

            if (this.cmbTipoEquip.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione un tipo de equipamiento", "Error, falta informacion");
                return;
            }

            Producto p = new Producto();
            p.NOMBRE = this.txtNombre.Text.Trim();

            p.CODIGOMC = this.txtCodMc.Text.Trim();
            p.CODIGOPRELUDE = this.txtCodPrelude.Text.Trim();

            //
            String[] numeros = this.cmbCuenta.SelectedItem.ToString().Split(' ');

            String numero = numeros[numeros.Length - 1];

            String fin = numero.Split('(')[1];
            String fin2 = fin.Split(')')[0];

            //
            p.CUENTA = fin2;
            p.TIPOEQUIPAMIENTO_NOMBRE = this.cmbTipoEquip.SelectedItem.ToString();
            p.PROVEEDOR_NOMBRE = this.cmbProveedor.SelectedItem.ToString();


            int idProd = 0;
            if (!this.txtCodMc.Text.Trim().Equals(""))
            {
               idProd= negP.getIdProductoMc(p.CODIGOMC);
            } else if (!this.txtCodPrelude.Text.Trim().Equals(""))
            {
               idProd=  negP.getIdProductoPrelude(p.CODIGOPRELUDE);
            }

            negP.modificarProducto(p,idProd);

            MessageBox.Show(this, "Producto: " + p.NOMBRE + "\n¡Modificado con exito!", "¡Exito!");
            
            limpiarCampos();
        }

        private void btnBuscarMC_Click(object sender, EventArgs e)
        {
            NegocioProducto NegP = new NegocioProducto();
            NegocioCuenta negC = new NegocioCuenta();
            Producto p = NegP.getProductoMcelroy(this.txtBuscarNombre.Text.Trim(), this.txtBuscarCodMc.Text.Trim());
            //NO encuentra uno solo , encuentra varios por lo tanto es una lista de productos no un producto


            if (NegP.existeProducto(this.txtBuscarCodMc.Text, this.txtBuscarCodPrelude.Text)==false)
            {

                MessageBox.Show(this, "No se encontraron resultados", "Error, no hay resultados");
                return;
            }
            ResultadoBusqueda rs = new ResultadoBusqueda(p,"catalogo");
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

            ResultadoBusqueda rs = new ResultadoBusqueda(p,"catalogo");
            rs.StartPosition = FormStartPosition.CenterScreen;
            rs.ShowDialog();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioProducto negP = new NegocioProducto();


            DialogResult dialogResult = MessageBox.Show(this, "¿Esta seguro que desea eliminar el Producto: \n" + this.txtNombre.Text.Trim() + "?", "Confirmar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int idProd = 0;
                if (!this.txtCodMc.Text.Trim().Equals(""))
                {
                    idProd = negP.getIdProductoMc(this.txtCodMc.Text.Trim());
                }
                else if (!this.txtCodPrelude.Text.Trim().Equals(""))
                {
                    idProd = negP.getIdProductoPrelude(this.txtCodPrelude.Text.Trim());
                }

                negP.eliminarProducto(idProd);
                MessageBox.Show(this, "Producto: " + this.txtNombre.Text.Trim() + "\n¡Eliminado con exito!", "¡Exito!");
               
                limpiarCampos();
            }


        }

        private void txtBuscarCodPrelude_TextChanged(object sender, EventArgs e)
        {
            this.txtBuscarCodMc.Text = "";
        }

        private void txtBuscarCodMc_TextChanged(object sender, EventArgs e)
        {
            this.txtBuscarCodPrelude.Text = "";
        }
    }
}
