using System;
using Ejercicio3_POO;

namespace Ejercicio3_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // objeto de la clase Bebida
            Bebida bebida = new Bebida("Coca Cola", 1000);
            bebida.Beberse(100);
            Console.Write("Objeto Bebida -> ");
            Console.WriteLine(bebida.Cantidad);
            Console.WriteLine("----------------------");
            
            // objeto de la clase Cerveza
            Cerveza cerveza = new Cerveza();
            cerveza.Beberse(100);
            Console.Write("Objeto Cerveza -> ");
            Console.WriteLine(cerveza.Cantidad);
        }
    }
}