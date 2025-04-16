using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Filtros
{
    public class LogueadoFiltro : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context.HttpContext.Session.GetString("rol") != "Peon" && context.HttpContext.Session.GetString("rol") != "Capataz")
            {
                context.Result = new RedirectResult("/usuario/login");
            }
        }
    }
}
