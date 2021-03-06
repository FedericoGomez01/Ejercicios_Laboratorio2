using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48Generics
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        //public List<T> MostrarT
        //{
        //    get { return this.egresos; }
        //}
        //public List<U> MostrarU
        //{
        //    get { return this.ingresos; }
        //}

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();

        }
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c , T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.egresos)
            {
                sb.AppendLine("Egreso " + item.Numero);
            }
            foreach (U item in this.ingresos)
            {
                sb.AppendLine("Ingreso " + item.Numero);
            }

            return sb.ToString();
        }
    }
}
