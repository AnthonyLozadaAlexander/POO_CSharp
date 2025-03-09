using System;

namespace Ejercicio10_POO
{
    class Animal
    {     
        // Atributos
        protected string _nombre;

        // Metodo constructor
        public Animal(string nombre) 
        {
            _nombre = nombre;
        }

        public void obtener_nombre()
        {
            Console.WriteLine("El nombre del animal es: " + _nombre);
        }
        
        protected void EmitirSonido()
        {
            Console.WriteLine("Este animal hace sonido");
        }
    }
    
}