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
    public partial class EgresoOrden : Form
    {
        public EgresoOrden()
        {
            InitializeComponent();
        }

        private void EgresoOrden_Load(object sender, EventArgs e)
        {
           
            Modulo.egresoOrden = this;
            
        }


        private void limpiarCampos() {

            this.btnGenerar.Enabled = false;
         
        }
        private List<Repuesto> listaRepuestos = new List<Repuesto>();
        private List<Solicitud> listaSolicitudes = new List<Solicitud>();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            String numero = this.txtNumero.Text.Trim();
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();

            if (numero.Equals("")) {

                MessageBox.Show(this, "Ingrese el numero de orden a cargar", "Error!, Falta informacion");
                return;
            }

            if (negO.existeOrden(numero) == false)
            {
                MessageBox.Show(this, "¡No se encuentra la orden con ese numero!", "Error de duplicacion");
                return;

            }

            this.cargarSolicitud(numero);
            this.rellenarGrillaSolicitudes();
            this.btnGenerar.Enabled = true;
        }

        private void cargarSolicitud(String num)
        {

            NegocioSolicitud negS = new NegocioSolicitud();
            NegocioOrdenTrabajo negO = new NegocioOrdenTrabajo();
            this.listaRepuestos.Clear();
            this.listaSolicitudes = negS.getSolicitudes(num);
            foreach (Solicitud so in listaSolicitudes)
            {
                List<Repuesto> listarepu = negO.getRepuestosSolicitud(so.NUMERO);
                
                foreach (Repuesto r in listarepu)
                {
                    this.listaRepuestos.Add(r);
                }

            }
        }

        private void rellenarGrillaSolicitudes()
        {
   
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.egresoOrden = null;
            this.Dispose();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            NegocioSolicitud negS = new NegocioSolicitud();
            String numero = this.txtNumero.Text.Trim();
            String fecha = DateTime.Now.Year + "//" + DateTime.Now.Month + "//" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            negS.agregarSolicitudEgresoOrden(fecha,numero);
            negS.entregarRepuestoSolicitud(numero);
            MessageBox.Show(this, "Solicitud Ejecutada con exito", "Suceso!");
            //EXPORTAR A EXCEL Y WEA



            rellenarGrillaSolicitudes();
         //volver a calcular bodega .. descontar de la bodega   
        }
    }
}
