
namespace NominaApp.Models
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }
        public EmpleadoPorComision(string nombre, string apellido, string ssn,
            decimal ventasBrutas, decimal tarifaComision)
            : base(nombre, apellido, ssn)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }
        public override decimal CalcularPago()
        {
            return VentasBrutas * TarifaComision;
        }
        public override string TipoEmpleado() => "Por Comisión";

    }
}
