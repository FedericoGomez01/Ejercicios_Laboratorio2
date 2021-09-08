using System;
using Campos;
namespace Clase3_ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nota;
            Alumno a = new Alumno("Federico", "Gomez", 1);
            Alumno b = new Alumno("Santiago", "Gomez", 2);
            Alumno c = new Alumno("Constanza", "Biga", 3);


            a.Estudiar(10, 3);
            b.Estudiar(7, 7);
            c.Estudiar(8, 5);

            a.CalcularFinal();

            nota = a.Mostrar();
            Console.Write("{0}\n", nota);
            nota = b.Mostrar();
            Console.Write("{0}\n", nota);
            nota = c.Mostrar();
            Console.Write("{0}\n", nota);

        }
    }
}
