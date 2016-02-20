using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cuenta
    {
        private String nombre;
        private String numero;

        public Cuenta()
        {
            this.nombre = "";
            this.numero = "";

        }
        public Cuenta(String nombre,String numero)
        {
            this.nombre = nombre;
            this.numero = numero;

        }
        public string NOMBRE
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
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
    }
}
