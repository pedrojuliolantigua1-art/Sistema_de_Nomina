
namespace Sistema_de_nomina
{
    public abstract class Empleado
    {
        private String apellidoPaterno { get; set; }
        private String numeroSeguroSocial { get; set; }

        public abstract decimal Ingresos();

    }
}
