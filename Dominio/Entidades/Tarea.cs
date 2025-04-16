using Dominio.Comun;

namespace Dominio.Entidades
{
    public class Tarea : IComparable<Tarea>
    {
        public int Id { get; set; }

        private static int UltId { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaRealizacion { get; set; }

        public bool TareaCompleta { get; set; }

        public DateTime FechaCierre { get; set; }

        public string Comentario { get; set; }
        public Tarea() { }

        public Tarea(string descripcion, DateTime fechaRealizacion, bool tareaCompleta, DateTime fechaCierre, string comentario)
        {
            Id = UltId++;
            Descripcion = descripcion;
            FechaRealizacion = fechaRealizacion;
            TareaCompleta = tareaCompleta;
            FechaCierre = fechaCierre;
            Comentario = comentario;
        }

        public virtual void Validar()
        {
            ValidarDescripcion();
            ValidarFechaRealizacion();
            ValidarComentario();
        }

        private void ValidarDescripcion()
        {
            if (!Utilidades.StringValido(Descripcion))
            {
                throw new Exception("El Email no puede ser vacio.");
            }
        }

        private void ValidarFechaRealizacion()
        {
            if (FechaRealizacion > DateTime.Today || FechaRealizacion == DateTime.MinValue)
            {
                throw new Exception("Debe seleccionar una fecha de realizacion válida");
            }
        }

        private void ValidarComentario()
        {
            if (!Utilidades.StringValido(Comentario))
            {
                throw new Exception("El Email no puede ser vacio.");
            }
        }

        public int CompareTo(Tarea? other)
        {
            if (other == null)
            {
                return -1;
            }
            return FechaRealizacion.CompareTo(other.FechaRealizacion);
        }
    }
}
