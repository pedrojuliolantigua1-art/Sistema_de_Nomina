namespace Sistema_de_nomina
{
    public class Empleado_Por_Horas : Empleado
    {
        private decimal sueldoPorHora;
        private decimal horas;
        public Empleado_Por_Horas(string apellidoPaterno, string numeroSeguroSocial, decimal sueldoPorHora, decimal horas)
        : base(apellidoPaterno, numeroSeguroSocial)
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horas;
        }

        public decimal SueldoPorHora
        {
            get { return sueldoPorHora; }
            set { sueldoPorHora = (value >= 0) ? value : 0; }
        }

        public decimal HorasTrabajadas  
        {
            get { return horas; }
            set { horas = (value >= 0) ? value : 0; }
        }

        public override decimal PagoEmpleado()
        {
            if (horas <= 40)
            {
                return sueldoPorHora * horas;       
            }
            else
            {
                return (sueldoPorHora * 40) + (sueldoPorHora * 1.5m * (horas - 40));
            }
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Sueldo por hora : {SueldoPorHora}");
            Console.WriteLine($"Horas trabajadas : {HorasTrabajadas}");
        }

        public override void Actualizar()
        {
            Console.Write("Nuevo sueldo por hora: ");
            SueldoPorHora = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Nuevas horas trabajadas: ");
            HorasTrabajadas = Convert.ToDecimal(Console.ReadLine());

        }

    }
}
