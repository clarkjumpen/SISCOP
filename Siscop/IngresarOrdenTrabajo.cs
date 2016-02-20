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
using System.IO;
using System.Text.RegularExpressions;

namespace Siscop
{
    public partial class IngresarOrdenTrabajo : Form
    {
        public IngresarOrdenTrabajo()
        {
            InitializeComponent();
            Modulo.ingresarOrdenTrabajo = this;
            this.MdiParent = Modulo.Menu;
            limpiarCampos();
           
    }
       

        private void cargarCombos()
        {
            cargarPrioridad();
            cargarCategoria();
            cargarEstado();

        }
        private void cargarCategoria()
        {
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();


            List<String> lista = negO.getCategorias(Modulo.tipoOrden);
            this.cmbCategoria.Items.Clear();
            this.cmbCategoria.Items.Add("Seleccione...");
            this.cmbCategoria.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbCategoria.Items.Add(ss);
            }
        }
        private void cargarEstado()
        {
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();


            List<String> lista = negO.getEstados();
            this.cmbEstado.Items.Clear();
            this.cmbEstado.Items.Add("Seleccione...");
            this.cmbEstado.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbEstado.Items.Add(ss);
            }
        }

        private void cargarPrioridad()
        {
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();


            List<String> lista = negO.getPrioridades();
            this.cmbPrioridad.Items.Clear();
            this.cmbPrioridad.Items.Add("Seleccione...");
            this.cmbPrioridad.SelectedIndex = 0;
            foreach (String ss in lista)
            {
                this.cmbPrioridad.Items.Add(ss);
            }
        }
        public void cargarCliente()
        {
            NegocioCliente negC = new NegocioCliente();
            Cliente c = negC.getCliente(Modulo.rutCliente);


            this.txtClienteNombre.Text = c.NOMBRE;


        }

        public void cargarEncargado()
        {
            NegocioUsuario negU = new NegocioUsuario();
            Usuario c = negU.getUsuario(Modulo.rutEncargado);

            this.txtEncargado.Text = c.NOMBRE + " " + c.APELLIDO;

        }


        private void IngresarOrdenTrabajo_Load(object sender, EventArgs e)
        {
            cargarCombos();
            mostrar();
           
        }
        


        public void mostrar()
        {
          
            if (Modulo.tipoOrden.Equals("SERVICIO"))
            {
                this.tabDetalle.TabPages.RemoveAt(0);
                this.Text = this.Text + " - SERVICIO";            

            }
            if (Modulo.tipoOrden.Equals("EQUIPO"))
            {
              
                this.Text = this.Text + " - EQUIPO";

            }
            
        }

        private void limpiarCampos() { 
        
            this.tabDetalle.Enabled =false;
            

            this.listaImagenes.Clear();
            this.listaRepuestos.Clear();

            this.cmbPrioridad.SelectedIndex = 0;
            this.cmbEstado.SelectedIndex = 0;
            this.cmbCategoria.SelectedIndex = 0;

            this.btnGuardar.Enabled = false;
            this.btnAgregar.Enabled = true;
            this.btnCalcular.Enabled = false;

            this.btnSolicitar.Enabled = false;
            this.btnCancelSol.Enabled = false;

            this.dgvMano.Rows.Clear();
            this.dgvRepuestos.Rows.Clear();
            this.dgvResumen.Rows.Clear();
            this.dgvTrabajo.Rows.Clear();

            this.dTFechaInicio.Value = DateTime.Now;
            this.dTFechaInicio.Enabled = true;

            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            this.txtNumero.Text = "";
            this.cargarUsuario();
            this.cargarNumeroOrden();

            this.btnModificarMano.Enabled = false;
            this.btnEliminarMano.Enabled = false;
            this.btnModificarTercero.Enabled = false;
            this.btnEliminarTercero.Enabled = false;
            this.btnAgregarRepuesto.Enabled = false;
            this.btnModificarRepuesto.Enabled = false;
            this.btnEliminarRepuesto.Enabled = false;
            this.txtValorDolar.Enabled = true;

            this.txtValorDolar.Text = "0";
            this.txtEncargado.Text = "";
            this.txtClienteNombre.Text = "";
            this.txtEquipo.Text = "";
            this.txtModelo.Text = "";
            this.txtCodigo.Text = "";
            this.txtNSerie.Text = "";
            this.txtPitbull.Text = "";
            this.txtHorometro.Text = "";
            this.txtAno.Text = "";
            this.pickImagen.Image = null;
            this.lstImg.Items.Clear();
            this.txtDescripcion.Text = "";
            this.txtImagen.Text = "";



            this.dgvPendientes.Rows.Clear();
            this.dgvSolicitados.Rows.Clear();
            this.dgvEntregados.Rows.Clear();

            this.txtNSerie.Enabled = true;

        }

        private void cargarUsuario()
        {
            this.txtIngresadaPor.Text = Modulo.usuario.NOMBRE + " " + Modulo.usuario.APELLIDO;
        }
        private void cargarNumeroOrden()
        {
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            Double numero = 0.0;
            numero = negO.getNumeroOrden();
            Double starter = 1;
            Double ene = (numero + starter);

            this.txtNumero.Text = ene.ToString();
        }
        private String cargarNumeroSolicitud()
        {
            NegocioSolicitud negO = new NegocioSolicitud();
            Double numero = 0.0;
            numero = negO.getLastIdSolicitud();
            Double starter = 1;
            Double ene = (numero + starter);
            return ene.ToString();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.ingresarOrdenTrabajo = null;
            this.Dispose();
        }
        private Equipo eq = new Equipo();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtClienteNombre.Text.Trim().Equals(""))
            {

                MessageBox.Show(this, "Seleccione un cliente desde el boton", "Error, falta informacion");
                this.btnCliente.Focus();
                return;
            }
            if (this.txtEncargado.Text.Trim().Equals(""))
            {

                MessageBox.Show(this, "Seleccione un encargado desde el boton", "Error, falta informacion");
                this.btnCliente.Focus();
                return;
            }
            if (this.cmbPrioridad.SelectedItem.Equals("Seleccione..."))
            {
                MessageBox.Show(this, "Seleccione la prioridad", "Error, falta informacion");
                return;
            }
            if (this.cmbEstado.SelectedItem.Equals("Seleccione..."))
            {
                MessageBox.Show(this, "Seleccione el estado de la orden", "Error, falta informacion");
                return;
            }
            if (this.cmbCategoria.SelectedItem.Equals("Seleccione..."))
            {
                MessageBox.Show(this, "Seleccione la categoria", "Error, falta informacion");
                return;
            }
            if (this.txtValorDolar.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el valor del dolar", "Error, falta informacion");
                return;
            }




            NegocioUsuario negU = new NegocioUsuario();

            Orden p = new Orden();
            p.ENCARGADO = this.txtEncargado.Text.Split(' ')[0];
            p.CLIENTE = Modulo.rutCliente;
            p.USUARIO_RUT = Modulo.usuario.RUT;
            p.NUMERO = this.txtNumero.Text.Trim();
            p.FECHAINICIO = DateTime.Now.Year + "//" + DateTime.Now.Month + "//" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            p.FECHATERMINO = this.dTFechaTermino.Value.ToString();
            p.ESTADOORDENTRABAJO = this.cmbEstado.SelectedItem.ToString();
            p.CATEGORIA = this.cmbCategoria.SelectedItem.ToString();
            p.PRIORIDAD = this.cmbPrioridad.SelectedItem.ToString();
            p.VALORDOLAR = Double.Parse(this.txtValorDolar.Text.ToString());
            p.VALORTOTALCLP = Double.Parse(this.txtTotalClp.Text.ToString());
            p.VALORTOTALUSD = Double.Parse(this.txtTotalUsd.Text.ToString());
            p.TIPOORDENTRABAJO = Modulo.tipoOrden;
            //p.EQUIPO = this.txtNSerie.Text.Trim();
            // p.MANODEOBRA = this.encriptarMano();
            //  p.TRABAJOTERCEROS = this.encriptarTrabajoTerceros();
            //this.encriptarRepuestos();


            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            NegocioSolicitud negS = new NegocioSolicitud();


            Solicitud s = new Solicitud();
            s.FECHA = DateTime.Now.Year + "//" + DateTime.Now.Month + "//" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            s.ORDENTRABAJO_NUMERO = p.NUMERO;
            s.USUARIO_RUT = Modulo.usuario.RUT;
            s.NUMERO = cargarNumeroSolicitud();

            // NegocioEquipo negEq = new NegocioEquipo();
            //negEq.agregarEquipo(eq);

            negO.agregarOrden(p);

            NegocioImagen negI = new NegocioImagen();
            foreach (ImagenOrden img in this.listaImagenes)
            {
                negI.agregarImagen(img);
            }

            negS.agregarSolicitud(s);



            this.cargarOrden(this.txtNumero.Text.Trim());
           
        }

        public String encriptarMano()
        {

            String mano = "";
            foreach (DataGridViewRow d in this.dgvMano.Rows)
            {
                mano = mano + d.Cells[0].Value + "/r" + d.Cells[1].Value + "/n";

            }
            return mano;
        }

        public void cargarManoObra(String datos)
        {



            List<String[]> rows = new List<String[]>();
            String[] lista = Regex.Split(datos, "/n");

            foreach (String s in lista)
            {
                if (s.Equals(""))
                {
                    return;
                }
                String[] dato3 = Regex.Split(s, "/r");

                Object[] ob = new Object[2];
                ob[0] = dato3[0];
                ob[1] = dato3[1];
                this.dgvMano.Rows.Add(ob);
            }
        }

        public void cargarTrabajoTerceros(String datos)
        {



            List<String[]> rows = new List<String[]>();
            String[] lista = Regex.Split(datos, "/n");

            foreach (String s in lista)
            {
                if (s.Equals(""))
                {
                    return;
                }
                String[] dato3 = Regex.Split(s, "/r");

                Object[] ob = new Object[5];
                ob[0] = dato3[0];
                ob[1] = dato3[1];
                ob[2] = dato3[2];
                ob[3] = dato3[3];
                ob[4] = dato3[4];
                this.dgvTrabajo.Rows.Add(ob);
            }
        }



        public String encriptarTrabajoTerceros()
        {

            String mano = "";
            foreach (DataGridViewRow d in this.dgvTrabajo.Rows)
            {
                mano = mano + d.Cells[0].Value + "/r" + d.Cells[1].Value + "/r" + d.Cells[2].Value + "/r" + d.Cells[3].Value + "/r" + d.Cells[4].Value + "/n";

            }
            return mano;
        }
        private List<Repuesto> listaRepuestos = new List<Repuesto>();
        private List<Solicitud> listaSolicitudes = new List<Solicitud>();

        public void encriptarRepuestos()
        {

            listaRepuestos.Clear();

            Repuesto r = new Repuesto();
            foreach (DataGridViewRow d in this.dgvRepuestos.Rows)
            {
                r.CANTIDAD = int.Parse(d.Cells[3].Value.ToString());
                r.CODIGO = d.Cells[0].Value.ToString();
                r.CODIGOPRELUDE = d.Cells[1].Value.ToString();
                r.DESCRIPCION = d.Cells[2].Value.ToString();
                r.VALORCLP = Double.Parse(d.Cells[4].Value.ToString());


                listaRepuestos.Add(r);
            }


        }



        private void btnCliente_Click(object sender, EventArgs e)
        {
            PickCliente pc = new PickCliente();
            pc.ShowDialog();
        }




        private List<ImagenOrden> listaImagenes = new List<ImagenOrden>();



        private void btnEncargado_Click(object sender, EventArgs e)
        {
            PickEncargado pe = new PickEncargado();
            pe.ShowDialog();
        }

        private void lstImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstImg.Items.Count > 0)
            {
                cargarImagen();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstImg.SetSelected(this.lstImg.SelectedIndex + 1, true);
            }
            catch (Exception es) { }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstImg.SetSelected(this.lstImg.SelectedIndex - 1, true);

            }
            catch (Exception ge) { }
        }

        private String ubicacion = "";
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            Open.Title = "Abrir";
            Open.Filter = "Image Files(*.bmp, *.jpg, *.jpeg) | *.bmp; *.jpg;*.jpeg|All Files (*.*)|*.*";

            if (Open.ShowDialog() == DialogResult.OK)
            {

                ubicacion = Open.FileName;
                this.txtImagen.Text = Open.SafeFileName;
                Image Picture = new Bitmap(ubicacion);
                pickImagen.Image = Picture;
                this.btnGuardarImagen.Enabled = true;
            }
        }
        private void cargarImagen()
        {
            this.btnEliminarImagen.Enabled = true;
            this.btnRight.Enabled = true;
            this.btnLeft.Enabled = true;
            ImagenOrden imagenSelec = new ImagenOrden();
            imagenSelec = this.listaImagenes.ElementAt(this.lstImg.SelectedIndex);
            NegocioImagen negI = new NegocioImagen();
            Image Picture = negI.Bytes2Imagen(imagenSelec.IMAGEN);
            pickImagen.Image = Picture;
            this.txtImagen.Text = imagenSelec.NOMBREARCHIVO;
            this.txtDescripcion.Text = imagenSelec.DESCRIPCION;
        }
        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            NegocioImagen negI = new NegocioImagen();

            ImagenOrden img = new ImagenOrden();
            img.IMAGEN = negI.Image2Bytes(this.pickImagen.Image);
            img.DESCRIPCION = this.txtDescripcion.Text;
            img.NUMEROORDEN = this.txtNumero.Text;
            img.NOMBREARCHIVO = this.txtImagen.Text;

            listaImagenes.Add(img);

            this.ubicacion = "";


            this.txtImagen.Text = "";
            this.txtDescripcion.Text = "";
            this.btnGuardarImagen.Enabled = false;

            cargarListaImagenes();
        }

        private void cargarListaImagenes()
        {
            this.lstImg.Items.Clear();
            foreach (ImagenOrden img in this.listaImagenes)
            {

                this.lstImg.Items.Add(img.NOMBREARCHIVO);

            }
            if (this.lstImg.Items.Count == 0)
            {
                this.btnRight.Enabled = false;
                this.btnLeft.Enabled = false;
                this.btnEliminarImagen.Enabled = false;
                this.pickImagen.Image = null;
                this.txtImagen.Text = "";
            }
            else { this.lstImg.SelectedIndex = 0; }

        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            ImagenOrden imagenSelec = new ImagenOrden();
            imagenSelec = this.listaImagenes.ElementAt(this.lstImg.SelectedIndex);
            this.listaImagenes.Remove(imagenSelec);
            cargarListaImagenes();


        }

        private void dgvMano_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            string headerText = dgvMano.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the CompanyName column.
            if (!headerText.Equals("Horas")) return;

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgvPendientes.Rows[e.RowIndex].ErrorText =
                    "Company Name must not be empty";
                e.Cancel = true;

            }
        }

        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValorDolar_Click(object sender, EventArgs e)
        {


        }

        private void btnAgregarMano_Click(object sender, EventArgs e)
        {
            AddMano add = new AddMano();
            add.ShowDialog(this);
        }
        public void addTercero(String[] datos)
        {

            Object[] a = new Object[5];
            a[0] = datos[0].ToString();
            a[1] = datos[1].ToString();
            a[2] = datos[2].ToString();
            a[3] = datos[3].ToString();

            Double total = Double.Parse(datos[3].ToString()) * Double.Parse(datos[2].ToString());
            a[4] = "" + total;

            dgvTrabajo.Rows.Add(a);
            this.btnEliminarTercero.Enabled = true;
            this.btnModificarTercero.Enabled = true;
        }
        public void modTercero(String[] datos)
        {

            dgvTrabajo.SelectedRows[0].Cells[0].Value = (String)datos[0];
            dgvTrabajo.SelectedRows[0].Cells[1].Value = (String)datos[1];
            dgvTrabajo.SelectedRows[0].Cells[2].Value = (String)datos[2];
            dgvTrabajo.SelectedRows[0].Cells[3].Value = (String)datos[3];
            Double total = Double.Parse(dgvTrabajo.SelectedRows[0].Cells[2].Value.ToString()) * Double.Parse(dgvTrabajo.SelectedRows[0].Cells[3].Value.ToString());
            dgvTrabajo.SelectedRows[0].Cells[4].Value = total.ToString();
        }
        public void addMano(String[] datos)
        {

            Object[] a = new Object[2];
            a[0] = datos[0].ToString();
            a[1] = datos[1].ToString();

            dgvMano.Rows.Add(a);
            this.btnEliminarMano.Enabled = true;
            this.btnModificarMano.Enabled = true;
        }
        public void modMano(String[] datos)
        {

            dgvMano.SelectedRows[0].Cells[0].Value = (String)datos[0];
            dgvMano.SelectedRows[0].Cells[1].Value = (String)datos[1];
        }

        public void addRepuesto(String[] datos, Producto p)
        {


            Object[] a = new Object[7];
            a[0] = datos[0].ToString();
            a[1] = datos[1].ToString();
            a[2] = p.NOMBRE;
            a[3] = datos[2].ToString();
            a[4] = datos[3].ToString();
            Double total = Double.Parse(datos[2]) * Double.Parse(datos[3]);
            a[5] = total.ToString();

            Double totalUsd = total / Double.Parse(this.txtValorDolar.Text.Trim());

            a[6] = totalUsd;

            Object[] s = new Object[4];

            s[0] = a[0];
            s[1] = a[1];
            s[2] = a[2];
            s[3] = a[3];

            Repuesto r = new Repuesto();
            r.CODIGO = a[0].ToString();
            r.CODIGOPRELUDE = a[1].ToString();
            r.DESCRIPCION = a[2].ToString();
            r.CANTIDAD = int.Parse(a[3].ToString());
            r.VALORCLP = Double.Parse(a[4].ToString());
            r.ESTADO = "PENDIENTE";

            foreach (Repuesto rr in this.listaRepuestos)
            {
                if (rr.CODIGO.Equals(r.CODIGO) && rr.CODIGOPRELUDE.Equals(r.CODIGOPRELUDE))
                {
                    MessageBox.Show(this, "El producto ya se encuentra en la lista, utilice la opcion modificar", "Error");
                    return;
                }
            }
            NegocioSolicitud negS = new NegocioSolicitud();
            Double numero = negS.getNumeroOrdendeSolicitud(this.txtNumero.Text.Trim());

            r.SOLICITUD = numero.ToString();
            this.listaRepuestos.Add(r);


            dgvPendientes.Rows.Add(s);
            dgvRepuestos.Rows.Add(a);




            this.btnEliminarRepuesto.Enabled = true;
            this.btnModificarRepuesto.Enabled = true;
        }


        public void modRepuesto(String datos)
        {




            dgvRepuestos.SelectedRows[0].Cells[3].Value = (String)datos;

            Double total = Double.Parse(dgvRepuestos.SelectedRows[0].Cells[3].Value.ToString()) * Double.Parse(dgvRepuestos.SelectedRows[0].Cells[4].Value.ToString());
            dgvRepuestos.SelectedRows[0].Cells[5].Value = "" + total;

            Double totalDolar = Double.Parse(dgvRepuestos.SelectedRows[0].Cells[5].Value.ToString()) / Double.Parse(this.txtValorDolar.Text.Trim());

            dgvRepuestos.SelectedRows[0].Cells[6].Value = "" + totalDolar;


            String codigo = this.dgvRepuestos.SelectedRows[0].Cells[0].Value.ToString();
            String prelude = this.dgvRepuestos.SelectedRows[0].Cells[1].Value.ToString();
            foreach (DataGridViewRow row in this.dgvPendientes.Rows)
            {
                if (codigo.Equals(row.Cells[0].Value) || prelude.Equals(row.Cells[1].Value))
                {
                    row.Cells[3].Value = "" + datos;
                }
            }

            foreach (DataGridViewRow row in this.dgvSolicitados.Rows)
            {
                if (codigo.Equals(row.Cells[0].Value) || prelude.Equals(row.Cells[1].Value))
                {
                    row.Cells[3].Value = "" + datos;


                }
            }

            foreach (Repuesto r in this.listaRepuestos)
            {
                if (codigo.Equals(r.CODIGO) || prelude.Equals(r.CODIGOPRELUDE))
                {
                    r.CANTIDAD = int.Parse(datos);


                }
            }
        }






        private void btnModificarMano_Click(object sender, EventArgs e)
        {



            String[] datos = new String[2];

            datos[0] = (String)dgvMano.SelectedRows[0].Cells[0].Value;
            datos[1] = (String)dgvMano.SelectedRows[0].Cells[1].Value;
            AddMano add = new AddMano(datos);
            add.ShowDialog(this);


        }

        private void btnEliminarMano_Click(object sender, EventArgs e)
        {
            this.dgvMano.Rows.Remove(this.dgvMano.SelectedRows[0]);
            if (this.dgvMano.Rows.Count <= 0)
            {
                this.btnEliminarMano.Enabled = false;
                this.btnModificarMano.Enabled = false;
            }
        }

        private void btnModificarTercero_Click(object sender, EventArgs e)
        {
            String[] datos = new String[4];

            datos[0] = (String)dgvTrabajo.SelectedRows[0].Cells[0].Value;
            datos[1] = (String)dgvTrabajo.SelectedRows[0].Cells[1].Value;
            datos[2] = (String)dgvTrabajo.SelectedRows[0].Cells[2].Value;
            datos[3] = (String)dgvTrabajo.SelectedRows[0].Cells[3].Value;
            AddTercero add = new AddTercero(datos);
            add.ShowDialog(this);
        }

        private void btnAgregarTercero_Click(object sender, EventArgs e)
        {
            AddTercero add = new AddTercero();
            add.ShowDialog(this);
        }

        private void btnEliminarTercero_Click(object sender, EventArgs e)
        {
            this.dgvTrabajo.Rows.Remove(this.dgvTrabajo.SelectedRows[0]);
            if (this.dgvTrabajo.Rows.Count <= 0)
            {
                this.btnEliminarTercero.Enabled = false;
                this.btnModificarTercero.Enabled = false;
            }
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {

            AddRepuesto add = new AddRepuesto();
            add.ShowDialog(this);
        }

        private void txtValorDolar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValorDolar_Leave(object sender, EventArgs e)
        {
            if (this.txtValorDolar.Text.Trim().Equals(""))
            {
                this.txtValorDolar.Text = "" + 0;
            }
            recalcularValoresDolares();

            calcularTodo();
        }

        private void recalcularValoresDolares()
        {
            int contador = 0;
            for (int i = 0; i < this.dgvRepuestos.RowCount; i++)
            {

                Double total = Double.Parse(this.dgvRepuestos.Rows[contador].Cells[5].Value.ToString()) / Double.Parse(this.txtValorDolar.Text.Trim());
                this.dgvRepuestos.Rows[contador].Cells[6].Value = "" + total;
                contador = contador + 1;
            }
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();

            foreach (DataGridViewRow row in this.dgvPendientes.Rows)
            {
                if (this.dgvRepuestos.SelectedRows[0].Cells[0].Value.Equals(row.Cells[0].Value) || this.dgvRepuestos.SelectedRows[0].Cells[1].Value.Equals(row.Cells[1].Value))
                {
                    this.dgvPendientes.Rows.Remove(row);
                }
            }

            foreach (DataGridViewRow row in this.dgvSolicitados.Rows)
            {
                if (this.dgvRepuestos.SelectedRows[0].Cells[0].Value.Equals(row.Cells[0].Value) || this.dgvRepuestos.SelectedRows[0].Cells[1].Value.Equals(row.Cells[1].Value))
                {
                    this.dgvSolicitados.Rows.Remove(row);
                }
            }


           



            foreach (Repuesto ree in this.listaRepuestos)
            {

                if (ree.CODIGO.Equals(this.dgvRepuestos.SelectedRows[0].Cells[0].Value.ToString()) && ree.CODIGOPRELUDE.Equals(this.dgvRepuestos.SelectedRows[0].Cells[1].Value.ToString()))
                {
                    listaRepuestos.Remove(ree);
                    this.dgvRepuestos.Rows.Remove(this.dgvRepuestos.SelectedRows[0]);

                    if (this.dgvRepuestos.Rows.Count == 0)
                    {
                        this.btnEliminarRepuesto.Enabled = false;
                        this.btnModificarRepuesto.Enabled = false;
                    }
                    
                    return;
                }
            }



           

        }




        private void btnModificarRepuesto_Click(object sender, EventArgs e)
        {

            String[] datos = new String[3];

            datos[0] = (String)dgvRepuestos.SelectedRows[0].Cells[0].Value.ToString();
            datos[1] = (String)dgvRepuestos.SelectedRows[0].Cells[1].Value.ToString();
            datos[2] = (String)dgvRepuestos.SelectedRows[0].Cells[3].Value.ToString();
            AddRepuesto add = new AddRepuesto(datos);
            add.ShowDialog(this);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {/* si orden igual tipoordentrabajo entonces mostrar pesta;a equipo*/
            limpiarCampos();
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            NegocioCliente negC = new NegocioCliente();
            NegocioUsuario negU = new NegocioUsuario();
            NegocioSolicitud negS = new NegocioSolicitud();

            
            if (this.txtBuscarNumero.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el numero de la orden a buscar", "Error, falta informacion");
                return;
            }
            if (negO.existeOrden(this.txtBuscarNumero.Text.Trim()) == false)
            {
                MessageBox.Show(this, "¡No se encuentra la orden con ese numero!", "Error de duplicacion");

                return;

            }

            String tipo = negO.getTipoOrden(this.txtBuscarNumero.Text.Trim());
            
            if (!tipo.Equals(Modulo.tipoOrden)) {
                MessageBox.Show(this, "¡La orden que busca pertenece a la categoria: "
                    + tipo+"\nVuelva a abrir el menu de ordenes y seleccione \nLa categoria: "+tipo+".", "Error de busqueda");
                return;


            }


            Orden O = negO.getOrden(this.txtBuscarNumero.Text.Trim());
            this.txtNumero.Text = O.NUMERO;

            Modulo.tipoOrden = O.TIPOORDENTRABAJO;

            String[] fechatiempo = O.FECHAINICIO.Split(' ');
            String[] fecha = fechatiempo[0].Split('/');
            String[] tiempo = fechatiempo[1].Split(':');

            int mes = int.Parse(fecha[0]);
            int dia = int.Parse(fecha[1]);
            int anho = int.Parse(fecha[2]);

            int hora = int.Parse(tiempo[0]);
            int min = int.Parse(tiempo[1]);
            int seg = int.Parse(tiempo[2]);

            this.dTFechaInicio.Value = new DateTime(anho, mes, dia, hora, min, seg);

            String[] fechatiempo2 = O.FECHAINICIO.Split(' ');
            String[] fecha2 = fechatiempo[0].Split('/');
            String[] tiempo2 = fechatiempo[1].Split(':');

            int mes2 = int.Parse(fecha[0]);
            int dia2 = int.Parse(fecha[1]);
            int anho2 = int.Parse(fecha[2]);

            int hora2 = int.Parse(tiempo[0]);
            int min2 = int.Parse(tiempo[1]);
            int seg2 = int.Parse(tiempo[2]);

            this.dTFechaTermino.Value = new DateTime(anho2, mes2, dia2, hora2, min2, seg2);
            Modulo.rutCliente = O.CLIENTE;
            this.cmbEstado.SelectedItem = O.ESTADOORDENTRABAJO;
            this.cmbCategoria.SelectedItem = O.CATEGORIA;
            this.cmbPrioridad.SelectedItem = O.PRIORIDAD;
            this.txtEncargado.Text = O.ENCARGADO;
            Cliente s = negC.getCliente(O.CLIENTE);
            this.txtClienteNombre.Text = s.NOMBRE;
            Usuario u = negU.getUsuario(O.USUARIO_RUT);
            this.txtIngresadaPor.Text = u.NOMBRE + " " + u.APELLIDO;
            this.txtValorDolar.Text = O.VALORDOLAR.ToString();
            this.txtTotalClp.Text = O.VALORTOTALCLP.ToString();

            //cargar imagenes
            NegocioImagen negI = new NegocioImagen();
            this.listaImagenes = negI.getImagenesOrden(O.NUMERO);
            this.cargarListaImagenes();


            this.cargarSolicitud(O.NUMERO);
            this.rellenarGrillaSolicitudes();
            this.btnAgregar.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnCalcular.Enabled = true;
           // valor modificable del dolar this.txtValorDolar.Enabled = false;


            NegocioEquipo negEq = new NegocioEquipo();
            Equipo eq = negEq.getEquipo(O.EQUIPO);
            if (negEq.existeEquipo(eq) == true)
            {
                this.txtEquipo.Text = eq.NOMBRE;
                this.txtModelo.Text = eq.MODELO;
                this.txtCodigo.Text = eq.CODIGO;
                this.txtNSerie.Text = eq.NUMEROSERIE;

                this.txtPitbull.Text = eq.PITBULL;
                this.txtHorometro.Text = "" + eq.HOROMETRO;
                this.txtAno.Text = "" + eq.ANO;


                this.txtNSerie.Enabled = false;
            }




            this.btnAgregarRepuesto.Enabled = true;



            this.cargarManoObra(O.MANODEOBRA);
            this.cargarTrabajoTerceros(O.TRABAJOTERCEROS);


            if (this.dgvMano.RowCount > 0)
            {
                this.btnModificarMano.Enabled = true;

                this.btnEliminarMano.Enabled = true;
            }

            if (this.dgvTrabajo.RowCount > 0)
            {
                this.btnModificarTercero.Enabled = true;
                this.btnEliminarTercero.Enabled = true;
            }
            this.tabDetalle.Enabled = true;

            calcularTodo();

        }

        public void cargarOrden(String num)
        {
           
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            NegocioCliente negC = new NegocioCliente();
            NegocioUsuario negU = new NegocioUsuario();
            NegocioSolicitud negS = new NegocioSolicitud();


          


            Orden O = negO.getOrden(num);
            this.txtNumero.Text = O.NUMERO;

            Modulo.tipoOrden = O.TIPOORDENTRABAJO;

            String[] fechatiempo = O.FECHAINICIO.Split(' ');
            String[] fecha = fechatiempo[0].Split('/');
            String[] tiempo = fechatiempo[1].Split(':');

            int mes = int.Parse(fecha[0]);
            int dia = int.Parse(fecha[1]);
            int anho = int.Parse(fecha[2]);

            int hora = int.Parse(tiempo[0]);
            int min = int.Parse(tiempo[1]);
            int seg = int.Parse(tiempo[2]);

            this.dTFechaInicio.Value = new DateTime(anho, mes, dia, hora, min, seg);

            String[] fechatiempo2 = O.FECHAINICIO.Split(' ');
            String[] fecha2 = fechatiempo[0].Split('/');
            String[] tiempo2 = fechatiempo[1].Split(':');

            int mes2 = int.Parse(fecha[0]);
            int dia2 = int.Parse(fecha[1]);
            int anho2 = int.Parse(fecha[2]);

            int hora2 = int.Parse(tiempo[0]);
            int min2 = int.Parse(tiempo[1]);
            int seg2 = int.Parse(tiempo[2]);

            this.dTFechaTermino.Value = new DateTime(anho2, mes2, dia2, hora2, min2, seg2);
            Modulo.rutCliente = O.CLIENTE;
            this.cmbEstado.SelectedItem = O.ESTADOORDENTRABAJO;
            this.cmbCategoria.SelectedItem = O.CATEGORIA;
            this.cmbPrioridad.SelectedItem = O.PRIORIDAD;
            this.txtEncargado.Text = O.ENCARGADO;
            Cliente s = negC.getCliente(O.CLIENTE);
            this.txtClienteNombre.Text = s.NOMBRE;
            Usuario u = negU.getUsuario(O.USUARIO_RUT);
            this.txtIngresadaPor.Text = u.NOMBRE + " " + u.APELLIDO;
            this.txtValorDolar.Text = O.VALORDOLAR.ToString();
            this.txtTotalClp.Text = O.VALORTOTALCLP.ToString();

            //cargar imagenes
            NegocioImagen negI = new NegocioImagen();
            this.listaImagenes = negI.getImagenesOrden(O.NUMERO);
            this.cargarListaImagenes();


            this.cargarSolicitud(O.NUMERO);
            this.rellenarGrillaSolicitudes();
            this.btnAgregar.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnCalcular.Enabled = true;
            this.txtValorDolar.Enabled = false;


            NegocioEquipo negEq = new NegocioEquipo();
            Equipo eq = negEq.getEquipo(O.EQUIPO);
            if (negEq.existeEquipo(eq) == true)
            {
                this.txtEquipo.Text = eq.NOMBRE;
                this.txtModelo.Text = eq.MODELO;
                this.txtCodigo.Text = eq.CODIGO;
                this.txtNSerie.Text = eq.NUMEROSERIE;

                this.txtPitbull.Text = eq.PITBULL;
                this.txtHorometro.Text = "" + eq.HOROMETRO;
                this.txtAno.Text = "" + eq.ANO;


                this.txtNSerie.Enabled = false;
            }




            this.btnAgregarRepuesto.Enabled = true;



            this.cargarManoObra(O.MANODEOBRA);
            this.cargarTrabajoTerceros(O.TRABAJOTERCEROS);


            if (this.dgvMano.RowCount > 0)
            {
                this.btnModificarMano.Enabled = true;

                this.btnEliminarMano.Enabled = true;
            }

            if (this.dgvTrabajo.RowCount > 0)
            {
                this.btnModificarTercero.Enabled = true;
                this.btnEliminarTercero.Enabled = true;
            }
            this.tabDetalle.Enabled = true;
            
        }
        //cargar solicitud
        private void cargarSolicitud(String num) {

            NegocioSolicitud negS = new NegocioSolicitud();
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            this.listaRepuestos.Clear();
            this.listaSolicitudes = negS.getSolicitudes(num);
            foreach (Solicitud so in listaSolicitudes)
            {
                List<Repuesto> listarepu = negO.getRepuestosSolicitud(so.NUMERO);

                dgvRepuestos.Rows.Clear();

                foreach (Repuesto r in listarepu)
                {
                    r.SOLICITUD = so.NUMERO;
                    this.listaRepuestos.Add(r);
                    Object[] a = new Object[7];
                    a[0] = r.CODIGO;
                    a[1] = r.CODIGOPRELUDE;
                    a[2] = r.DESCRIPCION;
                    a[3] = r.CANTIDAD;
                    a[4] = r.VALORCLP;
                    Double total = Double.Parse(r.CANTIDAD.ToString()) * Double.Parse(r.VALORCLP.ToString());
                    a[5] = total.ToString();



                    Double totalUsd = total / Double.Parse(this.txtValorDolar.Text.Trim());


                    
                    a[6] = totalUsd;
                    dgvRepuestos.Rows.Add(a);
                    this.btnEliminarRepuesto.Enabled = true;
                    this.btnModificarRepuesto.Enabled = true;

                }

            }
        }


        //rellenar grilla solicitudes
        private void rellenarGrillaSolicitudes() {
            this.dgvPendientes.Rows.Clear();
            this.dgvSolicitados.Rows.Clear();
            this.dgvEntregados.Rows.Clear();

            foreach (Repuesto r in this.listaRepuestos)
            {
                Object[] a = new Object[4];
                //a[0] = r.SOLICITUD;
                a[0] = r.CODIGO;
                a[1] = r.CODIGOPRELUDE;
                a[2] = r.DESCRIPCION;
                a[3] = r.CANTIDAD;

                if (r.ESTADO.Equals("PENDIENTE"))
                {
                    dgvPendientes.Rows.Add(a);
                   
                }
                if (r.ESTADO.Equals("SOLICITADO"))
                {
                    dgvSolicitados.Rows.Add(a);
                }
                if (r.ESTADO.Equals("ENTREGADO"))
                {
                    dgvEntregados.Rows.Add(a);
                }

            }
        }



        private void btnSolicitar_Click(object sender, EventArgs e)

        {
            if (this.dgvPendientes.Rows.Count != 0) {
                DataGridViewRow row = this.dgvPendientes.SelectedRows[0];
                this.dgvPendientes.Rows.Remove(row);
                this.dgvSolicitados.Rows.Add(row);


                foreach (Repuesto ere in this.listaRepuestos)
                {
                    if (ere.CODIGO.Equals(row.Cells[0].Value.ToString()) && ere.CODIGOPRELUDE.Equals(row.Cells[1].Value.ToString()))
                    {
                          ere.ESTADO = "SOLICITADO";
                    }
                }
            }
        }

        private void btnCancelSol_Click(object sender, EventArgs e)
        {
            if (this.dgvSolicitados.Rows.Count !=0)
            {
                
                DataGridViewRow row = this.dgvSolicitados.SelectedRows[0];
                this.dgvSolicitados.Rows.Remove(row);
                this.dgvPendientes.Rows.Add(row);


                foreach (Repuesto ere in this.listaRepuestos)
                {
                    if (ere.CODIGO.Equals(row.Cells[0].Value.ToString()) && ere.CODIGOPRELUDE.Equals(row.Cells[1].Value.ToString()))
                    {
                        ere.ESTADO = "PENDIENTE";
                    }
                }
            }
           
            

        }

        private void dgvPendientes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btnSolicitar.Enabled = true;
        }

        private void dgvPendientes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgvPendientes.Rows.Count == 0) { 
            this.btnSolicitar.Enabled = false;
            }
        }
        private void dgvSolicitados_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btnCancelSol.Enabled = true;
        }
        private void dgvSolicitados_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgvSolicitados.Rows.Count == 0)
            {
                this.btnCancelSol.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtClienteNombre.Text.Trim().Equals(""))
            {

                MessageBox.Show(this, "Seleccione un cliente desde el boton", "Error, falta informacion");
                this.btnCliente.Focus();
                return;
             }
            if (this.txtEncargado.Text.Trim().Equals(""))
            {

                MessageBox.Show(this, "Seleccione un encargado desde el boton", "Error, falta informacion");
                this.btnCliente.Focus();
                return;
            }
            if (this.cmbPrioridad.SelectedItem.Equals("Seleccione..."))
            {
                MessageBox.Show(this, "Seleccione la prioridad", "Error, falta informacion");
                return;
            }
            if (this.cmbEstado.SelectedItem.Equals("Seleccione..."))
            {
                MessageBox.Show(this, "Seleccione el estado de la orden", "Error, falta informacion");
                return;
            }
            if (this.cmbCategoria.SelectedItem.Equals("Seleccione..."))
            {
                MessageBox.Show(this, "Seleccione la categoria", "Error, falta informacion");
                return;
            }
            if (this.txtValorDolar.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Ingrese el valor del dolar", "Error, falta informacion");
                return;
            }

            if (Modulo.tipoOrden.Equals("EQUIPO"))
            {
                /* existe el equipo?/*/
                if (this.txtEquipo.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el Nombre del equipo", "Error, falta informacion");
                    return;
                }
                if (this.txtModelo.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el Modelo del equipo", "Error, falta informacion");
                    return;
                }
                if (this.txtCodigo.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el Codigo del equipo", "Error, falta informacion");
                    return;
                }
                if (this.txtNSerie.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el Numero de serie del equipo", "Error, falta informacion");
                    return;
                }
                if (this.txtPitbull.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el N serie del Pitbull del equipo", "Error, falta informacion");
                    return;
                }
                if (this.txtHorometro.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese las horas", "Error, falta informacion");
                    return;
                }
                if (this.txtAno.Text.Trim().Equals(""))
                {
                    MessageBox.Show(this, "Ingrese el año del equipo", "Error, falta informacion");
                    return;
                }



                eq.NOMBRE = this.txtEquipo.Text.Trim();
                eq.MODELO = this.txtModelo.Text.Trim();
                eq.CODIGO = this.txtCodigo.Text.Trim();
                eq.NUMEROSERIE = this.txtNSerie.Text.Trim();
                eq.PITBULL = this.txtPitbull.Text.Trim();
                eq.HOROMETRO = int.Parse(this.txtHorometro.Text.Trim().ToString());
                eq.ANO = int.Parse(this.txtAno.Text.Trim().ToString());
                NegocioEquipo negE = new NegocioEquipo();

                //si existe equipo modificar, sino agregar
                
                if(negE.existeEquipo(eq) == true)
                {
                    if (this.txtNSerie.Enabled == true)
                    {
                        MessageBox.Show(this,"El equipo que","");
                    }
                    negE.modificarEquipo(eq);
                }
               else
                {
                    negE.agregarEquipo(eq);
                }
            }


            NegocioUsuario negU = new NegocioUsuario();

            Orden p = new Orden();
            p.ENCARGADO = this.txtEncargado.Text.Split(' ')[0];
            p.CLIENTE = Modulo.rutCliente;
            p.USUARIO_RUT = Modulo.usuario.RUT;
            p.NUMERO = this.txtNumero.Text.Trim();
            p.FECHAINICIO = DateTime.Now.Year + "//" + DateTime.Now.Month + "//" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            p.FECHATERMINO = this.dTFechaTermino.Value.ToString();
            p.ESTADOORDENTRABAJO = this.cmbEstado.SelectedItem.ToString();
            p.CATEGORIA = this.cmbCategoria.SelectedItem.ToString();
            p.PRIORIDAD = this.cmbPrioridad.SelectedItem.ToString();
            p.VALORDOLAR = Double.Parse(this.txtValorDolar.Text.ToString());
            p.VALORTOTALCLP = Double.Parse(this.txtTotalClp.Text.ToString());
            p.VALORTOTALUSD = Double.Parse(this.txtTotalUsd.Text.ToString());
            p.EQUIPO = this.txtNSerie.Text.Trim();
            p.MANODEOBRA = this.encriptarMano();
            p.TRABAJOTERCEROS = this.encriptarTrabajoTerceros();
      
            p.TIPOORDENTRABAJO = Modulo.tipoOrden;
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            NegocioSolicitud negS = new NegocioSolicitud();
            //necesrario un commit y rollback
           
                        
            NegocioEquipo negEq = new NegocioEquipo();

            negEq.modificarEquipo(eq);

            if (Modulo.tipoOrden.Equals("EQUIPO"))
            {
                negO.modificarOrdenEquipo(p);
            }
            if (Modulo.tipoOrden.Equals("SERVICIO"))
            {
                negO.modificarOrdenServicio(p);
            }


            NegocioImagen negI = new NegocioImagen();

            negI.eliminarImagenesOrden(this.txtNumero.Text.Trim());

            foreach (ImagenOrden img in this.listaImagenes)
            {
                
                negI.agregarImagen(img);
            }



            NegocioProducto negP = new NegocioProducto();

            String ene = negS.getNumeroOrdendeSolicitud(this.txtNumero.Text.Trim()).ToString();
            negS.eliminarSolicitudesRepuesto(ene);

            //this.encriptarRepuestos();

            foreach (Repuesto r in this.listaRepuestos)
            {
                negS.agregarSolicitudRepuesto(ene, r);
            }
            

            this.limpiarCampos();
            MessageBox.Show(this, "Orden modificada correctamente!", "Suceso");
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            calcularTodo();
        }
        private void calcularTodo()
        {

            this.calcular();
            this.calcularTotales();
        }
        private void calcularTotales() {
            double total = 0;
            double totalUsd = 0;
            foreach (DataGridViewRow d in this.dgvResumen.Rows)
            {
                total = total + Double.Parse(d.Cells[1].Value.ToString());
            }
            double valorDolar = Double.Parse(this.txtValorDolar.Text.Trim());
            totalUsd = total / valorDolar;


            this.txtTotalClp.Text =""+ total;
            this.txtTotalUsd.Text = ""+totalUsd;
        }

        
        /*
        VALOR HORA HOMBRE
        */

        private void calcular()
        {
            this.dgvResumen.Rows.Clear();
            double valorHoraHombre = 1;

            double totalMano = calcularMano();
            double totalTercero = calcularTerceros();
            double totalRepuestos = calcularRepuestos();
            double valorDolar = Double.Parse(this.txtValorDolar.Text.Trim());


            Object[] row = new Object[3];
            row[0] = "Mano de Obra";
            row[1] = totalMano * valorHoraHombre;
            row[2] = (totalMano * valorHoraHombre ) / valorDolar;

            Object[] row2 = new Object[3];
            row2[0] = "Trabajo a terceros / Compra local / Insumos";
            row2[1] = totalTercero;
            row2[2] = totalTercero / valorDolar;

            Object[] row3 = new Object[3];
            row3[0] = "Repuestos";
            row3[1] = totalRepuestos;
            row3[2] = totalRepuestos / valorDolar;


            this.dgvResumen.Rows.Add(row);
            this.dgvResumen.Rows.Add(row2);
            this.dgvResumen.Rows.Add(row3);
        }

        private double calcularMano() {
            if (this.dgvMano.Rows.Count != 0)
            {

                double total = 0;
                foreach (DataGridViewRow d in this.dgvMano.Rows)
                {
                    total = total + Double.Parse(d.Cells[1].Value.ToString());
                }
                return total;
            }
            return 0;
        }
        private double calcularTerceros()
        {
            if (this.dgvTrabajo.Rows.Count != 0)
            {
                double total = 0;
            foreach (DataGridViewRow d in this.dgvTrabajo.Rows)
            {
                total = total + Double.Parse(d.Cells[4].Value.ToString());
            }
            return total;
            }
            return 0;
        }

        private double calcularRepuestos()
        {
            if (this.dgvRepuestos.Rows.Count != 0)
            {
                double total = 0;
            foreach (DataGridViewRow d in this.dgvRepuestos.Rows)
            {
                total = total + Double.Parse(d.Cells[5].Value.ToString());
            }
            return total;
            }
            return 0;
        }

        private void btnPc_Click(object sender, EventArgs e)
        {
            PickEquipo pe = new PickEquipo();
            pe.ShowDialog(this);


        }

        public void cargarEquipo()
        {
            this.txtEquipo.Text = Modulo.equipo.NOMBRE;
            this.txtModelo.Text = Modulo.equipo.MODELO;
            this.txtCodigo.Text = Modulo.equipo.CODIGO;
            this.txtNSerie.Text = Modulo.equipo.NUMEROSERIE;

            this.txtPitbull.Text = Modulo.equipo.PITBULL;
            this.txtHorometro.Text = "" + Modulo.equipo.HOROMETRO;
            this.txtAno.Text = "" + Modulo.equipo.ANO;


            this.txtNSerie.Enabled = false;

        }

        private void txtHorometro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
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