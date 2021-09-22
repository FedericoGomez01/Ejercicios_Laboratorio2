using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Ejercicio34Bibliotecas
{
    
    public class Moto :VehiculoTerrestre
    {
        short cantidadPuertas;
        short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            :base(cantidadRuedas, color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cilindrada = cilindrada;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DEL MOTO");
            sb.AppendLine("CANTIDAD DE RUEDAS: " + base.getRuedas);
            sb.AppendLine("COLOR: " + base.getColor);

            return sb.ToString();
        }
    }
}
