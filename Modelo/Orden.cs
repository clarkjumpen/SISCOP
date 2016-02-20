using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Orden
    {
        String numero, fechaInicio,fechaTermino, usuario_rut, cliente_rut, prioridad_nombre, manodeobra, trabajoterceros, encargado_rut, categoria_nombre,tipoordentrabajo_nombre,equipo_numeroserie,estadoordentrabjo_nombre;
         Double valortotalclp,valortotalusd,valordolar;
        Repuesto[] repuesto;

        public string CATEGORIA
        {
            get
            {
                return categoria_nombre;
            }

            set
            {
                categoria_nombre = value;
            }
        }

        public string CLIENTE
        {
            get
            {
                return cliente_rut;
            }

            set
            {
                cliente_rut = value;
            }
        }

        public string ENCARGADO
        {
            get
            {
                return encargado_rut;
            }

            set
            {
                encargado_rut = value;
            }
        }

        public string EQUIPO
        {
            get
            {
                return equipo_numeroserie;
            }

            set
            {
                equipo_numeroserie = value;
            }
        }

        public string ESTADOORDENTRABAJO
        {
            get
            {
                return estadoordentrabjo_nombre;
            }

            set
            {
                estadoordentrabjo_nombre = value;
            }
        }

        public string FECHAINICIO
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public string FECHATERMINO
        {
            get
            {
                return fechaTermino;
            }

            set
            {
                fechaTermino = value;
            }
        }

        public string MANODEOBRA
        {
            get
            {
                return manodeobra;
            }

            set
            {
                manodeobra = value;
            }
        }

        public string NUMERO
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

        public string PRIORIDAD
        {
            get
            {
                return prioridad_nombre;
            }

            set
            {
                prioridad_nombre = value;
            }
        }

        public Repuesto[] REPUESTO
        {
            get
            {
                return repuesto;
            }

            set
            {
                repuesto = value;
            }
        }

        public string TIPOORDENTRABAJO
        {
            get
            {
                return tipoordentrabajo_nombre;
            }

            set
            {
                tipoordentrabajo_nombre = value;
            }
        }

        public string TRABAJOTERCEROS
        {
            get
            {
                return trabajoterceros;
            }

            set
            {
                trabajoterceros = value;
            }
        }

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

        public double VALORDOLAR
        {
            get
            {
                return valordolar;
            }

            set
            {
                valordolar = value;
            }
        }

        public double VALORTOTALCLP
        {
            get
            {
                return valortotalclp;
            }

            set
            {
                valortotalclp = value;
            }
        }

        public double VALORTOTALUSD
        {
            get
            {
                return valortotalusd;
            }

            set
            {
                valortotalusd = value;
            }
        }
    }
}
