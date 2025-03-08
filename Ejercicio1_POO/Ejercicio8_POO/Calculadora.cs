using System;

namespace Ejercicio8_POO
{
    public class Calculadora
    {
        //Atributos
        public double valor1;
        public double valor2;
        public int Opcion;

        // Metodos
        public double sumar()
        {
            return this.valor1 + this.valor2;
        }

        public double restar()
        {
            return this.valor1 - this.valor2;
        }

        public double multiplicar()
        {
            return this.valor1 * this.valor2;
        }

        public double dividir()
        {
            return this.valor1 / this.valor2;
        }

        public void obtenerDatos()
        {
            Console.Write("Ingrese el numero de la opcion: ");
            this.Opcion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el primer valor: ");
            this.valor1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            this.valor2 = double.Parse(Console.ReadLine());
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Calculadora POO");
            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir");
        }

        public void Ejecutar()
        {
            switch (this.Opcion)
            {
                case 1:
                    double suma = this.sumar();
                    Console.WriteLine($"La suma es: {suma}");
                    break;
                
                case 2:
                    double resta = this.restar();
                    Console.WriteLine($"La resta es: {resta}");
                    break;
                case 3:
                    double multiplicacion = this.multiplicar();
                    Console.WriteLine($"La multiplicacion es: {multiplicacion}");
                    break;
                
                case 4:
                    double division = this.dividir();
                    Console.WriteLine($"La division es: {division}");
                    break;
                
                default:
                    Console.WriteLine("Error: Opcion No Valida");
                    break;
                    
            }
        }
    }
}