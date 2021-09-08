using System;
using Entidades;

namespace Clase3_Vinculada
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Federico Gomez", 23);


            Console.WriteLine("{0} tiene {1} años", p.GetNombre(), p.GetEdad());
            
        }
    }
}
