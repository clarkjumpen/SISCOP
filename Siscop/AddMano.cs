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
    public partial class AddMano : Form
    {
        public AddMano()
        {
            InitializeComponent();
        }

        public AddMano(String[] datos)
        {
            
            InitializeComponent();
            this.btnAgregar.Text = "Modificar";
            this.txtTarea.Text = datos[0];
            this.txtHoras.Text = datos[1];

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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


                String[] datosa = new String[2];

                datosa[0] = this.txtTarea.Text;
                datosa[1] = this.txtHoras.Text;


                Modulo.ingresarOrdenTrabajo.modMano(datosa);

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


                String[] datos = new String[2];

                datos[0] = this.txtTarea.Text;
                datos[1] = this.txtHoras.Text;


                Modulo.ingresarOrdenTrabajo.addMano(datos);


                this.Dispose();
            }
        }

        private void AddMano_Load(object sender, EventArgs e)
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

    

