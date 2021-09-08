using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Esercicio21Biblioteca
{
    public class Kelvin
    {
        #region Atributo
        private double temperatura;
        #endregion

        #region Constructor
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        #endregion

        #region Get
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        #endregion

        #region Operadores
        public static implicit operator Kelvin(double k)
        {
            return new Kelvin(k);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.GetTemperatura() * 9 / 5 - 459.67);
        }

        public static explicit operator Celcius(Kelvin k)
        {
            return new Celcius((((Fahrenheit)k).GetTemperatura() - 32) * 5 / 9);
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return (k1.GetTemperatura() == k2.GetTemperatura());
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (k.GetTemperatura() == ((Kelvin)f).GetTemperatura());
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator ==(Kelvin k, Celcius c)
        {
            return (k.GetTemperatura() == ((Kelvin)c).GetTemperatura());
        }

        public static bool operator !=(Kelvin k, Celcius c)
        {
            return !(k == c);
        }

        public static Fahrenheit operator +(Kelvin k, Fahrenheit f)
        {
            return (k.GetTemperatura() + ((Kelvin)f).GetTemperatura());
        }

        public static Fahrenheit operator -(Kelvin k, Fahrenheit f)
        {
            return (k.GetTemperatura() - ((Kelvin)f).GetTemperatura());
        }

        public static Fahrenheit operator +(Kelvin k, Celcius c)
        {
            return (k.GetTemperatura() + ((Kelvin)c).GetTemperatura());
        }

        public static Fahrenheit operator -(Kelvin k, Celcius c)
        {
            return (k.GetTemperatura() - ((Kelvin)c).GetTemperatura());
        }
        #endregion

    }
}
