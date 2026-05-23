
namespace Sistema_de_nomina
{   
    public abstract class Empleado
    {
        public string apellidoPaterno { get; set; }
        public string numeroSeguroSocial { get; set; }

        public Empleado(string apellidoPaterno, string numeroSeguroSocial)
        {
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }

        public abstract decimal PagoEmpleado();
        public abstract void Actualizar();
        public virtual void MostrarDatos() 
        {
            Console.WriteLine($"Apellido paterno : {apellidoPaterno}");
            Console.WriteLine($"Numero de Seguro Social : {numeroSeguroSocial}");
        }

    }
}
