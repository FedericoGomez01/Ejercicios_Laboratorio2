using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_Ejercicio32Bibliotecas
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>(); //instancio mi lista de jugadores
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }


        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (j == item)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
