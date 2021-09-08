using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Esercicio21Biblioteca
{
    public class Fahrenheit
    {
        #region Atributo
        private double temperatura;
        #endregion

        #region Constructor
        public Fahrenheit(double temperatura)
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
        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetTemperatura() + 459.67) * 5 / 9);
        }

        public static explicit operator Celcius(Fahrenheit f)
        {
            return new Celcius((f.GetTemperatura() - 32) * 5 / 9);
        }

        public static bool operator == (Fahrenheit f1, Fahrenheit f2)
        {
            return (f1.GetTemperatura() == f2.GetTemperatura());
        }

        public static bool operator != (Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f, Celcius c)
        {
            return (f.GetTemperatura() == ((Fahrenheit)c).GetTemperatura());
        }

        public static bool operator !=(Fahrenheit f, Celcius c)
        {
            return !(f==c);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return (f.GetTemperatura() == ((Fahrenheit)k).GetTemperatura());
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f==k);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celcius c)
        {
            return (f.GetTemperatura() + ((Fahrenheit)c).GetTemperatura());
        }

        public static Fahrenheit operator -(Fahrenheit f, Celcius c)
        {
            return (f.GetTemperatura() - ((Fahrenheit)c).GetTemperatura());
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return (f.GetTemperatura() + ((Fahrenheit)k).GetTemperatura());
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return (f.GetTemperatura() - ((Fahrenheit)k).GetTemperatura());
        }
        #endregion

    }
}
