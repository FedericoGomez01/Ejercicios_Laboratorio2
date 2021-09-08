using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public static class MiClase
    {
        public static string Mensaje(int i)
        {
            //return "Este es mi orimer metodo estatico: " + i  ;
            return string.Format("Este es mi orimer metodo estatico: {0}, {1}" , i ,
            DateTime.Now.ToString());

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Este es mi primer metodo estatico");
            //sb.AppendLine(i.ToString());
            //return sb.ToString();


        }
    }
}
