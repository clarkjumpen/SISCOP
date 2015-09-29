using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private String rut, nombre, apellido, clave;
        private int nivel;
        private bool bloqueado;

        public String RUT
        {
            get
            {
                return this.rut;
            }
            set
            {
                this.rut = value;
            }
        }
        public String NOMBRE
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public String APELLIDO
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public String CLAVE
        {
            get
            {
                return this.clave;
            }
            set
            {
                this.clave = value;
            }
        }

        public int NIVEL
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }

        public bool BLOQUEADO
        {
            get
            {
                return this.bloqueado;
            }
            set
            {
                this.bloqueado = value;
            }
        }

    }
}
