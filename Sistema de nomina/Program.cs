namespace Sistema_de_nomina
{
    internal class Program
    {
        static List<Empleado> empleados = new List<Empleado>();
        static void Main(string[] args)
        {
            int opcion;

            // Agregue uno default de prueba 
            empleados.Add(new Empleado_Asalariado("Pedro","Lantigua","1239292",100000));

            do
            {
                Console.WriteLine("Sistema para Nomina");
                Console.WriteLine("1. Agregar Empleado Asalariado");
                Console.WriteLine("2. Agregar Empleado Por Horas");
                Console.WriteLine("3. Agregar Empleado Por Comision");
                Console.WriteLine("4. Agregar Empleado Asalariado Por Comision");
                Console.WriteLine("5. Mostrar Reporte");
                Console.WriteLine("6. Actualizar Empleado");
                Console.WriteLine("7. Salir");
                

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Opcion no valida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarEmpleadoAsalariado();
                        break;

                    case 2:
                        AgregarEmpleadoPorHoras();
                        break;

                    case 3:
                        AgregarEmpleadoPorComision();
                        break;

                    case 4:
                        AgregarEmpleadoAsalariadoPorComision();
                        break;

                    case 5:
                        MostrarReporte();
                        break;
                    case 6:
                        ActualizarEmpleado();
                        break;
                }

            } while (opcion != 7);
        }

        //para evitar la advertencia del tipo string y errores por dejarlo vacio 
        static string LeerTexto(string mensaje)
        {
            string valor;
            do
            {
                Console.Write(mensaje);
                valor = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(valor))
                    Console.WriteLine("rellene el campo por favor.");

            } while (string.IsNullOrWhiteSpace(valor));

            return valor;
        }
        static void AgregarEmpleadoAsalariado()
        {
            Console.WriteLine(" ");
            string primerNombre = LeerTexto("Primer nombre: ");

            string apellido = LeerTexto("Apellido paterno: ");

            string seguro = LeerTexto("Numero seguro social: ");

            Console.Write("Salario semanal: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");

            empleados.Add(new Empleado_Asalariado(primerNombre,apellido,seguro,salario));

        }

        static void AgregarEmpleadoPorHoras()
        {
            Console.WriteLine(" ");
            string apellido = LeerTexto("Apellido paterno: ");

            string seguro = LeerTexto("Numero seguro social: ");

            Console.Write("sueldo: ");
            decimal sueldo = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Horas trabajadas: ");
            decimal horas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");

            empleados.Add( new Empleado_Por_Horas(apellido,seguro,sueldo,horas));
        }

        static void AgregarEmpleadoPorComision()
        {
            Console.WriteLine(" ");
            string primerNombre = LeerTexto("Primer nombre: ");

            string apellido = LeerTexto("Apellido paterno: ");

            string seguro = LeerTexto("Numero seguro social: ");

            Console.Write("Ventas brutas: ");
            decimal ventas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Tarifa comision: ");
            decimal tarifa = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");

            empleados.Add(new Empleado_Por_Comision(primerNombre,apellido,seguro,ventas,tarifa));
        }

        static void AgregarEmpleadoAsalariadoPorComision()
        {
            Console.WriteLine(" ");
            string primerNombre = LeerTexto("Primer nombre: ");
            string apellido = LeerTexto("Apellido paterno: ");
            string seguro = LeerTexto("Numero seguro social: ");

            Console.Write("Ventas brutas: ");
            decimal ventas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Tarifa comision: ");
            decimal tarifa = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Salario base: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");

            empleados.Add( new Empleado_Asalariado_Por_Comision( primerNombre, apellido,seguro,ventas,tarifa,salarioBase));
        }

        static void ActualizarEmpleado()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Busque por:");
            Console.WriteLine("1-Numero de seguro social");
            Console.WriteLine("2-Apellido paterno");

            string opcionbuscar = Console.ReadLine()!;

            if (opcionbuscar != "1" && opcionbuscar != "2")
            {
                Console.WriteLine("Opcion no valida.");
                return;
            }

            Console.WriteLine(opcionbuscar == "1" ? "Introduzca el numero de seguro social:" : "Introduzca el apellido paterno:");
            string busqueda = Console.ReadLine()!;

            foreach (Empleado empleado in empleados)
            {
                bool encontrado =
                    opcionbuscar == "1"
                    ? empleado.numeroSeguroSocial == busqueda
                    : empleado.apellidoPaterno == busqueda;

                if (encontrado)
                {
                    empleado.Actualizar();

                    Console.WriteLine("Empleado actualizado");
                    Console.WriteLine("");
                    return;
                }
            }

            Console.WriteLine("No existe un Empleado con esos datos por favor ingrese otro");
            Console.WriteLine(" ");
        }

        static void MostrarReporte()
        {
            Console.WriteLine("----------Reporte de la Semana--------");
            Console.WriteLine("");

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"Empleado de tipo: {empleado.GetType().Name}");
                empleado.MostrarDatos();
                Console.WriteLine($"Pago Semanal: {empleado.PagoEmpleado()}");
                Console.WriteLine(" ");
            }
        }

        
    }
}