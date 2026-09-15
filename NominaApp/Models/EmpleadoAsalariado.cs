

namespace NominaApp.Models;

public class EmpleadoAsalariado : Empleado
{
    public decimal Salario { get; set; }
    public EmpleadoAsalariado
        (string nombre, string apellido, decimal salario, string ssn = "")
        : base(nombre, apellido, ssn)
    {
        Salario = salario;
    }
    public override decimal CalcularPago()
    {
        return Salario;
    }
    public override string TipoEmpleado()
    {
        return "Empleado Asalariado";
    }
}


