using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca
        {
            get
            {
                return this.marca;
            }

        }

        public float GetPrecio
        {
            get
            {
                return this.precio;
                //falta codigo de barra 
            }

        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DEL PRODUCTO");
            sb.AppendLine("MARCA: " + p.marca);
            sb.AppendLine("PRECIO: " + p.precio);
            sb.AppendLine("CODIGO DE BARRA: " + p.codigoDeBarra);

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool aux;
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                aux = true;
            }
            else
            {
                aux = false;
            }
            return aux;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string c)
        {
            bool aux;
            if (p1.codigoDeBarra == c)
            {
                aux = true;
            }
            else
            {
                aux = false;
            }
            return aux;
        }

        public static bool operator !=(Producto p1, string c)
        {
            return !(p1 == c);
        }


    }

}
