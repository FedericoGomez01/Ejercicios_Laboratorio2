using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Esercicio21Biblioteca
{
    public class Celcius
    {

        #region Atributo
        private double temperatura;
        #endregion

        #region Constructor
        public Celcius(double temperatura)
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
        public static implicit operator Celcius(double k)
        {
            return new Celcius(k);
        }

        public static explicit operator Fahrenheit(Celcius c)
        {
            return new Fahrenheit(c.GetTemperatura() * 1.8 + 32);
        }

        public static explicit operator Kelvin(Celcius c)
        {
            return new Kelvin(((Fahrenheit)c).GetTemperatura() + 459.67*59);
        }

        public static bool operator ==(Celcius c1, Celcius c2)
        {
            return (c1.GetTemperatura() == c2.GetTemperatura());
        }

        public static bool operator !=(Celcius c1, Celcius c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Celcius c ,Fahrenheit f)
        {
            return (c.GetTemperatura() == ((Celcius)f).GetTemperatura());
        }

        public static bool operator !=(Celcius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator ==(Celcius c, Kelvin k)
        {
            return (c.GetTemperatura() == ((Celcius)k).GetTemperatura());
        }

        public static bool operator !=(Celcius c, Kelvin k)
        {
            return !(c == k);
        }

        public static Fahrenheit operator +(Celcius c, Fahrenheit f)
        {
            return (c.GetTemperatura() + ((Celcius)f).GetTemperatura());
        }

        public static Fahrenheit operator -(Celcius c, Fahrenheit f)
        {
            return (c.GetTemperatura() - ((Celcius)f).GetTemperatura());
        }

        public static Fahrenheit operator +(Celcius c, Kelvin k)
        {
            return (c.GetTemperatura() + ((Celcius)k).GetTemperatura());
        }

        public static Fahrenheit operator -(Celcius c, Kelvin k)
        {
            return (c.GetTemperatura() - ((Celcius)k).GetTemperatura());
        }
        #endregion

    }
}
