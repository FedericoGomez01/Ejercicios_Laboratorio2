using System;
using Clase4_Esercicio21Biblioteca;

namespace Clase4_Ejercicio21Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius gradosC = new Celcius(30);
            Fahrenheit gradosF = new Fahrenheit(86);

            Console.WriteLine("La temperatura de 30 celcius en fahrenheit es: {0}", ((Fahrenheit)gradosC).GetTemperatura());
            Console.WriteLine("La temperatura de 80 fahrenheit en celcius es: {0}", ((Celcius)gradosF).GetTemperatura());

            if(gradosC == gradosF)
            {
                Console.WriteLine("Las temperaturas {0}C y {1}F son iguales", gradosC.GetTemperatura(), gradosF.GetTemperatura());
            }
            else
            {
                Console.WriteLine("Las temperaturas {0}C y {1}F son diistintas", gradosC.GetTemperatura(), gradosF.GetTemperatura());

            }

            Console.ReadKey();
        }
    }
}
