using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema _sistema = Sistema.Instancia;
        public IActionResult login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string mensaje)
        {
            ViewBag.mensaje = mensaje;
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            ViewBag.Empleados = _sistema.Empleados;

            Empleado unE = _sistema.ObtenerEmpleadoPorEmail(email);
            if (unE == null || unE.Contrasenia != password)
            {
                return RedirectToAction("Login", new {mensaje = "Email o contraseña equivocados."});
            }


            HttpContext.Session.SetString("nombre", unE.Nombre);
            HttpContext.Session.SetString("email", unE.Email);
            HttpContext.Session.SetString("password", unE.Contrasenia);
            HttpContext.Session.SetString("rol", unE.Rol());

            if (unE.Rol() == "Capataz")
            {
                return Redirect("/empleado/index");
            }
            else if (unE.Rol() == "Peon")
            {
                return Redirect("/empleado/index");
            }
            return RedirectToAction("login");
        }

        public IActionResult Logout()
        {
            
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }

        public IActionResult Registrarse()
        {
            return View(new Tarea());
        }

       [HttpPost]
        public IActionResult Registrarse(string residente, string email, string contrasenia, string nombre, DateTime fechaIngreso)
        {
            try
            {
                bool residenteBool = bool.Parse(residente);
                fechaIngreso = DateTime.Today;
                Peon peon = new Peon(residenteBool, email, contrasenia, nombre, fechaIngreso);
                _sistema.AgregarPeon(peon);
                return RedirectToAction("login", new { mensaje = "Usuario registrado. Inicie sesión." });
            }
            catch (Exception e)
            {
                ViewBag.Mensaje = e.Message;
            }
            return View();
        }
    }
}
