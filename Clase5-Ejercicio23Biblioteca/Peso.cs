using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_Ejercicio23Biblioteca
{
    public class Peso
    {
        //Generamos los atributos para Peso 
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso()
        {
            Peso.cotizRespectoDolar = 180;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }
        public static void setCotizaicon(double cotizacion)
        {
            Peso.cotizRespectoDolar = cotizacion;

        }
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
                return Peso.cotizRespectoDolar;
            }
        }

        //Sobrecargas implicitas
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }

        //Sobrecargas explicitas
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.GetCantidad / Peso.GetCotizacion));
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        //sobrecargas de operadores  
        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.GetCantidad == p2.GetCantidad);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return (p.GetCantidad == ((Peso)d).GetCantidad);
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (p.GetCantidad == ((Peso)e).GetCantidad);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad - ((Peso)d).GetCantidad);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad - ((Peso)e).GetCantidad);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad + ((Peso)d).GetCantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad + ((Peso)e).GetCantidad);
        }

    }
}
