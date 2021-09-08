using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campos
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        /// <summary>
        /// Clacula la nota final, no recibe parametro y retorna void
        /// </summary>
        public void CalcularFinal()
        {
            if(this.nota1 >3 && this.nota2>3)
            {
                Random random = new Random();

                this.notaFinal = random.Next(10, 4);
            }
            else
            {
                this.notaFinal = -1;
            }

        }


        public void Estudiar(byte notaUno, byte notaDos)
        {
    
            this.nota1 = notaUno;
            this.nota2 = notaDos;
 
        }

        public string Mostrar()
        {
            if(notaFinal != -1)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }
        }

    }
}
