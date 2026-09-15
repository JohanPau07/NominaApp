

namespace NominaApp.Models;

public abstract class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set;}
    public string SSN { get; set; }

    protected Empleado (string apellido, string ssn, string nombre = "")
    {
        Nombre = nombre;
        Apellido = apellido;
        SSN = ssn;
    }
    public abstract decimal CalcularPago();

    public abstract string TipoEmpleado();

}




