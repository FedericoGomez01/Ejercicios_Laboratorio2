using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio12
{
    public static class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool rtn;
            if (char.Parse("s") == c || char.Parse("S") ==  c)
            {
                rtn = true;
            }
            else
            {
                rtn = false;
            }

            return rtn;
            
        }
    }
}
