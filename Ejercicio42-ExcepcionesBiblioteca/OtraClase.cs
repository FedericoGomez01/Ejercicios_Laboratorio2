using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42_ExcepcionesBiblioteca
{
    public class OtraClase
    {
        public void metodoInstancia()
        {
            try
            {
                MiClase m = new MiClase(120);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Estoy desde OtraClase", ex);
            }
        }
    }
}
