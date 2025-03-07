using System;

namespace Ejercicio4_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Concesionario concesionario = new Concesionario(10);
            
            Coche c1 = new Coche(1, "BMW", "4", 1000, 12000);
            Coche c2 = new Coche(2, "Toyota", "4", 0, 12000);
            Coche c3 = new Coche(3, "Seat", "4", 2000, 15000);
            Coche c4 = new Coche(4, "Ferrari", "4", 1000, 20000);
            Coche c5 = new Coche(5, "Peugeout", "4", 100000, 30000);

            concesionario.addCoche(c1);
            concesionario.addCoche(c2);
            concesionario.addCoche(c3);
            concesionario.addCoche(c4);
            concesionario.addCoche(c5);
            
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Todos los coches: ");
            concesionario.showCoches();
            Console.WriteLine("---------------------------------------------------------------");
            
            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("Eliminacion del coche c3 y c1: ");
            concesionario.deleteCoche(c3);
            concesionario.deleteCoche(c1);
            concesionario.showCoches();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Añadir Coche c3 y c1: ");
            concesionario.addCoche(c3);
            concesionario.addCoche(c1);
            concesionario.showCoches();
            Console.WriteLine("---------------------------------------------------------------");
            
            concesionario.emptyCoches();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("vacio");
            Console.WriteLine("---------------------------------------------------------------");
            concesionario.showCoches();

            Console.ReadLine();
        }
    }
}