
namespace Sistema_de_nomina
{
    public class Empleado_Por_Comision : Empleado
    {
        public string primerNombre;
        public decimal ventasBrutas;
        public decimal tarifaComision;

        public Empleado_Por_Comision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision)
        : base(apellidoPaterno, numeroSeguroSocial)
        {
            this.primerNombre = primerNombre;
            Ventasbrutas = ventasBrutas;
            Tarifacomision = tarifaComision;

        }

        public decimal Ventasbrutas
        {
            get { return ventasBrutas; }
            set { ventasBrutas = (value >= 0) ? value : 0; }
        }

        public decimal Tarifacomision
        {
            get { return tarifaComision; }
            set { tarifaComision = (value > 0 && value < 1) ? value : 0;  }
        } 

        public override decimal PagoEmpleado() 
        {
            return Tarifacomision * Ventasbrutas;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Primer nombre : {primerNombre}");
            base.MostrarDatos(); 
            Console.WriteLine($"Ventas Brutas : {Ventasbrutas}");
            Console.WriteLine($"Tarifa Comision : {Tarifacomision}");
        }

        public override void Actualizar()
        {
            Console.Write("Nuevas ventas brutas: ");
            Ventasbrutas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Nueva tarifa comision: ");
            Tarifacomision = Convert.ToDecimal(Console.ReadLine());

        }


    }
}
