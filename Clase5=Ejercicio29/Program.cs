using System;
using Clase5_Ejercicio29Bibliotecas;

namespace Clase5_Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(41065660, "Federico", 23, 30);
            Jugador j2 = new Jugador(41801120, "Constanza", 27, 30);

            Equipo e1 = new Equipo(12,"PSG");
            Equipo e2 = new Equipo(12, "BARCELONA");



            Console.WriteLine(e1 + j1);
            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(e1 + j1);
            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(e2 + j2);
            Console.WriteLine(j2.MostrarDatos());
            Console.WriteLine(e2 + j2);
            Console.WriteLine(j2.MostrarDatos());
            Console.WriteLine(e2 + j1);
            Console.WriteLine(j1.MostrarDatos());

            Console.ReadKey();

        }
    }
}
