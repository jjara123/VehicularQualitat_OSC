using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenesisVehivular.Models;

namespace GenesisVehivular.Controllers
{
    public class InspeccionController : Controller
    {
        private VEHDb_Context db = new VEHDb_Context();

        // GET: Inspeccion
        public ActionResult RegistroInspeccion()
        {
            return View();
        }

        public ActionResult ReporteInspeccion()
        {
            return View();
        }

        public ActionResult GuardarImagen()
        {
            return PartialView();
        }

         public ActionResult convertirImagen(int idimagen)
        {
            var imagen = db.t_fotos.Where(x => x.idimagen == idimagen).FirstOrDefault();
            return File(imagen.imagen, "image/jpeg");
        }


    }
}