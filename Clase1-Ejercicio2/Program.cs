﻿using System;

namespace Clase1_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            int numero = 1;

            do
            {
                for(int i=1; i<numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        acumulador += i;
                    }
                }

                if(acumulador == numero)
                {

                    Console.WriteLine($"El num perfecto {numero}");
                    contador++;
                }
                numero++;
                acumulador = 0;
            } while (contador<4);
            Console.ReadLine();
        }
    }
}
