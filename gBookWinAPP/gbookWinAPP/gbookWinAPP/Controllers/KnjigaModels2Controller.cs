using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using gbookWinAPP.Models;

namespace gbookWinAPP.Controllers
{
    public class KnjigaModels2Controller : Controller
    {
        private gbookbazaContext db = new gbookbazaContext();

        // GET: KnjigaModels2
        public ActionResult Index()
        {
            var oOADKnjige = db.OOADKnjige.Include(k => k.OOADClanovi);
            return View(oOADKnjige.ToList());
        }

        // GET: KnjigaModels2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KnjigaModel knjigaModel = db.OOADKnjige.Find(id);
            if (knjigaModel == null)
            {
                return HttpNotFound();
            }
            return View(knjigaModel);
        }

        // GET: KnjigaModels2/Create
        public ActionResult Create()
        {
            ViewBag.KnjigaID = new SelectList(db.OOADClanovi, "ID", "Ime");
            return View();
        }

        // POST: KnjigaModels2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KorisnikKnige,KnjigaID,Naziv,Autor,Izdavac,ISBN,DatumIzdavanja,DatumVracanja")] KnjigaModel knjigaModel)
        {
            if (ModelState.IsValid)
            {
                db.OOADKnjige.Add(knjigaModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KnjigaID = new SelectList(db.OOADClanovi, "ID", "Ime", knjigaModel.KnjigaID);
            return View(knjigaModel);
        }

        // GET: KnjigaModels2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KnjigaModel knjigaModel = db.OOADKnjige.Find(id);
            if (knjigaModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.KnjigaID = new SelectList(db.OOADClanovi, "ID", "Ime", knjigaModel.KnjigaID);
            return View(knjigaModel);
        }

        // POST: KnjigaModels2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KorisnikKnige,KnjigaID,Naziv,Autor,Izdavac,ISBN,DatumIzdavanja,DatumVracanja")] KnjigaModel knjigaModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(knjigaModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KnjigaID = new SelectList(db.OOADClanovi, "ID", "Ime", knjigaModel.KnjigaID);
            return View(knjigaModel);
        }

        // GET: KnjigaModels2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KnjigaModel knjigaModel = db.OOADKnjige.Find(id);
            if (knjigaModel == null)
            {
                return HttpNotFound();
            }
            return View(knjigaModel);
        }

        // POST: KnjigaModels2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KnjigaModel knjigaModel = db.OOADKnjige.Find(id);
            db.OOADKnjige.Remove(knjigaModel);
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
