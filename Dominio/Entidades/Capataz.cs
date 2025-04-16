using System.Threading;

namespace Dominio.Entidades
{
    public class Capataz : Empleado
    {
        public int CantPersonas { get; set; }

        public Capataz(int cantPersonas, string email, string contrasenia, string nombre, DateTime fechaIngreso) : base(email, contrasenia, nombre, fechaIngreso)
        {
            CantPersonas = cantPersonas;
        }

        public override void Validar()
        {
            base.Validar();
        }

        public override string MostrarEsResidente()
        {
            return "no";
        }

        public override IEnumerable<Tarea> ListarTareas()
        {
            return null;
        }

        public override IEnumerable<Tarea> ListarTareasIncompletas()
        {
            return null;
        }

        public override string Rol()
        {
            return "Capataz";
        }

        public override void AgregarTarea(Tarea tarea) {}
    }
}
