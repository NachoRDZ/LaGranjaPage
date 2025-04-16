using Dominio.Comun;
using Dominio.Interfaces;

namespace Dominio.Entidades
{
    public abstract class Animal : IValidable, IEquatable<Animal>
    {
        public string Caravana { get; set; }

        public string Sexo { get; set; }

        public string Raza { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public decimal CostoAdquisicion { get; set; }

        public decimal CostoAlimentacion { get; set; }

        public int Peso { get; set; }

        public bool EsHibrido { get; set; }

        public string Estado { get; set; }

        private List<VacunaRecibida> _vacunasRecibidas = new List<VacunaRecibida>();

        public abstract string Tipo();

        public Animal() { }
        public Animal(string caravana, string sexo, string raza, DateTime fechaNacimiento, decimal costoAdquisicion, decimal costoAlimentacion, int peso, bool esHibrido, string estado)
        {
            Caravana = caravana;
            Sexo = sexo;
            Raza = raza;
            FechaNacimiento = fechaNacimiento;
            CostoAdquisicion = costoAdquisicion;
            CostoAlimentacion = costoAlimentacion;
            Peso = peso;
            EsHibrido = esHibrido;
            Estado = estado;
        }

        public IEnumerable<VacunaRecibida> VacunasRecibidas
        {
            get { return _vacunasRecibidas; }
        }

        public virtual void Validar()
        {
            ValidarCaravana();
            ValidarSexo();
            ValidarRaza();
            ValidarFechaNacimiento();
            ValidarCostoAdquisicion();
            ValidarCostoAlimentacion();
            ValidarPeso();
        }

        private void ValidarCaravana()
        {
            if (!Utilidades.StringValido(Caravana) && Caravana.Length < 8)
            {
                throw new Exception("El Id de la caravana no puede ser vacio y debe contener 8 digitos.");
            }
        }

        private void ValidarSexo()
        {
            if (!Utilidades.StringValido(Sexo))
            {
                throw new Exception("El sexo no puede ser vacio.");
            }
        }

        private void ValidarRaza()
        {
            if (!Utilidades.StringValido(Raza))
            {
                throw new Exception("La raza no puede ser vacio.");
            }
        }

        private void ValidarFechaNacimiento()
        {
            if (FechaNacimiento > DateTime.Today || FechaNacimiento == DateTime.MinValue)
            {
                throw new Exception("Debe seleccionar una fecha de nacimiento válida");
            }
        }

        public void VacunarAnimal(Vacuna vacuna, DateTime fechaVacunacion, DateTime fechaVencimiento)
        {
            _vacunasRecibidas.Add(new VacunaRecibida(vacuna, fechaVacunacion, fechaVencimiento));
        }

        public bool Equals(Animal? other)
        {
            return other != null && Caravana == other.Caravana;
        }

        private void ValidarCostoAdquisicion()
        {
            if (CostoAdquisicion <= 0)
            {
                throw new Exception("El costo de adquisicion debe ser mayor a 0");
            }
        }

        private void ValidarCostoAlimentacion()
        {
            if (CostoAlimentacion <= 0)
            {
                throw new Exception("El costo de alimentacion debe ser mayor a 0");
            }
        }

        private void ValidarPeso()
        {
            if (Peso <= 0)
            {
                throw new Exception("El peso debe ser mayor a 0");
            }
        }
    }
}
