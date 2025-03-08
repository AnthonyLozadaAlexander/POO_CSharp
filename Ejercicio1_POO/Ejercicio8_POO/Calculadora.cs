using System;

namespace Ejercicio8_POO
{
    public class Calculadora
    {
        //Atributos
        public double valor1;
        public double valor2;
        public int Opcion;
        public bool salir = false;

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
            Console.WriteLine("Ingrese el numero de la opcion: ");
            this.Opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer valor: ");
            this.valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            this.valor2 = double.Parse(Console.ReadLine());
        }

        public void MostrarMenu()
        {
            Console.WriteLine("\nCalculadora POO");
            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir\n");
        }

        public void Ejecutar()
        {
            switch (this.Opcion)
            {
                case 1:
                    double suma = this.sumar();
                    Console.WriteLine($"\nLa suma es: {suma}\n");
                    break;
                
                case 2:
                    double resta = this.restar();
                    Console.WriteLine($"\nLa resta es: {resta}\n");
                    break;
                case 3:
                    double multiplicacion = this.multiplicar();
                    Console.WriteLine($"\nLa multiplicacion es: {multiplicacion}");
                    break;
                
                case 4:
                    double division = this.dividir();
                    Console.WriteLine($"\nLa division es: {division}\n");
                    break;
                
                default:
                    Console.WriteLine("\nError: Opcion No Valida\n");
                    break;
            }
        }

        public void salirPrograma()
        {
            Console.WriteLine("\nDesea salir del programa?");
            Console.WriteLine("1.- Si");
            Console.WriteLine("0.- No");
            int opc = int.Parse(Console.ReadLine());
            if (opc == 1)
            {
                Console.WriteLine("\nGracias por usar la calculadora");
                this.salir = true;
            }
            else
            {
                this.salir = false;
            }
        }
    }
}