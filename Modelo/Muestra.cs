using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Muestra 
    {
        private String producto_codigo, producto_codigoprelude, mesInicialDepr, mesActualDepr,estado_nombre_fk ,bodega_nombre_fk;
        private DateTime fechaIngreso, fechaSalida;
        private Double valorIngresoClp, valorActualClp;
        private int cantidad;

        public string PRODUCTO_CODIGO
        {
            get
            {
                return producto_codigo;
            }

            set
            {
                producto_codigo = value;
            }
        }

        public string PRODUCTO_CODIGOPRELUDE
        {
            get
            {
                return producto_codigoprelude;
            }

            set
            {
                producto_codigoprelude = value;
            }
        }

        public string MESINICIALDEPR
        {
            get
            {
                return mesInicialDepr;
            }

            set
            {
                mesInicialDepr = value;
            }
        }

        public string MESACTUALDEPR
        {
            get
            {
                return mesActualDepr;
            }

            set
            {
                mesActualDepr = value;
            }
        }

        public string ESTADO
        {
            get
            {
                return estado_nombre_fk;
            }

            set
            {
                estado_nombre_fk = value;
            }
        }

        public string BODEGA
        {
            get
            {
                return bodega_nombre_fk;
            }

            set
            {
                bodega_nombre_fk = value;
            }
        }

        public DateTime FECHAINGRESO
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        public DateTime FECHASALIDA
        {
            get
            {
                return fechaSalida;
            }

            set
            {
                fechaSalida = value;
            }
        }

        public double VALORINGRESOCLP
        {
            get
            {
                return valorIngresoClp;
            }

            set
            {
                valorIngresoClp = value;
            }
        }

        public double VALORACTUALCLP
        {
            get
            {
                return valorActualClp;
            }

            set
            {
                valorActualClp = value;
            }
        }

        public int CANTIDAD
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
    }
}
