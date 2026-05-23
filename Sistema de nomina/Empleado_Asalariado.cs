
namespace Sistema_de_nomina
{
    public class Empleado_Asalariado : Empleado
    {
        private string primerNombre;
        private decimal salarioSemanal;

        public Empleado_Asalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal)
        : base(apellidoPaterno, numeroSeguroSocial)
        {
            this.primerNombre = primerNombre;
            SalarioSemanal = salarioSemanal;
        }

        public decimal SalarioSemanal
        {
            get { return salarioSemanal; }
            set { salarioSemanal = ((value >= 0) ? value : 0); } 
        }

        public override decimal PagoEmpleado()
        {
            return SalarioSemanal;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Primer nombre : {primerNombre}");
            base.MostrarDatos();
            Console.WriteLine($"El Salario Semanal es : {SalarioSemanal}");
        }

        public override void Actualizar()
        {
            Console.Write("Nuevo salario semanal: ");
            SalarioSemanal = Convert.ToDecimal(Console.ReadLine());

        }


    }
}
