using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_Ejercicio36
{
    public class AutoF1 :VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia):base(numero, escuderia)
        {}

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) 
            :this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DETALLES DEL AUTO DE F1");
            sb.AppendLine("CABALLOS DE FUERZA: " + this.CaballosDeFuerza);
            sb.AppendLine("EN COMPETENCIA: " + base.EnCompetencia);
            sb.AppendLine("COMBUSTIBLE: " + base.Combustible);
            sb.AppendLine("ESCUDERIA: " + base.Escuderia);
            sb.AppendLine("NUMERO: " + base.Numero);
            sb.AppendLine("VUELTAS RESTANTES: " + base.VueltasRestantes);

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2) &&  (a1.caballosDeFuerza == a2.caballosDeFuerza);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


    }
}
