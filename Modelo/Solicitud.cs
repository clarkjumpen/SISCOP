using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Solicitud
    {
        private String fecha, usuario_rut_fk, numero, ordentrabajo_numero;

        
        public string FECHA
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

        public string ORDENTRABAJO_NUMERO
        {
            get
            {
                return ordentrabajo_numero;
            }

            set
            {
                ordentrabajo_numero = value;
            }
        }

        public string USUARIO_RUT
        {
            get
            {
                return usuario_rut_fk;
            }

            set
            {
                usuario_rut_fk = value;
            }
        }
    }
}
