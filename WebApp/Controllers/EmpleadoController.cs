using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebApp.Filtros;

namespace WebApp.Controllers
{
    public class EmpleadoController : Controller
    {
        Sistema _sistema = Sistema.Instancia;

        [LogueadoFiltro]
        public IActionResult Index(string mensaje)
        {
            ViewBag.Mensaje = mensaje;

            if (HttpContext.Session.GetString("rol") == "Peon")
            {
                string email = HttpContext.Session.GetString("email");
                ViewBag.Empleados = _sistema.ListadoEmpleadosPorEmail(email);
            }
            else
            {
                ViewBag.Empleados = _sistema.Empleados;
            }
            return View();
        }


        
        [PeonFiltro]
        [HttpGet]
        public IActionResult VerTareasIncompletas(string mensaje)
        {
            ViewBag.Mensaje = mensaje;
            string email = HttpContext.Session.GetString("email");
            Empleado? _empleado = _sistema.ObtenerEmpleadoPorEmail(email);
            if (_empleado == null)
            {
                return RedirectToAction("Index", new { mensaje = "No hay un empleado con este email" });
            }
            ViewBag.TareasIncompletas = _empleado.ListarTareasIncompletas();
            return View();
        }

        [PeonFiltro]
        [HttpPost]
        public IActionResult CompletarTarea(int idTarea, string comentario)
        {
            string email = HttpContext.Session.GetString("email");
            Empleado? _empleado = _sistema.ObtenerEmpleadoPorEmail(email);
            if (_empleado == null)
            {
                return RedirectToAction("Index", new { mensaje = "Empleado no encontrado." });
            }
            if (string.IsNullOrEmpty(comentario))
            {
                return RedirectToAction("VerTareasIncompletas", new { mensaje = "Debe dejar un comentario." });
            }
            _sistema.CompletarTarea(idTarea, _empleado, comentario);
            return RedirectToAction("VerTareasIncompletas", new { mensaje = "Tarea completada correctamente" });
        }




        [CapatazFiltro]
        public IActionResult VerTareas(string email)
        {
            Empleado? _empleado = _sistema.ObtenerEmpleadoPorEmail(email);
            if (_empleado == null)
            {
                return RedirectToAction("Index", new { mensaje = "No hay ninguna empleado con este email" });
            }
            ViewBag.Tareas = _empleado.ListarTareas();
            return View();
        }

        [CapatazFiltro]
        public IActionResult AsignarTarea()
        {
            return View(new Peon());
        }

        [CapatazFiltro]
        [HttpPost]
        public IActionResult AsignarTarea(string email, string descripcion, DateTime fechaRealizacion, DateTime fechaCierre, string comentario)
        {
            Empleado? _empleado = _sistema.ObtenerEmpleadoPorEmail(email);
            if (_empleado == null)
            {
                return RedirectToAction("Index", new { mensaje = "No hay ninguna empleado con este email" });
            }

            try
            {
                bool tareaCompleta = false;
                Tarea tarea = new Tarea(descripcion, fechaRealizacion, tareaCompleta, fechaCierre, comentario);
                _empleado.AgregarTarea(tarea);
                return RedirectToAction("index", new { mensaje = "Tarea registrada con exito," });
            }
            catch (Exception e)
            {
                ViewBag.Mensaje = e.Message;
            }
            return RedirectToAction("VerTareas");
        }

    }



}

