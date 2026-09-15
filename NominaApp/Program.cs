using NominaApp.Models;
using NominaApp.Services;

var gestor = new GestorNomina();
bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("============ SISTEMA DE GESTIÓN DE NÓMINA ============");
    Console.WriteLine("1. Registrar empleado Asalariado");
    Console.WriteLine("2. Registrar empleado Por Horas");
    Console.WriteLine("3. Registrar empleado Por Comisión");
    Console.WriteLine("4. Registrar empleado Asalariado por Comisión");
    Console.WriteLine("5. Listar empleados");
    Console.WriteLine("6. Generar reporte semanal de pagos");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine() ?? "";

    switch (opcion)
    {
        case "1":
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine() ?? "";
                Console.Write("SSN: ");
                string ssn = Console.ReadLine() ?? "";
                Console.Write("Salario semanal: ");
                decimal salario = decimal.Parse(Console.ReadLine() ?? "0");

                var empleado = new EmpleadoAsalariado(nombre, apellido, salario, ssn);
                gestor.AgregarEmpleado(empleado);
                Console.WriteLine("Empleado Asalariado registrado con éxito.");
                break;
            }

        case "2":
            {
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine() ?? "";
                Console.Write("SSN: ");
                string ssn = Console.ReadLine() ?? "";
                Console.Write("Sueldo por hora: ");
                decimal sueldoPorHora = decimal.Parse(Console.ReadLine() ?? "0");
                Console.Write("Horas trabajadas: ");
                decimal horasTrabajadas = decimal.Parse(Console.ReadLine() ?? "0");

                var empleado = new EmpleadoPorHoras(apellido, ssn, sueldoPorHora, horasTrabajadas);
                gestor.AgregarEmpleado(empleado);
                Console.WriteLine("Empleado Por Horas registrado con éxito.");
                break;
            }

        case "3":
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine() ?? "";
                Console.Write("SSN: ");
                string ssn = Console.ReadLine() ?? "";
                Console.Write("Ventas brutas: ");
                decimal ventasBrutas = decimal.Parse(Console.ReadLine() ?? "0");
                Console.Write("Tarifa de comisión (ej. 0.10 para 10%): ");
                decimal tarifaComision = decimal.Parse(Console.ReadLine() ?? "0");

                var empleado = new EmpleadoPorComision(nombre, apellido, ssn, ventasBrutas, tarifaComision);
                gestor.AgregarEmpleado(empleado);
                Console.WriteLine("Empleado Por Comisión registrado con éxito.");
                break;
            }

        case "4":
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine() ?? "";
                Console.Write("SSN: ");
                string ssn = Console.ReadLine() ?? "";
                Console.Write("Ventas brutas: ");
                decimal ventasBrutas = decimal.Parse(Console.ReadLine() ?? "0");
                Console.Write("Tarifa de comisión (ej. 0.10 para 10%): ");
                decimal tarifaComision = decimal.Parse(Console.ReadLine() ?? "0");
                Console.Write("Salario base: ");
                decimal salarioBase = decimal.Parse(Console.ReadLine() ?? "0");

                var empleado = new EmpleadoAsalariadoPorComision(nombre, apellido, ssn, ventasBrutas, tarifaComision, salarioBase);
                gestor.AgregarEmpleado(empleado);
                Console.WriteLine("Empleado Asalariado por Comisión registrado con éxito.");
                break;
            }

        case "5":
            if (gestor.Empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
            }
            else
            {
                foreach (var empleado in gestor.Empleados)
                {
                    Console.WriteLine($"{empleado.Nombre} {empleado.Apellido} | SSN: {empleado.SSN} | {empleado.TipoEmpleado()} | Pago: {empleado.CalcularPago():C2}");
                }
            }
            break;

        case "6":
            gestor.GenerarReporteSemanal();
            break;

        case "0":
            salir = true;
            Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }
}