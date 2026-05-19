
namespace Sistema_de_nomina
{   
    public abstract class Empleado
    {
        private String apellidoPaterno { get; set; }
        private String numeroSeguroSocial { get; set; }

        public Empleado(string apellidoPaterno, string numeroSeguroSocial)
        {
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }

        public abstract decimal Ingresos();

        public override string ToString()
        {
            return "Object";
        }

    }
}
