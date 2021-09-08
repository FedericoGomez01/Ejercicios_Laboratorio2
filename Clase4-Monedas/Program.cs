using System;
using Clase4_MonedasClases;
namespace Clase4_Monedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO 20";

            Euro billeteEuro = 100;
            Peso billetePeso = ((Peso)billeteEuro);

            Dolar billeteDolar = 100;
            Peso peso = (Peso)billeteDolar;

            Console.WriteLine("100 pesos equivale a {0} Euros", billetePeso.GetCantidad);
            Console.WriteLine("100 pesos equivale a {0} Dolares", peso.GetCantidad);

            Console.ReadKey();
        }
    }
}
