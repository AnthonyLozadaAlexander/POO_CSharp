using System;

namespace Ejercicio1_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche ObjCarro = new Coche(1, "KIA", "4", 100, 12000);

            Console.WriteLine(ObjCarro.precio);

            Console.WriteLine(ObjCarro.marca);


            ObjCarro.precio = 15000;

            Console.WriteLine(ObjCarro.precio);

            Console.WriteLine(ObjCarro.ToString());


            Console.ReadLine();

        }
    }
}
