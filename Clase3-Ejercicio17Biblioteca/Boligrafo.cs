using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Ejercicio17Biblioteca
{
    public class Boligrafo
    {
        
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;


        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            //int diferencia;
            short aux;
            if(this.tinta >0)
            {

                if(gasto > this.tinta)
                {
                    aux = this.tinta;
                }
                else
                {
                    aux = gasto;
                }

                for (int i = 0; i < aux; i++)
                {
                    dibujo += "*";
                }
                SetTinta((short)-gasto);
                return true;

                //diferencia = this.tinta;
                //SetTinta(gasto);
                //if(diferencia != this.tinta)
                //{
                //    diferencia = diferencia - this.tinta;

                //    for (int i = 0; i < diferencia-1; i++)
                //    {
                //        dibujo.Insert(i,"*");
                //    }
                //    return true;
                //}
            }
            return false;
            
        }

        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short valorTinta)
        {
            this.tinta += tinta;
            if (this.tinta < 0)
            {
                this.tinta = 0;
            }else if(this.tinta> cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        private void gastarTinta(short gastar)
        {
            if(gastar < this.tinta && gastar <= cantidadTintaMaxima)
            {
                //no me deja asignar a la consatnte del mismo tipo 
                //cantidadTintaMaxima = (short)(cantidadTintaMaxima - gastar);
                tinta = (short)(tinta - gastar);
            }
        }
    }
}
