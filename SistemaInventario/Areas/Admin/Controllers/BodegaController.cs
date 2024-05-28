using Microsoft.AspNetCore.Mvc;
using SistemaInvesntario.AccesoDatos.Repositorio.IRepositorio;

namespace SistemaInventario.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BodegaController : Controller
    {

        private readonly IUnidedadTrabajo _unidedadTrabajo;

        public BodegaController(IUnidedadTrabajo unidedadTrabajo)
        {
            _unidedadTrabajo = unidedadTrabajo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var todos = await _unidedadTrabajo.Bodega.ObtenerTodos();
            return Json(new { data = todos });
        }



        #endregion
    }
}
