using System;

namespace Ejercicio11_POO
{
    class MemoriaRam : Hardware
    {
        public int _capacidadGB;

        public MemoriaRam(string nombre, string fabricante,
                                             int capacidadGb) 
                                   : base(nombre, fabricante)
        {
            this._capacidadGB = capacidadGb;
        }
        
        public void mostrarDetallesRam()
        {
            this.mostrarInformacion();
            Console.WriteLine("Capacidad en GB: " + this._capacidadGB);
        }
    }
}