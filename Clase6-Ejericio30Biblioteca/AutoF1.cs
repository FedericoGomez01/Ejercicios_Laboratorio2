using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6_Ejericio30Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
        }


        public short Combustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public bool Competencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS F1");
            sb.AppendLine("CANTIDAD COMBUSTIBLE: " + this.cantidadCombustible);
            sb.AppendLine("EN COMPETENCIA: " + this.enCompetencia);
            sb.AppendLine("ESCUDERIA: " + this.escuderia);
            sb.AppendLine("NUMERO: " + this.numero);
            sb.AppendLine("VUELTAS RESTANTES: " + this.vueltasRestantes);

            return sb.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.escuderia == a2.escuderia) && (a1.numero == a2.numero);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
            

    }
}
