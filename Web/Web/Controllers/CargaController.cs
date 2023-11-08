using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CargaController : Controller
    {

        private readonly DatosContext _context;

        public CargaController(DatosContext context)
        {
            _context = context;
        }

        // GET: CargaController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Carga(string Nombre, string Documento, string Area)
        {
            var Empleado = new Empleado
            {
                Nombre = Nombre,
                Documento = Documento,
                Area = Area
            };

            try {
                _context.Add(Empleado);
                _context.SaveChanges();

                return Json(new { Nombre, Documento, Area });
            }
            catch(Exception ex) {
                return Json(new { Nombre, Documento, Area, ex });
            }
        }
    }
}
