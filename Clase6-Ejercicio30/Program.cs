using System;
using Clase6_Ejericio30Biblioteca;

namespace Clase6_Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(2,5);
            AutoF1 a1 = new AutoF1(44, "Mercedes Benz");
            AutoF1 a2 = new AutoF1(10, "Ferrari");
            AutoF1 a3 = new AutoF1(20, "Ferrari");
            AutoF1 a4 = new AutoF1(30, "Red Bull");
            AutoF1 a5 = new AutoF1(50, "Alpha Tauri");
            AutoF1 a6 = new AutoF1(60, "Alpha Tauri");

            Console.WriteLine(c.MostrarDatos());

            Console.WriteLine(c + a1);
            Console.WriteLine(c + a2);
            Console.WriteLine(c + a3);
            Console.WriteLine(c + a3);
            Console.WriteLine(c + a4);
            Console.WriteLine(c + a5);
            Console.WriteLine(c + a5);
            Console.WriteLine(c + a6);
            Console.WriteLine(a6.MostrarDatos());
            Console.WriteLine(a5.MostrarDatos());
            Console.WriteLine(a4.MostrarDatos());
            Console.WriteLine(a3.MostrarDatos());
            Console.WriteLine(a2.MostrarDatos());
            Console.WriteLine(a1.MostrarDatos());

            Console.ReadKey();
        }
    }
}
