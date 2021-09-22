using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;


        private Estante(int capacidad) 
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
            
        }

        public static string MostrarEstante(Estante e)
        {
            string aux = string.Empty;
            foreach (Producto auxProducto in e.productos)
            {
                aux += Producto.MostrarProducto(auxProducto);
            }

            return aux;
        }

        public static bool operator ==(Estante e, Producto p)
        {

            foreach (Producto auxProducto in e.productos)
            {
                if(!(object.ReferenceEquals(auxProducto, null)))
                {
                    if (auxProducto == p)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e,Producto p)
        {
            bool aux =false;
            for (int i = 0; i < (e.productos.Length); i++)
            {
                if (object.ReferenceEquals(e.productos[i], null) && e != p)
                {
                    e.productos[i] = p;
                    aux = true;
                }

            }
            return aux;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            Estante aux = e;
            for (int i = 0; i < (aux.productos.Length); i++)
            {
                if (e == p)
                {
                    aux.productos[i] = null;
                }
            }
            return aux;
        }
    }
}
