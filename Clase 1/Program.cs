using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ingresar 5 números por consola, guardándolos en una variable escalar.
             * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
             */
            int numeroIngresado;
            int cantidadNumeros = 5;
            int numeroMayor = int.MinValue;
            int numeroMenor = int.MaxValue;
            int acumuladorTotal =0;
            float promedio;
            string ingreso;


            for (int i=0; i< cantidadNumeros;i++)
            {
                Console.Write("Ingrese un numero:");
                ingreso = Console.ReadLine(); //lee la linea ingresada, y se la asigno (=) a ingreso 
                if(int.TryParse(ingreso, out numeroIngresado)) //parsea lo que hay en ingreso a numeroIngresado y devuelve true si pudo o false si no pudo 
                {
                    acumuladorTotal += numeroIngresado;

                    if (numeroIngresado>numeroMayor)
                    {
                        numeroMayor = numeroIngresado;

                    }
                    
                    if(numeroIngresado < numeroMenor )
                    {
                        numeroMenor = numeroIngresado;
                    }

                }
                else
                {
                    Console.WriteLine("No se ingreso un numero");
                }
            }
            promedio = (float)acumuladorTotal / (float)cantidadNumeros;
            Console.Write("El numero mayor es {0}\n", numeroMayor);
            Console.Write("El numero menor es {0}\n", numeroMenor);
            Console.Write("El numero promedio es {0}\n", promedio);
        }
    }
}
