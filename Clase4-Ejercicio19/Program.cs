using System;
using Clase4_ejercicio19Clases;
namespace Clase4_Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(1);

            long a =1;
            long b =5;

            
            Console.WriteLine(s1.Sum("HO","LA"));
            Console.WriteLine((int)s1.Sum(4, 4));

            
            Console.WriteLine(s1.Sum(12, 32));
        }
    }
}
