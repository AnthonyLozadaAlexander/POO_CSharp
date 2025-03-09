using System;

namespace Ejercicio11_POO
{
    class Processador : Hardware
    {
        public int _nucleos;

        public Processador(string nombre, string fabricante, int nucleos) : base(nombre, fabricante)
        {
            this._nucleos = nucleos;
        }

        public void mostrarDetallesProcessador()
        {
            this.mostrarInformacion();
            Console.WriteLine("Nucleos son: " + this._nucleos);
        }
    }
}