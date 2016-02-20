using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Requisicion
    {
        private String usuario_rut, descripcion, prioridad, tipo, estado;
        private String fecha;
        private double numero;

        public string USUARIO_RUT
        {
            get
            {
                return usuario_rut;
            }

            set
            {
                usuario_rut = value;
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

        public string PRIORIDAD
        {
            get
            {
                return prioridad;
            }

            set
            {
                prioridad = value;
            }
        }

        public string TIPO
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public String FECHA
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public double NUMERO
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
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
    }
}
