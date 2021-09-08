using System;
using Clase3_Ejercicio17Biblioteca;

namespace Clase3_Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujito1, dibujito2;
            Boligrafo boligrafoUno = new Boligrafo(3, ConsoleColor.White);
            Boligrafo boligrafoDos = new Boligrafo(5, ConsoleColor.White);

            
           if(!boligrafoDos.Pintar(100,out dibujito1))
           {
                Console.WriteLine("El boligrafo se quedo sin tinta");
           }

            Console.ForegroundColor = boligrafoDos.GetColor();
            Console.WriteLine(dibujito1);

            if (!boligrafoUno.Pintar(100, out dibujito2))
            {
                Console.WriteLine("El boligrafo se quedo sin tinta");
            }

            Console.ForegroundColor = boligrafoUno.GetColor();
            Console.WriteLine(dibujito2);

        }
    }
}
