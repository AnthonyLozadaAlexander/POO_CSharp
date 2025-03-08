using System;
using System.Runtime.CompilerServices;

namespace Ejercicio9_POO
{
    /*Los metodos y los atributos privados
     *son aquellos que solo pueden ser accedidos
     *desde la misma clase
     * que los declara
     */
    
    public class Lampara
    {
        private bool encendido;
        // Metodo Constructor: se llama exactamente igual que la clase es un metodo que se utiliza para inicializar recursos necesarios de tu clase
        public Lampara()
        {
            this.encendido = false;
        }

        private bool estaEncendido()
        {
            return this.encendido;
        }

        public void encender()
        {
            if (!this.encendido)
            {
                this.encendido = true;
                Console.WriteLine("La lampara esta encendida");
            }
            else
            {
                Console.WriteLine("Lampara ya encendida");
            }
        }

        public void apagar()
        {
            if (this.encendido) // si esta encendido
            {
                this.encendido = false;
                Console.WriteLine("La lampara se ha apagado");
            }
            else
            {
                Console.WriteLine("La lampara ya estaba apagada");
            }
        }
        
        public void mostrarEstado()
        {
            if(this.estaEncendido())
            {
                Console.WriteLine("La lampara esta encendida");
            }
            else
            {
                Console.WriteLine("La lampara esta apagada");
            }
        }
    }
}