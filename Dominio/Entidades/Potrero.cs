using Dominio.Comun;
using Dominio.Interfaces;

namespace Dominio.Entidades
{
    public class Potrero : IValidable, IEquatable<Potrero>, IComparable<Potrero>
    {
        public int Id { get; set; }

        private static int UltId { get; set; }

        public string Descripcion { get; set; }

        public int CantHectareas { get; set; }

        public int CapacidadMax { get; set; }

        // Agregar animales a potreros
        private List<Animal> _animalesEnPotrero = new List<Animal>();

        public Potrero(string descripcion, int cantHectareas, int capacidadMax)
        {
            Id = UltId++;
            Descripcion = descripcion;
            CantHectareas = cantHectareas;
            CapacidadMax = capacidadMax;
        }
        public void Validar()
        {
            ValidarDescripcion();
            ValidarCantHect();
            ValidarCapMax();
        }

        private void ValidarDescripcion()
        {
            if (!Utilidades.StringValido(Descripcion))
            {
                throw new Exception("La descripcion no puede ser vacio.");
            }
        }

        private void ValidarCantHect()
        {
            if (CantHectareas <= 0)
            {
                throw new Exception("La cantidad de hectareas debe ser mayor a 0.");
            }
        }

        private void ValidarCapMax()
        {
            if (CapacidadMax <= 0)
            {
                throw new Exception("La capacidad maxima debe ser mayor a 0.");
            }
        }

        public bool Equals(Potrero? other)
        {
            return other != null && Id == other.Id;
        }

        public void AsignarAnimal(Animal animal)
        {
            if (_animalesEnPotrero.Contains(animal))
            {
                throw new Exception("El animal ya se encuentra en el potrero.");
            }

            if (_animalesEnPotrero.Count >= CapacidadMax)
            {
                throw new Exception("El potrero ya se encuentra lleno.");
            }
            _animalesEnPotrero.Add(animal);
        }

        public int CompareTo(Potrero? other)
        {
            int orden = CapacidadMax.CompareTo(other.CapacidadMax);
            if (orden == 0)
            {
                orden = _animalesEnPotrero.Count.CompareTo(other._animalesEnPotrero.Count) * -1;
            }
            return orden;
        }

        public int ObtenerCantidadAnimales()
        {
            return _animalesEnPotrero.Count;
        }


    }
}
