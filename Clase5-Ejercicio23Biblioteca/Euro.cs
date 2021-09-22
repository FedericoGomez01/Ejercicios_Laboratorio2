using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_Ejercicio23Biblioteca
{
    public class Euro
    {
        //Atributos
        private double cantidad;
        private static double cotizRespectoDolar;

        //constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1/1.18;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static void setCotizaicon(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
            
        }

        //getters
        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public static double GetCotizacion
        {
            get
            {
                return Euro.cotizRespectoDolar;
            }
        }

        //implicit operator 
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        //explicit operator
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((e.cantidad / Euro.GetCotizacion));
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e); //reutilizo operador explicito de dolar y lo casteo explicitamente a peso
        }

        //sobrecargas de operadores  

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad == e2.GetCantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad == ((Euro)d).GetCantidad);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (e.GetCantidad == ((Euro)p).GetCantidad);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad - ((Euro)d).GetCantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad - ((Euro)p).GetCantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad + ((Euro)d).GetCantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad + ((Euro)p).GetCantidad);
        }

    }
}
