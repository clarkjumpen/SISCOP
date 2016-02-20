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
    public partial class IngresarRequisicion : Form
    {
        public IngresarRequisicion()
        {
            InitializeComponent();
        }

        private void IngresarRequisicion_Load(object sender, EventArgs e)
        {
            Modulo.ingresarRequisicion = this;

            cargarUsuario();
            cargarCombos();
            limpiarCampos();
        }
        private void cargarUsuario()
        {
            this.txtIngresadaPor.Text = Modulo.usuario.NOMBRE+" "+Modulo.usuario.APELLIDO;
        }

        private void cargarNumero()
        {
            NegocioRequisicion negR = new NegocioRequisicion();
            Double numero = 0.0;
            numero = negR.getNumeroRequisicion();
            Double starter = 1;
            Double ene = (numero + starter);
    
            this.txtNumero.Text = ene.ToString();
        }
        private void cargarCombos()
        {
            cargarTipo();
            cargarEstado();
            cargarPrioridad();
        }

        private void cargarTipo()
        {
            NegocioRequisicion negR = new NegocioRequisicion();


            List<String> lista = negR.getTipos();
            this.cmbTipo.Items.Clear();
            this.cmbTipo.Items.Add("Seleccione...");
            this.cmbTipo.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbTipo.Items.Add(ss);
            }
        }

        private void cargarPrioridad()
        {
            NegocioRequisicion negR = new NegocioRequisicion();
            

            List<String> lista = negR.getPrioridades();
            this.cmbPrioridad.Items.Clear();
            this.cmbPrioridad.Items.Add("Seleccione...");
            this.cmbPrioridad.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbPrioridad.Items.Add(ss);
            }
        }

        private void cargarEstado()
        {
            NegocioRequisicion negR = new NegocioRequisicion();


            List<String> lista = negR.getEstados();
            this.cmbEstado.Items.Clear();
            this.cmbEstado.Items.Add("Seleccione...");
            this.cmbEstado.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbEstado.Items.Add(ss);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (this.txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese la descripcion de la requisicion", "Error, falta informacion");
                return;

            }

            if (this.cmbEstado.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione el estado", "Error, falta informacion");
                return;
            }
            if (this.cmbPrioridad.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione la prioridad", "Error, falta informacion");
                return;
            }
            if (this.cmbTipo.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione el tipo", "Error, falta informacion");
                return;
            }




      



        
            Requisicion r = new Requisicion();
            r.DESCRIPCION = this.txtDescripcion.Text;
            r.FECHA = DateTime.Now.Year + "//" + DateTime.Now.Month + "//" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            r.NUMERO =double.Parse(this.txtNumero.Text);
            r.PRIORIDAD = this.cmbPrioridad.SelectedItem.ToString();
            r.TIPO = this.cmbTipo.SelectedItem.ToString();
            r.ESTADO = this.cmbEstado.SelectedItem.ToString();
            r.USUARIO_RUT = Modulo.usuario.RUT;

            NegocioRequisicion negR= new NegocioRequisicion();

           negR.agregarRequisicion(r);


           MessageBox.Show(this, "Requisicion N°: " + r.NUMERO + "\n¡Agregada con exito!", "¡Exito!");
            limpiarCampos();
        }

        private void btnBuscarNumero_Click(object sender, EventArgs e)
        {
            NegocioRequisicion negR = new NegocioRequisicion();
            NegocioUsuario negU = new NegocioUsuario();
            
            if (negR.existeRequisicion(double.Parse(this.txtBuscarNumero.Text.Trim()))==false)
            {

                MessageBox.Show(this, "No se encontraron resultados", "Error, no hay resultados");
                return;
            }

            Requisicion re = negR.getRequisicion(double.Parse(this.txtBuscarNumero.Text.Trim()));

            ResultadoBusquedaRequisicion rs = new ResultadoBusquedaRequisicion(re,"num");
            rs.StartPosition=  FormStartPosition.CenterScreen;
            rs.ShowDialog();
           


        }

        public void cargarRequisicion(Requisicion re)
        {
            NegocioUsuario negU = new NegocioUsuario();

            this.txtNumero.Text = re.NUMERO.ToString();
            this.txtDescripcion.Text = re.DESCRIPCION;
            this.cmbEstado.SelectedItem = re.ESTADO;
            this.cmbTipo.SelectedItem = re.TIPO;
            this.cmbPrioridad.SelectedItem = re.PRIORIDAD;
            Usuario u = negU.getUsuario(re.USUARIO_RUT);
            this.txtIngresadaPor.Text = u.NOMBRE + " " + u.APELLIDO;

            String[] fechatiempo = re.FECHA.Split(' ');
            String[] fecha = fechatiempo[0].Split('/');
            String[] tiempo = fechatiempo[1].Split(':');
            
            int dia = int.Parse(fecha[0]);
            int mes = int.Parse(fecha[1]);
            int anho = int.Parse(fecha[2]);

            int hora = int.Parse(tiempo[0]);
            int min = int.Parse(tiempo[1]);
            int seg = int.Parse(tiempo[2]);

            
            this.dTFecha.Value = new DateTime(anho, mes, dia, hora, min, seg);

            this.btnAgregar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.dTFecha.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.ingresarRequisicion = null;
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            this.btnAgregar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;

            this.txtBuscarNumero.Text = "";
            this.txtIngresadaPor.Text = "";
            this.txtDescripcion.Text = "";
            this.txtNumero.Text = "";
            this.cmbEstado.SelectedIndex = 0;
            this.cmbTipo.SelectedIndex = 0;
            this.cmbPrioridad.SelectedIndex = 0;
            this.dTFecha.Value = DateTime.Now;
            this.dTFecha.Enabled = true;

            cargarNumero();
            cargarUsuario();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese la descripcion de la requisicion", "Error, falta informacion");
                return;

            }


            if (this.cmbEstado.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione el estado", "Error, falta informacion");
                return;
            }
            if (this.cmbPrioridad.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione la prioridad", "Error, falta informacion");
                return;
            }
            if (this.cmbTipo.SelectedIndex == 0)
            {
                MessageBox.Show(this, "Seleccione el tipo", "Error, falta informacion");
                return;
            }




            Requisicion r = new Requisicion();
            r.DESCRIPCION = this.txtDescripcion.Text;

            r.FECHA = DateTime.Now.Year + "//" + DateTime.Now.Month + "//" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" +DateTime.Now.Minute + ":" + DateTime.Now.Second;
            r.NUMERO = double.Parse(this.txtNumero.Text);
            r.PRIORIDAD = this.cmbPrioridad.SelectedItem.ToString();
            r.TIPO = this.cmbTipo.SelectedItem.ToString();
            r.ESTADO = this.cmbEstado.SelectedItem.ToString();
            r.USUARIO_RUT = Modulo.usuario.RUT;

            NegocioRequisicion negR = new NegocioRequisicion();

            negR.modificarRequisicion(r);


            MessageBox.Show(this, "Requisicion N°: " + r.NUMERO + "\n¡Modificada con exito!", "¡Exito!");
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioRequisicion negP = new NegocioRequisicion();


            DialogResult dialogResult = MessageBox.Show(this, "¿Esta seguro que desea eliminar la requisicion N°: \n" + this.txtNumero.Text.Trim() + "?", "Confirmar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                negP.eliminarRequisicion(double.Parse(this.txtNumero.Text.Trim()));
                MessageBox.Show(this, "requisicion: " + this.txtNumero.Text.Trim() + "\n¡Eliminada con exito!", "¡Exito!");

                limpiarCampos();
            }
        }
    }
}
