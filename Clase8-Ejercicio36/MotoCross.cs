using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_Ejercicio36
{
    public class MotoCross :VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            :base(numero,escuderia)
        { }

        public MotoCross(short numero, string escuderia, short cilindrada) 
            :this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }


        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DETALLES DE MOTO CROSS");
            sb.AppendLine("CILINDRADA: " + this.Cilindrada);
            sb.AppendLine("EN COMPETENCIA: " + base.EnCompetencia);
            sb.AppendLine("COMBUSTIBLE: " + base.Combustible);
            sb.AppendLine("ESCUDERIA: " + base.Escuderia);
            sb.AppendLine("NUMERO: " + base.Numero);
            sb.AppendLine("VUELTAS RESTANTES: " + base.VueltasRestantes);

            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return ((VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2) && m1.Cilindrada == m2.Cilindrada;

        }


        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }


    }
}
