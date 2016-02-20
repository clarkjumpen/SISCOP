using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Equipo
    {
        String nombre, modelo, codigo, numeroSerie, pitbull;
        int horometro, ano;

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

        public string MODELO
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
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

        public string NUMEROSERIE
        {
            get
            {
                return numeroSerie;
            }

            set
            {
                numeroSerie = value;
            }
        }

        public string PITBULL
        {
            get
            {
                return pitbull;
            }

            set
            {
                pitbull = value;
            }
        }

        public int HOROMETRO
        {
            get
            {
                return horometro;
            }

            set
            {
                horometro = value;
            }
        }

        public int ANO
        {
            get
            {
                return ano;
            }

            set
            {
                ano = value;
            }
        }
    }
}
