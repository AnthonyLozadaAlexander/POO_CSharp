namespace Ejercicio2_POO;

public class Persona
{
    private string nombre;
    private int edad;
    private string fechaNacimiento;
    
    // Metodo constructores
    public string Nombre {get => nombre; set => nombre = value; }
    public int Edad {get => edad; set => edad = value; }
    public string FechaNacimiento {get => fechaNacimiento; set => fechaNacimiento = value;}

    // Metodo para crear persona
    public void crearPersona(string _nombre, int _edad, string _fechaNacimiento)
    {
        nombre = _nombre;
        this.edad = _edad;
        fechaNacimiento = _fechaNacimiento;
    }
}