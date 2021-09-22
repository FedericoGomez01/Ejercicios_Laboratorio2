using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_Ejercicio23Biblioteca
{
    public class Dolar
    {
        //Generamos los atributos para Dolar 
        private double cantidad;
        private static double cotizRespectoDolar;

        //Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        //Getters
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
                return Dolar.cotizRespectoDolar;
            }
        }

        //Sobrecarga implicita

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
            //Ejecuta el constructor que le passo el double y me retorna la cantidad
        }

        //Sobrecargas explicitas
        public static explicit operator Peso(Dolar d)
        {
            return new Peso((d.cantidad * Peso.GetCotizacion));
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.cantidad * Euro.GetCotizacion));
        }

        //sobrecargas de operadores y  
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad == d2.GetCantidad);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d == (Euro)e);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad == ((Dolar)p).GetCantidad);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad + ((Dolar)e).GetCantidad));
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad + ((Dolar)p).GetCantidad));
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad - ((Dolar)e).GetCantidad));
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad - ((Dolar)p).GetCantidad));
        }

    }
}
