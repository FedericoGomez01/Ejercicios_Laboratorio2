using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_ejercicio19Clases
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int n)
        {
            this.cantidadSumas = n;
        }

        public Sumador():this(0)
        { }


        public void Sumar()
        {
            this.cantidadSumas += 1;
        }

        public long Sum(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sum(string a, string b) 
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }




    }
}
