using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_Ejercicio36
{
    public enum TipoCompetencia {AutoF1, MotoCross }
    public class Competencia
    {

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get { return competidores[i]; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DE LA COMPETENCIA");
            sb.AppendLine("CANTIDAD DE VUELTAS: " + cantidadVueltas);
            sb.AppendLine("CANTIDAD DE COMPETIDORES: " + cantidadCompetidores);
            foreach (VehiculoDeCarrera competidor in competidores)
            {
                sb.AppendLine("COMPETIDORES: " + competidor.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            foreach (VehiculoDeCarrera a2 in c.competidores)
            {
                if (a2 == a)
                {
                    c.competidores.Remove(a);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            int formaParte = 0;
            if (c.cantidadCompetidores > c.competidores.Count)
            {
                if (v is AutoF1)
                {

                    foreach (VehiculoDeCarrera a2 in c.competidores)
                    {
                        if (v == a2)
                        {
                            formaParte++;
                        }
                    }

                    if (formaParte != 1)
                    {
                        Random rand = new Random();
                        c.competidores.Add(v);
                        retorno = true;
                        v.EnCompetencia = true;
                        v.VueltasRestantes = c.cantidadVueltas;
                        v.Combustible = (short)(rand.Next(15, 100));
                    }

                }
                else if (v is MotoCross)
                {
                    foreach (VehiculoDeCarrera m2 in c.competidores)
                    {
                        if (v == m2)
                        {
                            formaParte++;
                        }
                    }

                    if (formaParte != 1)
                    {
                        Random rand = new Random();
                        c.competidores.Add(v);
                        retorno = true;
                        v.EnCompetencia = true;
                        v.VueltasRestantes = c.cantidadVueltas;
                        v.Combustible = (short)(rand.Next(15, 100));
                    }
                }
            }

            return retorno;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {

        }
    }
}
