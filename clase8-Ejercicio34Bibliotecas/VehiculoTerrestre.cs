using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Ejercicio34Bibliotecas
{
    public class VehiculoTerrestre
    {
        short cantidadRuedas;
        Colores color;
        public VehiculoTerrestre(short cantidadRuedas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }

        public Colores getColor
        {
            get
            {
                return this.color;
            }
        }

        public short getRuedas
        {
            get
            {
                return this.cantidadRuedas;
            }
        }
    }
}
