using System;
using Ejercicio42_ExcepcionesBiblioteca;

namespace Ejercicio42_Excepciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase miExcepcion = new OtraClase();
                miExcepcion.metodoInstancia();
            }
            catch (MiExcepcion e)
            {
                Exception ex = e;
                do
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                } while (!object.ReferenceEquals(ex, null));
            }

            Console.ReadKey();
        }
    }
}
