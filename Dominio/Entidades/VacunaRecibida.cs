
namespace Dominio.Entidades
{
    public class VacunaRecibida
    {
        public Vacuna TipoVacuna { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Vencimiento { get; set; }

        public VacunaRecibida(Vacuna vacuna, DateTime fecha, DateTime vencimiento)
        {
            TipoVacuna = vacuna;
            Fecha = fecha;
            Vencimiento = vencimiento;
        }

        public virtual void Validar()
        {
            ValidarFecha();
            ValidarVencimiento();
        }

        private void ValidarFecha()
        {
            if (Fecha > DateTime.Today || Fecha == DateTime.MinValue)
            {
                throw new Exception("Debe seleccionar una fecha de realizacion válida");
            }
        }

        private void ValidarVencimiento()
        {
            if (Vencimiento == DateTime.MinValue)
            {
                throw new Exception("Debe seleccionar una fecha de realizacion válida");
            }
        }

        public VacunaRecibida() { }
    }
}
