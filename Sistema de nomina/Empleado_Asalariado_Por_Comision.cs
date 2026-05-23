
namespace Sistema_de_nomina
{
    public class Empleado_Asalariado_Por_Comision : Empleado_Por_Comision
    {
        private decimal salarioBase;

        public Empleado_Asalariado_Por_Comision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
        : base(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision)
        {
            Salariobase = salarioBase; 
        }

        public decimal Salariobase
        {
            get {  return salarioBase; }
            set { salarioBase = (value >= 0) ? value : 0; }
        }

        public override decimal PagoEmpleado()
        {
            return (Ventasbrutas * Tarifacomision) + Salariobase + (Salariobase * 0.10m);
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Primer nombre : {primerNombre}");
            base.MostrarDatos();
            Console.WriteLine($"Salario Base : {Salariobase}");
        }

        public override void Actualizar()
        {
            Console.Write("Nuevas ventas brutas: ");
            Ventasbrutas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Nueva tarifa comision: ");
            Tarifacomision = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Nuevo salario base: ");
            Salariobase = Convert.ToDecimal(Console.ReadLine());

        }

    }
}
