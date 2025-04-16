namespace Dominio.Entidades
{
    public class Peon : Empleado
    {
        public bool EsResidente { get; set; }
        private List<Tarea> _tareas = new List<Tarea>();

        public Peon() {}

        public Peon(bool esResidente, string email, string contrasenia, string nombre, DateTime fechaIngreso) : base(email, contrasenia, nombre, fechaIngreso)
        {
            EsResidente = esResidente;
        }

        public override void Validar()
        {
            base.Validar();
        }

        public IEnumerable<Tarea> Tareas
        {
            get { return _tareas; }
        }

        public override void AgregarTarea(Tarea tarea)
        {
            if (tarea == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            tarea.Validar();
            if (_tareas.Contains(tarea))
            {
                throw new Exception($"La tarea ya existe con el Id: {tarea.Id}");
            }
            _tareas.Add(tarea);
        }

        public override string MostrarEsResidente()
        {
            if (EsResidente)
            {
                return "si";
            }
            return "no";
        }

        public override IEnumerable<Tarea> ListarTareasIncompletas()
        {
            List<Tarea> TareasIncompletas = new List<Tarea>();
            foreach (Tarea item in _tareas)
            {
                if (item.TareaCompleta == false)
                {
                    TareasIncompletas.Add(item);
                }
            }
            TareasIncompletas.Sort();
            return TareasIncompletas;
        }

        public override string Rol()
        {
            return "Peon";
        }

        public override IEnumerable<Tarea> ListarTareas()
        {
            return _tareas;
        }
        
    }
}
