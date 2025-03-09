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
    }

    class Processador : Hardware
    {
        public Processador(string nombre, string fabricante) : base(nombre, fabricante)
        {
            
        }
        
    }
}