using System;
using Clase2_Ejercicio11;

namespace Clase2_Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO 11";
            /*
             Realizar una clase llamada Validación que posea un método estático llamado Validar,
            que posea la siguiente firma: bool Validar(int valor, int min, int max):
            a. valor: dato a validar
            b. min y max: rango en el cual deberá estar la variable valor.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado 
            anteriormente que estén dentro del rango -100 y 100. Terminado el ingreso mostrar el 
            valor mínimo, el valor máximo y el promedio. Nota: Utilizar variables escalares, 
            NO utilizar vectores.
             
             */
            
            int numeroIngresado = int.MinValue;
            int numeroMayor = 0;
            int acumulador =0;
            float promedio = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nIngrese un numero ente -100 y 100: ");
                while ((int.TryParse(Console.ReadLine(), out numeroIngresado)) == false)
                {
                    Console.Write("ERROR. Ingrese un numero ente -100 y 100: ");
                }

                if (Validacion.Validar(numeroIngresado, -100, 100))
                {
                    Console.Write("Este Numero esta dentro del rango!");
                    acumulador += numeroIngresado;
                    if(numeroIngresado>numeroMayor)
                    {
                        numeroMayor = numeroIngresado;
                    }
                }
                else
                {
                    Console.Write("Este numero esta fuera del rango!");
                    i--;
                }
            }

            promedio = (float)acumulador / 10;

            Console.Write("El promedio es: {0}", promedio);
            Console.Write("El numero ams grande es: {0}", numeroMayor);

        }
    }
}
