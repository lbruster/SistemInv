using Microsoft.AspNetCore.Mvc;
using SistemaInventario.Modelos;
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

        public async Task<IActionResult> Upsert(int? id)
        {
            Bodega bodega = new Bodega();

            if (id == null)
            {
                //crear nueva bodega
                bodega.Estado = true;
                return View(bodega);
            }
            // Actualizamos Bodega
            bodega = await _unidedadTrabajo.Bodega.Obtener(id.GetValueOrDefault());
            if(bodega == null)
            {
                return NotFound();
            }
            return View(bodega);

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
