using System;

namespace Clase1_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Mostrar por pantalla todos los números primos que haya hasta el número 
            que ingrese el usuario por consola.

            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
             */
            int numeroIngresado;
            Console.Write("Ingrese un numero: ");
            Console.Title = "EJERCICIO 3";
            if(int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                for (int i = 2; i < numeroIngresado+1; i++)
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write("{0} Es un numero primo\n", i);

                            break;

                        case 3:
                            Console.Write("{0} Es un numero primo\n", i);

                            break;

                        case 5:
                            Console.Write("{0} Es un numero primo\n", i);

                            break;

                        case 7:
                            Console.Write("{0} Es un numero primo\n", i);

                            break;
                        default:
                            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 )
                            {
                                Console.Write("{0} Es un numero primo\n", i);
                            }
                            else
                            {
                                Console.Write("{0} Es un numero compuesto\n", i);
                            }
                            break;
                    }

                    

                    
                }
            }

        }
    }
}
