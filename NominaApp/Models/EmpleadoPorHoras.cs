

namespace NominaApp.Models;
public class EmpleadoPorHoras : Empleado
{
    public decimal SueldoPorHora { get; set; } // salario por horas de 230 
    public decimal HorasTrabajadas { get; set; } // horas trabajadas de 40

    private const decimal LimiteHoras = 40m;

    private const decimal HoraExtra = 1.5m;


    public EmpleadoPorHoras(string apellido, string ssn,
        decimal sueldoPorHora, decimal horasTrabajadas)
       : base(apellido, ssn)
    {
        SueldoPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;
    }
    public override decimal CalcularPago()
    {
        if (HorasTrabajadas <= LimiteHoras)
        {
            return SueldoPorHora * HorasTrabajadas;
        }
        decimal horasExtra = HorasTrabajadas - LimiteHoras;
        return (SueldoPorHora * LimiteHoras) + (SueldoPorHora * HoraExtra * horasExtra);
    }
    public override string TipoEmpleado() => "Por Horas";
}
