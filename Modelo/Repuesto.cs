using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Repuesto
    {
        String codigo, codigoPrelude, descripcion, estado, solicitud_numero;
        int cantidad;
        Double valorClp;
        public string SOLICITUD
        {
            get
            {
                return solicitud_numero;
            }

            set
            {
                solicitud_numero = value;
            }
        }
        public string ESTADO
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
        public string CODIGO
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string CODIGOPRELUDE
        {
            get
            {
                return codigoPrelude;
            }

            set
            {
                codigoPrelude = value;
            }
        }

        public string DESCRIPCION
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
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

        public double VALORCLP
        {
            get
            {
                return valorClp;
            }

            set
            {
                valorClp = value;
            }
        }
    }
}
