using System;

namespace Ejercicio11_POO
{
    class Hardware
    {
        public string _nombre;
        public string _fabricante;

        public Hardware(string nombre, string fabricante) // Constructor
        {
            _nombre = nombre;
            _fabricante = fabricante;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("Nombre: " + _nombre 
            + " Fabricante: " + this._fabricante);
        }
    }
}