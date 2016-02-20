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
    public partial class AddRepuesto : Form
    {
        public AddRepuesto()
        {
            InitializeComponent();
        }
        public AddRepuesto(String[] dato)
        {

            InitializeComponent();
            this.btnAgregar.Text = "Modificar";
            this.txtCantidad.Text = dato[2];
            this.txtPrelude.Text = dato[1];
            this.txtCodigo.Text = dato[0];
           

            this.txtCodigo.Enabled = false;
            this.txtPrelude.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NegocioMuestra negM = new NegocioMuestra();
            NegocioProducto neg = new NegocioProducto();
           if(neg.existeProducto(this.txtCodigo.Text.Trim(), this.txtPrelude.Text.Trim()) ==false) {
                MessageBox.Show(this, "no se encuentra el repuesto", "Error, falta informacion");
                return;
            }

          

            if (this.btnAgregar.Text.Equals("Modificar"))
            {
                String datosl = "";
                datosl = this.txtCantidad.Text.Trim();
               
                Modulo.ingresarOrdenTrabajo.modRepuesto(datosl);
              
                this.Dispose();
            }
            if (this.btnAgregar.Text.Equals("Agregar"))
            {

                if (this.txtCodigo.Text.Trim().Equals("") && this.txtPrelude.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese al menos un codigo", "Error, falta informacion");

                    return;
                }

                if (this.txtCantidad.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese la cantidad del repuesto", "Error, falta informacion");

                    return;
                }

                String[] datos = new String[4];
                Producto p = new Producto();
                
                if (this.txtCodigo.Text.Trim().Equals(""))
                {

                    datos[0] = "";
                    datos[1] = this.txtPrelude.Text.Trim();
                    p = neg.getProductoPrelude(this.txtPrelude.Text.Trim());
                    if (negM.hayProductoEnMuestra(p) == false)
                    {
                        MessageBox.Show(this, "No se puede agregar el repuesto, no hay existencias en inventario", "Error, falta informacion");
                        return;
                    }
                    datos[3] = negM.getValorPromedioPrelude(this.txtPrelude.Text.Trim()).ToString();
                }

                if (this.txtPrelude.Text.Trim().Equals(""))
                {
                    datos[1] = "";
                    datos[0] = this.txtCodigo.Text.Trim();
                    p = neg.getProductoMcelroy(this.txtCodigo.Text.Trim());
                    if (negM.hayProductoEnMuestra(p) == false)
                    {
                        MessageBox.Show(this, "No se puede agregar el repuesto, no hay existencias en inventario", "Error, falta informacion");
                        return;
                    }
                    datos[3] = negM.getValorPromedioMcelroy(this.txtCodigo.Text.Trim()).ToString();
                }

                datos[2] = this.txtCantidad.Text.Trim();


                Modulo.ingresarOrdenTrabajo.addRepuesto(datos, p);

                this.Dispose();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            this.txtPrelude.Text = "";
        }

        private void txtPrelude_TextChanged(object sender, EventArgs e)
        {
            this.txtCodigo.Text ="";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddRepuesto_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        
    }
}
