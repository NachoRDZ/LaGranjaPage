using Dominio.Comun;
using Dominio.Interfaces;

namespace Dominio.Entidades
{
    public abstract class Empleado : IValidable, IEquatable<Empleado>
    {
        public int Id { get; set; }

        private static int UltId { get; set; }

        public string Email { get; set; }

        public string Contrasenia { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Empleado() { }
        public Empleado(string email, string contrasenia, string nombre, DateTime fechaIngreso)
        {
            Id = UltId++;
            Email = email;
            Contrasenia = contrasenia;
            Nombre = nombre;
            FechaIngreso = fechaIngreso;
        }

        public virtual void Validar()
        {
            ValidarEmail();
            ValidarContrasenia();
            ValidarNombre();
            ValidarFechaIngreso();
        }

        public abstract string Rol();

        public abstract string MostrarEsResidente();

        public abstract void AgregarTarea(Tarea tarea);
        public abstract IEnumerable<Tarea> ListarTareas();
        public abstract IEnumerable<Tarea> ListarTareasIncompletas();

        private void ValidarEmail()
        {
            if (!Utilidades.StringValido(Email))
            {
                throw new Exception("El Email no puede ser vacio.");
            }
        }

        private void ValidarContrasenia()
        {
            if (!Utilidades.StringValido(Contrasenia))
            {
                throw new Exception("La Contraseña no puede ser vacia y debe contener un minimo de 8 caracteres.");
            }
        }

        private void ValidarNombre()
        {
            if (!Utilidades.StringValido(Nombre))
            {
                throw new Exception("El Nombre no puede ser vacio.");
            }
        }

        private void ValidarFechaIngreso()
        {
            if (FechaIngreso > DateTime.Today || FechaIngreso == DateTime.MinValue)
            {
                throw new Exception("Debe seleccionar una fecha de ingreso válida");
            }
        }

        public bool Equals(Empleado? other)
        {
            return other != null && Nombre == other.Nombre;
        }

        
    }
}
