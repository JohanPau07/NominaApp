# \# Sistema de Nómina

# 

# \### ¿Qué hace este sistema?

# 

# Sistema de consola dirigido al departamento de Recursos Humanos para gestionar

# los pagos semanales de los empleados. Permite registrar, actualizar y generar

# reportes de nómina para cuatro tipos de empleado: asalariado, por horas, por

# comisión, y asalariado por comisión — cada uno con su propia fórmula de cálculo

# de pago.

# 

# \### Estructura del proyecto

# 

# ```

# NominaApp/

# ├── Models/

# │   ├── Empleado.cs

# │   ├── EmpleadoAsalariado.cs

# │   ├── EmpleadoAsalariadoPorComision.cs

# │   ├── EmpleadoPorComision.cs

# │   └── EmpleadoPorHoras.cs

# ├── Services/

# │   └── GestorNomina.cs

# └── Program.cs

# ```

# 

# \### Cómo ejecutarlo

# 

# \*\*Requisitos\*\*

# 

# \- Visual Studio 2022 o superior

# \- .NET 8.0 (LTS)

# 

# \*\*Pasos\*\*

# 

# 1\. Clonar el repositorio

# 2\. Abrir `NominaApp.sln` en Visual Studio

# 3\. Presionar `F5` o `Ctrl + F5` para ejecutar

# 

# \### Funcionalidades

# 

# \- Registrar empleados de los 4 tipos, cada uno con los datos específicos que le corresponde capturar

# \- Listar todos los empleados registrados

# \- Actualizar los datos de un empleado existente (el pago se recalcula automáticamente)

# \- Generar un reporte semanal con el pago de cada empleado y el total de la nómina

# 

# \### Conceptos aplicados

# 

# \- \*\*Clase abstracta\*\* — `Empleado` define el contrato común (`CalcularPago()`, `TipoEmpleado()`) sin saber cómo calcular un pago genérico, forzando a cada subtipo a implementarlo

# \- \*\*Herencia\*\* — los 4 tipos de empleado heredan de `Empleado`; `EmpleadoAsalariadoPorComision` además hereda de `EmpleadoPorComision`, reutilizando su cálculo de comisión

# \- \*\*Polimorfismo\*\* — `GestorNomina` recorre una única `List<Empleado>` y llama `CalcularPago()` sin saber de qué tipo específico es cada objeto; cada uno ejecuta su propia fórmula

# \- \*\*Encapsulamiento\*\* — la lista de empleados es privada dentro de `GestorNomina`; solo se accede a través de métodos públicos controlados (`AgregarEmpleado`, `BuscarPorSSN`)

# \- \*\*Principio Open/Closed\*\* — se puede agregar un nuevo tipo de empleado (una clase más que herede de `Empleado`) sin modificar el código ya existente

# 

# \### Autor

# 

# \*\*Johan Carlos Paulino Segura\*\*

# Matrícula: 2025-1187

# 

