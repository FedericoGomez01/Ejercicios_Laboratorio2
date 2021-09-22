using System;
using clase8_Ejercicio34Bibliotecas;

namespace Clase8_Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoMoto;
            string infoAuto;
            string infoCamion;

            Camion camion = new Camion(14,2,Colores.Rojo,12,36000);
            Automovil auto = new Automovil(4,3,Colores.Azul,6,2);
            Moto moto = new Moto(2,0,Colores.Negro,150);

            //Console.WriteLine(moto.getColor);
            //Console.WriteLine(auto.getColor);
            //Console.WriteLine(camion.getColor);

            infoMoto = moto.Mostrar();
            infoAuto = auto.Mostrar();
            infoCamion = camion.Mostrar();

            Console.WriteLine(infoMoto);
            Console.WriteLine(infoAuto);
            Console.WriteLine(infoCamion);

            
            Console.ReadKey();
        }
    }
}
