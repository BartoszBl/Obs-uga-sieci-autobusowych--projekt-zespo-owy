using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZKM.UI.DAL;
using ZKM.UI.Models;

namespace ZKM.UI.Controllers
{
    public class PrzystankiController : Controller
    {
        private ZkmDbContext db = new ZkmDbContext();

        // GET: Przystanki
        public ActionResult Index()
        {
            return View(db.Przystanki.ToList());
        }

        // GET: Przystanki/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przystanek przystanek = db.Przystanki.Find(id);
            if (przystanek == null)
            {
                return HttpNotFound();
            }
            return View(przystanek);
        }

        // GET: Przystanki/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Przystanki/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PrzystanekID,Nazwa,Szerokosc_Geograficzna,Dlugosc_Geograficzna,Czy_Aktywny,Czy_Przeniesiony,Czy_jest_kiosk,Czy_jest_tablica,Czy_Usuniety")] Przystanek przystanek)
        {
            if (ModelState.IsValid)
            {
                db.Przystanki.Add(przystanek);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(przystanek);
        }

        // GET: Przystanki/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przystanek przystanek = db.Przystanki.Find(id);
            if (przystanek == null)
            {
                return HttpNotFound();
            }
            return View(przystanek);
        }

        // POST: Przystanki/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PrzystanekID,Nazwa,Szerokosc_Geograficzna,Dlugosc_Geograficzna,Czy_Aktywny,Czy_Przeniesiony,Czy_jest_kiosk,Czy_jest_tablica,Czy_Usuniety")] Przystanek przystanek)
        {
            if (ModelState.IsValid)
            {
                db.Entry(przystanek).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(przystanek);
        }

        // GET: Przystanki/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przystanek przystanek = db.Przystanki.Find(id);
            if (przystanek == null)
            {
                return HttpNotFound();
            }
            return View(przystanek);
        }

        // POST: Przystanki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Przystanek przystanek = db.Przystanki.Find(id);
            db.Przystanki.Remove(przystanek);
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
