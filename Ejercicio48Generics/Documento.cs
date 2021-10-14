using System;
using System.Collections.Generic;

namespace Ejercicio48Generics
{
    public class Documento
    {
        private int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public int Numero { get { return this.numero; } }
    }
}
