using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private String proveedor_nombre, nombre, descripcion, cuenta, tipoequipamiento_nombre, codigoMc, codigoprelude;

      

      

        public string CODIGOMC
        {
            get
            {
                return codigoMc;
            }

            set
            {
                codigoMc = value;
            }
        }

      

        public string CODIGOPRELUDE
        {
            get
            {
                return codigoprelude;
            }

            set
            {
                codigoprelude = value;
            }
        }

       

        public string CUENTA
        {
            get
            {
                return cuenta;
            }

            set
            {
                cuenta = value;
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

        
        

        public string PROVEEDOR_NOMBRE
        {
            get
            {
                return proveedor_nombre;
            }

            set
            {
                proveedor_nombre = value;
            }
        }

       

        public string TIPOEQUIPAMIENTO_NOMBRE
        {
            get
            {
                return tipoequipamiento_nombre;
            }

            set
            {
                tipoequipamiento_nombre = value;
            }
        }
    }
}

