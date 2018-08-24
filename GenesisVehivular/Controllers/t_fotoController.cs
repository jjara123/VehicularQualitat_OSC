using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GenesisVehivular.Models;
using System.IO;

namespace GenesisVehivular.Controllers
{
    public class t_fotoController : Controller
    {
        private VEHDb_Context db = new VEHDb_Context();

        // GET: t_foto
        public ActionResult Index()
        {
            return View(db.t_fotos.ToList());
        }

        public ActionResult convertirImagen(int idimagen)
        {
            var imagen = db.t_fotos.Where(x => x.idimagen == idimagen).FirstOrDefault();
            return File(imagen.imagen, "image/jpeg");
        }

        // GET: t_foto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_foto t_foto = db.t_fotos.Find(id);
            if (t_foto == null)
            {
                return HttpNotFound();
            }
            return View(t_foto);
        }

        // GET: t_foto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: t_foto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idimagen,codinspeccion,hora,descripcion")] t_foto t_foto, HttpPostedFileBase imagen)
        {
            if (imagen != null && imagen.ContentLength > 0)
            {
                byte[] imagenData = null;
                using (var binaryReader = new BinaryReader(imagen.InputStream))
                {
                    imagenData = binaryReader.ReadBytes(imagen.ContentLength);
                }
                //setear la imagen a la entidad que se creara
                t_foto.imagen = imagenData;
            }
            if (ModelState.IsValid)
            {
                db.t_fotos.Add(t_foto);
                db.SaveChanges();
                return RedirectToAction("RegistroInspeccion", "Inspeccion");
                //return RedirectToAction("RegistroInspeccion", "Inspeccion",new { id = 33 });

            }
           
            return View(t_foto);
          

        }

        // GET: t_foto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_foto t_foto = db.t_fotos.Find(id);
            if (t_foto == null)
            {
                return HttpNotFound();
            }
            return View(t_foto);
        }

        // POST: t_foto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idimagen,codinspeccion,hora,descripcion,imagen")] t_foto t_foto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_foto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_foto);
        }

        // GET: t_foto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_foto t_foto = db.t_fotos.Find(id);
            if (t_foto == null)
            {
                return HttpNotFound();
            }
            return View(t_foto);
        }

        // POST: t_foto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            t_foto t_foto = db.t_fotos.Find(id);
            db.t_fotos.Remove(t_foto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
