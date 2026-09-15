using NominaApp.Models;

namespace NominaApp.Services;

public class GestorNomina
{
    private readonly List<Empleado> _empleados = new();

    public IReadOnlyList<Empleado> Empleados => _empleados;

    public void AgregarEmpleado(Empleado empleado) => _empleados.Add(empleado);

    public Empleado? BuscarPorSSN(string ssn) =>
        _empleados.FirstOrDefault(e => e.SSN == ssn);

    public void GenerarReporteSemanal()
    {
        decimal totalNomina = 0m;  

        foreach (var empleado in _empleados)
        {
            decimal pago = empleado.CalcularPago();
            totalNomina += pago;
            Console.WriteLine($"{empleado.Apellido} | {empleado.TipoEmpleado()} | {pago:C2}");
        }

        Console.WriteLine($"Total nómina: {totalNomina:C2}");
    }
}