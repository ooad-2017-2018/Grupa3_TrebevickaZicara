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
    public class ClanModelsController : Controller
    {
        private gbookbazaContext db = new gbookbazaContext();

        // GET: ClanModels
        public ActionResult Index()
        {
            return View(db.OOADClanovi.ToList());
        }

        // GET: ClanModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClanModel clanModel = db.OOADClanovi.Find(id);
            if (clanModel == null)
            {
                return HttpNotFound();
            }
            return View(clanModel);
        }

        // GET: ClanModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClanModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Ime,Prezime,UserName,Password,DatumUclanjenja,Grad,Adresa,BrojTel,Email")] ClanModel clanModel)
        {
            if (ModelState.IsValid)
            {
                db.OOADClanovi.Add(clanModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clanModel);
        }

        // GET: ClanModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClanModel clanModel = db.OOADClanovi.Find(id);
            if (clanModel == null)
            {
                return HttpNotFound();
            }
            return View(clanModel);
        }

        // POST: ClanModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Ime,Prezime,UserName,Password,DatumUclanjenja,Grad,Adresa,BrojTel,Email")] ClanModel clanModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clanModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clanModel);
        }

        // GET: ClanModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClanModel clanModel = db.OOADClanovi.Find(id);
            if (clanModel == null)
            {
                return HttpNotFound();
            }
            return View(clanModel);
        }

        // POST: ClanModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClanModel clanModel = db.OOADClanovi.Find(id);
            db.OOADClanovi.Remove(clanModel);
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
