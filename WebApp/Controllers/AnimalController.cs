using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebApp.Filtros;

namespace WebApp.Controllers
{
    public class AnimalController : Controller
    {
        Sistema _sistema = Sistema.Instancia;

        [LogueadoFiltro]
        public IActionResult Index(string mensaje)
        {
            ViewBag.Animales = _sistema.Animales;
            ViewBag.Mensaje = mensaje;
            return View();
        }

        [CapatazFiltro]
        public IActionResult AltaBovino()
        {
            return View(new Bovino());
        }

        [CapatazFiltro]
        [HttpPost]
        public IActionResult AltaBovino(Bovino animal, string estado)
        {
            try
            {
                estado = "Libre";
                _sistema.AgregarBovino(animal);
                return RedirectToAction("index", new { mensaje = "Se dio de alta con exito" });
            }
            catch (Exception e)
            {
                ViewBag.Mensaje = e.Message;
            }
            return View(animal);
        }

        [CapatazFiltro]
        public IActionResult VerPotreros()
        {
            ViewBag.Potreros = _sistema.Potreros;
            return View();
        }

        [CapatazFiltro]
        public IActionResult FiltroAnimales(int peso, string tipo)
        {
            ViewBag.Animales = _sistema.FiltroAnimal(peso, tipo);

            return View("Index");
        }

        [PeonFiltro]
        public IActionResult AltaVacuna()
        {
            ViewBag.Vacunas = _sistema.Vacunas;
            return View(new VacunaRecibida());
        }

        [PeonFiltro]
        [HttpPost]
        public IActionResult AltaVacuna(string TipoVacuna, DateTime fecha, DateTime vencimiento)
        {
            try
            {
                Vacuna vacuna = _sistema.ObtenerVacunaPorNombre(TipoVacuna); 
                VacunaRecibida vacunaRecibida = new(vacuna, fecha, vencimiento);
                _sistema.AgregarVacunaRecibida(vacunaRecibida);
                return RedirectToAction("index", new { mensaje = "Se dio de alta con exito" });
            }
            catch (Exception e)
            {
                ViewBag.Mensaje = e.Message;
            }
            ViewBag.Vacunas = _sistema.Vacunas;
            return View();
        }

        [LogueadoFiltro]
        public IActionResult VerVacunas(string caravana)
        {
            Animal? _animal = _sistema.ObtenerAnimalPorCaravana(caravana);

            if (_animal == null)
            {
                return RedirectToAction("index", new { mensaje = "No se ha ingresado vacunas" });
            }

            IEnumerable<VacunaRecibida> _vacunasRecibidas = _animal.VacunasRecibidas;

            if (_vacunasRecibidas.Count() == 0)
            {
                return RedirectToAction("index", new { mensaje = "No se ha ingresado vacunas" });
            }
            ViewBag.Vacunas = _vacunasRecibidas;
            return View();
        }

        public IActionResult AsignarAnimal()
        {
            ViewBag.Potreros = _sistema.Potreros;
            return View();
        }

        [HttpPost]
        public IActionResult AsignarAnimal(string caravana, string potreroString)
        {
            try
            {
                int potreroInt = int.Parse(potreroString);
                Potrero unP = _sistema.ObtenerPotreroPorId(potreroInt);
                Animal unA = _sistema.ObtenerAnimalPorCaravana(caravana);
                if (unP.ObtenerCantidadAnimales() >= unP.CapacidadMax)
                {
                    return RedirectToAction("index", new { mensaje = "Ya no caben mas animales en este potrero."});
                }
                _sistema.AsignarAnimalAPotrero(unA, unP);
                return RedirectToAction("index", new { mensaje = "Se asigno con exito"});
            }
            catch (Exception e)
            {
                ViewBag.Mensaje = e.Message;
            }
            return View();
        }

        public IActionResult VerAnimalesLibres()
        {
            ViewBag.Animales = _sistema.Animales;
            return View();
        }
    }
}


