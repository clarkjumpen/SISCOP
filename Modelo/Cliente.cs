using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        
        String nombre, rut, direccion, contacto, cargo, fono, email;

        public string CARGO
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public string EMAIL
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string CONTACTO
        {
            get
            {
                return contacto;
            }

            set
            {
                contacto = value;
            }
        }

        public string DIRECCION
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string FONO
        {
            get
            {
                return fono;
            }

            set
            {
                fono = value;
            }
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

        public string RUT
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }
    }
}
