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
    public partial class Bodega : Form
    {
        public Bodega()
        {
            InitializeComponent();
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            Modulo.bodega = this;
            cargarBodegas();
        }

        private void cargarBodegas()
        {
            cargarExistenciasGrid();
            cargarActivosGrid();

        }
        private void cargarExistenciasGrid()
        {


            NegocioMuestra negE = new NegocioMuestra();
            NegocioCuenta negC = new NegocioCuenta();
            List<Object[]> lista = negE.getAllExistencias();

            this.dgvExistencias.Rows.Clear();
            foreach (Object[] ob in lista)
            {
                ob[4] =  negC.getNombreCuenta(ob[4].ToString()) + " (" + ob[4] + ")";
                this.dgvExistencias.Rows.Add(ob[0], ob[1], ob[2], ob[3], ob[4], ob[5], ob[6], ob[7], ob[8]);
            }
      

        }

        private void cargarActivosGrid()
        {
            NegocioCuenta negC = new NegocioCuenta();
            NegocioMuestra negE = new NegocioMuestra();
            List<Object[]> lista = negE.getAllActivos();

            this.dgvActivos.Rows.Clear();
            foreach (Object[] ob in lista)
            {
                ob[4] = negC.getNombreCuenta(ob[4].ToString()) + " (" + ob[4] + ")";
                this.dgvActivos.Rows.Add(ob[0], ob[1], ob[2], ob[3], ob[4], ob[5], ob[6], ob[7], ob[8]);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Modulo.bodega = null;
            this.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarExistenciasGrid();
            cargarActivosGrid();
        }
    }
    }