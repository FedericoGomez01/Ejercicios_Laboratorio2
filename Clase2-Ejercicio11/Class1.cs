using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio11
{
    public static class Validacion
    {
        public static bool Validar(int a, int b, int c)
        {
            bool rtn = false;

            if(a>c || a < b)
            {
                rtn = false;
            }
            else
            {
                rtn = true; 
            }
            return rtn;
        }
    }
}
