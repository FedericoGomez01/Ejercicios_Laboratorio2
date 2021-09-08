using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        private string nombre;
        private int edad;
        public static string tipo;

        static Persona()
        {
            Persona.tipo = "Humano";
        }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

        }
        

        public static void AlterarObjetoRecibido(Persona p4)
        {
            //if(!object.ReferenceEquals(p4, null))
            if(!(p4 is null))
            p4.nombre = "ALTERADO";
        }
        public string GetNombre()
        {
            return this.nombre;

        }

        public int GetEdad()
        {
            return this.edad;
        }

        public string GetTipo()
        {
            return Persona.tipo;
        }
    }
}
