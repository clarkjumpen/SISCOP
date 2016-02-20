using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ImagenOrden
    {
        String numeroOrden, descripcion, nombreArchivo;
        byte[] imagen;

        public ImagenOrden(String numeroOrden,String descripcion, String nombreArchivo, byte[] imagen)
        {
            this.numeroOrden = numeroOrden;
            this.descripcion = descripcion;
            this.nombreArchivo = nombreArchivo;
            this.imagen = imagen;

        }
        public ImagenOrden()
        {
            this.numeroOrden = "";
            this.descripcion = "";
            this.nombreArchivo = "";
            this.imagen = new byte[0];

        }
        public string NUMEROORDEN
        {
            get
            {
                return numeroOrden;
            }

            set
            {
                numeroOrden = value;
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

        public string NOMBREARCHIVO
        {
            get
            {
                return nombreArchivo;
            }

            set
            {
                nombreArchivo = value;
            }
        }

        public byte[] IMAGEN
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }
    }
}
