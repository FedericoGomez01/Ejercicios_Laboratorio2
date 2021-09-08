using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Sobrecargas
{
    public class Automovil
    {
        public int velocidadActual;
        public string marca;
        
        public Automovil():this(1)
        {
        }

        public Automovil(int velocidadInicial)
        {
            this.velocidadActual = velocidadInicial;
        }

        public Automovil(string velocidadInicial): this(int.Parse(velocidadInicial))
        {
        }

        public Automovil(string marca, int velocidadActal): this (velocidadActal)
        {
            this.marca = marca;
        }


        public void Acelerar()
        {
            this.velocidadActual++;
        }

        public void Acelerar(int incremento)
        {
            this.velocidadActual += incremento;
        }


        public static Automovil operator +(Automovil a, int incremento)
        {
            a.velocidadActual += incremento;
            return a;
        }

        public static bool operator == (Automovil a, int velocidad)
        {
            return a.velocidadActual == velocidad;
        }

        public static bool operator !=(Automovil a, int velocidad)
        {
            return !(a == velocidad);
        }

        public static explicit operator int (Automovil a)
        {
            return a.velocidadActual;
        }
    }
}
