using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42_ExcepcionesBiblioteca
{
    public class MiClase
    {
        private short numUno;
        public MiClase()
        {
            try
            {
                MiClase.miMetodo();
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
        public MiClase(short numUno)
        {
            this.numUno = numUno;
            try
            {
                MiClase mc = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Error excepcion en MiClase", ex);
            }
        }

        static void miMetodo()
        {
            throw new DivideByZeroException();
        }
    }
}
