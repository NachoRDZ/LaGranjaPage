namespace Dominio.Entidades
{
    public class Ovino : Animal
    {
        public int PesoLana { get; set; }

        public decimal PrecioKg { get; set; }

        public decimal PrecioKgEnPie { get; set; }

        public Ovino(int pesoLana, decimal precioKg, decimal precioKgEnPie, string caravana, string sexo, string raza, DateTime fechaNacimiento, decimal costoAdquisicion, int costoAlimentacion, int peso, bool esHibrido, string estado) : base(caravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, peso, esHibrido, estado)
        {
            PesoLana = pesoLana;
            PrecioKg = precioKg;
            PrecioKgEnPie = precioKgEnPie;
        }

        public override void Validar()
        {
            base.Validar();
            ValidarPesoLana();
            ValidarPrecioKg();
            ValidarPrecioKgEnPie();
            ValidarFechaNacimiento();
        }

        public override string Tipo()
        {
            return "Ovino";
        }

        private void ValidarPesoLana()
        {
            if (PesoLana <= 0)
            {
                throw new Exception("El costo de alimentacion debe ser mayor a 0");
            }
        }

        private void ValidarPrecioKg()
        {
            if (PrecioKg <= 0)
            {
                throw new Exception("El costo de alimentacion debe ser mayor a 0");
            }
        }

        private void ValidarPrecioKgEnPie()
        {
            if (PrecioKgEnPie <= 0)
            {
                throw new Exception("El costo de alimentacion debe ser mayor a 0");
            }
        }

        private void ValidarFechaNacimiento()
        {
            if (FechaNacimiento > DateTime.Today || FechaNacimiento == DateTime.MinValue)
            {
                throw new Exception("Debe seleccionar una fecha de ingreso válida");
            }
        }
    }
}
