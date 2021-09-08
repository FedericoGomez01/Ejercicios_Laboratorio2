using System;

namespace Clase2_Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un programa que sume números enteros hasta que el usuario lo determine,
            por medio de
            un mensaje "¿Continuar? (S/N)".
            En el método estático ValidaS_N(char c) de la clase ValidarRespuesta,
            se validará el ingreso de
            opciones.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y 
            FALSE si se ingresó
            cualquier otro valor.
             */
            char letraIngresada;
            Console.Write("Desea continuar? [S]-SI  [N]-NO: ");
            while (!(char.TryParse(Console.ReadLine(), out letraIngresada)))
            {
                Console.Write("Desea continuar? [S]-SI  [N]-NO: ");
            }

            if (ValidarRespuesta.ValidaS_N(letraIngresada))
            {
                Console.Write("CONTINUA");
            }
            else
            {
                Console.Write("TERMINA");
            }

        }
    }
}
