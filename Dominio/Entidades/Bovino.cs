using Dominio.Comun;

namespace Dominio.Entidades
{
    public class Bovino : Animal
    {
        public string TipoAlimentacion { get; set; }

        public decimal PrecioKgEnPie { get; set; }

        public Bovino() { }

        public Bovino(string tipoAlimentacion, decimal precioKgEnPie, string caravana, string sexo, string raza, DateTime fechaNacimiento, decimal costoAdquisicion, decimal costoAlimentacion, int peso, bool esHibrido, string estado) : base(caravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, peso, esHibrido, estado)
        {
            TipoAlimentacion = tipoAlimentacion;
            PrecioKgEnPie = precioKgEnPie;
        }

        public override void Validar()
        {
            base.Validar();
            ValidarTipoAlimentacion();
        }

        public override string Tipo()
        {
            return "Bovino";
        }

        private void ValidarTipoAlimentacion()
        {
            if (!Utilidades.StringValido(TipoAlimentacion))
            {
                throw new Exception("El tipo de alimentacion no puede ser vacio.");
            }
        }
    }
}
