using System;
using Entidades_Sobrecargas;
namespace Clase4_Sobrecargas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Automovil au = new Automovil();

            au.Acelerar();
            au.Acelerar();
            Console.WriteLine(au.velocidadActual);
            au.Acelerar(12);
            Console.WriteLine(au.velocidadActual);


        }
    }
}
