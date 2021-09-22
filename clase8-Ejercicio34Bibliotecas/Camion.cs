using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Ejercicio34Bibliotecas
{
    public class Camion : VehiculoTerrestre
    {

        short cantidadPuertas;
        short cantidadMarchas;
        int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas
            , int pesoCarga)
            : base(cantidadRuedas, color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DEL CAMION");
            sb.AppendLine("CANTIDAD DE RUEDAS: " + base.getRuedas);
            sb.AppendLine("COLOR: " + base.getColor);

            return sb.ToString();
        }


    }
}
