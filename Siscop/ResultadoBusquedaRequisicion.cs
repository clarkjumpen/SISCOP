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
    public partial class ResultadoBusquedaRequisicion : Form
    {
        public ResultadoBusquedaRequisicion(Requisicion re,String a)
        {
            InitializeComponent();
            this.req = re;
            rellenarGrilla(re);
        }
        private Requisicion req = new Requisicion();

        private void rellenarGrilla(Requisicion re)
        {
            NegocioRequisicion negR = new NegocioRequisicion();
            NegocioUsuario negU = new NegocioUsuario();
            Usuario u = negU.getUsuario(re.USUARIO_RUT);
            
            this.dgvRequisicion.Rows.Add(re.NUMERO,re.FECHA,re.TIPO,re.DESCRIPCION,re.ESTADO,re.PRIORIDAD,u.NOMBRE+ " "+u.APELLIDO);

        }

        private void ResultadoBusquedaRequisicion_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Modulo.ingresarRequisicion.cargarRequisicion(req);
            this.Dispose();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
