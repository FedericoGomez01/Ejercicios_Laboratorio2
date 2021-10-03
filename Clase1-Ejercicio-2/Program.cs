using System;
using System.Collections;

namespace Clase1_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
            Se debe validar que el número sea mayor que cero, caso contrario, 
            mostrar el mensaje: "ERROR. ¡Reingresar número!".Nota: Utilizar el método
            ‘Pow’ de la clase Math para realizar la operación.
            */
            int numeroIngresado;
            double cuadradoNumero;
            double cuboNumero;
            Console.Write("Ingrese un numero: ");


            if((int.TryParse(Console.ReadLine(), out numeroIngresado)) == true && numeroIngresado > 0)
            {
                cuadradoNumero = Math.Pow(numeroIngresado, 2);
                cuboNumero = Math.Pow(numeroIngresado, 3);

                Console.Write("El numero elevado al cuadrado es {0}", cuadradoNumero);
                Console.Write("El numero elevado al cubo es {0}", cuboNumero);

            }
            else
            {
                Console.Write("ERROR. ¡Reingresar número!");
            }




        }
    }

}
