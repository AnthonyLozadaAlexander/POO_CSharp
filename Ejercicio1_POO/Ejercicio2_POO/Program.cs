using System;

namespace Ejercicio2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // main code
            // Instancia de la clase persona, Creacion De Objeto
            Persona objPersona = new Persona();
            objPersona.crearPersona("Juan", 25, "12/12/1996");

            Console.WriteLine("Nombre: " + objPersona.Nombre + " Edad: " + objPersona.Edad + " Fecha Nacimiento: " + 
                objPersona.FechaNacimiento);

            Console.ReadLine();
        }
    }
}