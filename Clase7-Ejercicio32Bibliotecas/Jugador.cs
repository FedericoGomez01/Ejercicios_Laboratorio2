using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_Ejercicio32Bibliotecas
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.promedioGoles = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public Jugador this [int dni,string nombre,int partidosJugados,float promedioGoles, int totalGoles]
        {
            get
            {

            }

            set
            {

            } 
        }
        public float GetPromedioGoles()
        {
            return this.promedioGoles = (float)this.partidosJugados / this.totalGoles;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DEL JUGADOR");
            sb.AppendLine("NOMBRE: " + this.nombre);
            sb.AppendLine("DNI: " + this.dni);
            sb.AppendLine("PARTIDOS JUGADOS: " + this.partidosJugados);
            sb.AppendLine("TOTAL DE GOLES: " + this.totalGoles);
            sb.AppendLine("PROMEDIO DE GOLES: " + this.promedioGoles);

            return sb.ToString();
        }
    }
}
