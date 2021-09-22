using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6_Ejericio30Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DE LA COMPETENCIA");
            sb.AppendLine("CANTIDAD DE VUELTAS: " + cantidadVueltas);
            sb.AppendLine("CANTIDAD DE COMPETIDORES: "+cantidadCompetidores);
            foreach (AutoF1 competidor in competidores)
            {
                sb.AppendLine("COMPETIDORES: " + competidor.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            foreach (AutoF1 a2 in c.competidores)
            {
                if(a2 == a)
                {
                    c.competidores.Remove(a);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            int formaParte = 0;
            if(c.cantidadCompetidores > c.competidores.Count)
            {
                foreach (AutoF1 a2 in c.competidores)
                {
                    if (a == a2)
                    {
                        formaParte++;
                    }
                }

                if (formaParte != 1)
                {
                    Random rand = new Random();
                    c.competidores.Add(a);
                    retorno = true;
                    a.Competencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.Combustible = (short)(rand.Next(15, 100));
                }
            }

            return retorno;
        }


    }
}
