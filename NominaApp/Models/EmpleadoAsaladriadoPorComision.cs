using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaApp.Models;


public class EmpleadoAsaladriadoPorComision : EmpleadoPorComision
{
    public decimal SalarioBase { get; set; }
    public EmpleadoAsaladriadoPorComision(string nombre, string apellido, string ssn,
        decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
        : base(nombre, apellido, ssn, ventasBrutas, tarifaComision)
    {
        SalarioBase = salarioBase;
    }
    public override decimal CalcularPago()
    {
        decimal pagoPorComision = base.CalcularPago();
        return pagoPorComision + SalarioBase + (SalarioBase * 0.10m);
    }
    public override string TipoEmpleado() => "Asalariado por Comisión";

}
