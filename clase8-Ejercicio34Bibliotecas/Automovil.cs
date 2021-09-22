using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Ejercicio34Bibliotecas
{
    public class Automovil : VehiculoTerrestre
    {
        short cantidadPuertas;
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas
            , int cantidadPasajeros)
            : base(cantidadRuedas, color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DEL AUTOMOVIL");
            sb.AppendLine("CANTIDAD DE RUEDAS: "+ base.getRuedas);
            sb.AppendLine("COLOR: " + base.getColor);

            return sb.ToString();
        }
    }
}
