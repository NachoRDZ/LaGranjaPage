using Dominio.Comun;

namespace Dominio.Entidades
{
    public class Vacuna
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Patogeno { get; set; }

        public Vacuna(string nombre, string descripcion, string patogeno)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Patogeno = patogeno;
        }

        public void Validar()
        {
            ValidarNombre();
            ValidarDescripcion();
            ValidarPatogeno();
        }

        private void ValidarNombre()
        {
            if (!Utilidades.StringValido(Nombre))
            {
                throw new Exception("El Nombre no puede ser vacio.");
            }
        }

        private void ValidarDescripcion()
        {
            if (!Utilidades.StringValido(Descripcion))
            {
                throw new Exception("La Descripcion no puede ser vacio.");
            }
        }

        private void ValidarPatogeno()
        {
            if (!Utilidades.StringValido(Patogeno))
            {
                throw new Exception("El Patogeno no puede ser vacio.");
            }
        }
    }
}
