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
    public class AutobusyController : Controller
    {
        private ZkmDbContext db = new ZkmDbContext();

        // GET: Autobusy
        public ActionResult Index()
        {
            return View(db.Autobusy.ToList());
        }

        // GET: Autobusy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autobus autobus = db.Autobusy.Find(id);
            if (autobus == null)
            {
                return HttpNotFound();
            }
            return View(autobus);
        }

        // GET: Autobusy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autobusy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AutobusID,Marka,Rok_Produkcji,Ilosc_miejsc,Klimatyzacja,Czy_Aktywny,Czy_W_naprawie,Czy_usuniety,Czy_zezlomowany")] Autobus autobus)
        {
            if (ModelState.IsValid)
            {
                db.Autobusy.Add(autobus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autobus);
        }

        // GET: Autobusy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autobus autobus = db.Autobusy.Find(id);
            if (autobus == null)
            {
                return HttpNotFound();
            }
            return View(autobus);
        }

        // POST: Autobusy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AutobusID,Marka,Rok_Produkcji,Ilosc_miejsc,Klimatyzacja,Czy_Aktywny,Czy_W_naprawie,Czy_usuniety,Czy_zezlomowany")] Autobus autobus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autobus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autobus);
        }

        // GET: Autobusy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autobus autobus = db.Autobusy.Find(id);
            if (autobus == null)
            {
                return HttpNotFound();
            }
            return View(autobus);
        }

        // POST: Autobusy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Autobus autobus = db.Autobusy.Find(id);
            db.Autobusy.Remove(autobus);
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
