using System;

namespace Ejercicio10_POO
{
    class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
            
        }

        public void ladrar()
        {
            Console.WriteLine(this._nombre + ": Gua Gua");
        }
        
    }
}