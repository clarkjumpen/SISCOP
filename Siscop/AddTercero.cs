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
    public partial class AddTercero : Form
    {
        public AddTercero()
        {
            InitializeComponent();
        }
        public AddTercero(String[] datos)
        {

            InitializeComponent();
            this.btnAgregar.Text = "Modificar";
            this.txtTarea.Text = datos[0];
            this.txtHoras.Text = datos[1];
            this.txtCantidad.Text= datos[2];
            this.txtValor.Text= datos[3];

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.btnAgregar.Text.Equals("Modificar"))
            {
                if (this.txtTarea.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el nombre de la tarea", "Error, falta informacion");

                    return;
                }

                if (this.txtHoras.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese la cantidad de horas", "Error, falta informacion");

                    return;
                }

                if (this.txtCantidad.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese la cantidad", "Error, falta informacion");

                    return;
                }

                if (this.txtValor.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el valor", "Error, falta informacion");

                    return;
                }

                String[] datosa = new String[4];

                datosa[0] = this.txtTarea.Text;
                datosa[1] = this.txtHoras.Text;
                datosa[2] = this.txtCantidad.Text;
                datosa[3] = this.txtValor.Text;


                Modulo.ingresarOrdenTrabajo.modTercero(datosa);

                this.Dispose();
            }
            if (this.btnAgregar.Text.Equals("Agregar"))
            {
                if (this.txtTarea.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el nombre de la tarea", "Error, falta informacion");

                    return;
                }

                if (this.txtHoras.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese la cantidad de horas", "Error, falta informacion");

                    return;
                }

                if (this.txtCantidad.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese la cantidad", "Error, falta informacion");

                    return;
                }

                if (this.txtValor.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el valor", "Error, falta informacion");

                    return;
                }

                String[] datossa = new String[4];

                datossa[0] = this.txtTarea.Text;
                datossa[1] = this.txtHoras.Text;
                datossa[2] = this.txtCantidad.Text;
                datossa[3] = this.txtValor.Text;


                Modulo.ingresarOrdenTrabajo.addTercero(datossa);

                this.Dispose();
            }
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddTercero_Load(object sender, EventArgs e)
        {

        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
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

