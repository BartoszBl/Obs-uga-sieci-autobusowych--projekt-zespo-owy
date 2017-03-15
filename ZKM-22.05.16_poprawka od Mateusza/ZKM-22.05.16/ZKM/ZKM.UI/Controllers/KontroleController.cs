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
    public class KontroleController : Controller
    {
        private ZkmDbContext db = new ZkmDbContext();

        // GET: Kontrole
        public ActionResult Index()
        {
            return View(db.Kontrolas.ToList());
        }

        // GET: Kontrole/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontrola kontrola = db.Kontrolas.Find(id);
            if (kontrola == null)
            {
                return HttpNotFound();
            }
            return View(kontrola);
        }

        // GET: Kontrole/Create
        public ActionResult Create()
        {
            ViewData.Add("dropdownItems", this.przystanki());
            ViewData.Add("dropdownItemsIn", this.incydenty());
            return View();
        }

        // POST: Kontrole/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KontrolaID,Nazwa_przystanku,Data,Godzina,Ilosc_skasowanych_biletow,Ilosc_wystawionych_mandatow,Opis_zdarzenia")] Kontrola kontrola)
        {
            if (ModelState.IsValid)
            {
                db.Kontrolas.Add(kontrola);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData.Add("dropdownItems", this.przystanki(kontrola.Nazwa_przystanku));
            ViewData.Add("dropdownItemsIn", this.incydenty(kontrola.Opis_zdarzenia));
            return View(kontrola);
        }

        // GET: Kontrole/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontrola kontrola = db.Kontrolas.Find(id);
            if (kontrola == null)
            {
                return HttpNotFound();
            }
            ViewData.Add("dropdownItems", this.przystanki(kontrola.Nazwa_przystanku));
            ViewData.Add("dropdownItemsIn", this.incydenty(kontrola.Opis_zdarzenia));
            return View(kontrola);
        }

        // POST: Kontrole/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KontrolaID,Nazwa_przystanku,Data,Godzina,Ilosc_skasowanych_biletow,Ilosc_wystawionych_mandatow,Opis_zdarzenia")] Kontrola kontrola)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kontrola).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData.Add("dropdownItems", this.przystanki(kontrola.Nazwa_przystanku));
            ViewData.Add("dropdownItemsIn", this.incydenty(kontrola.Opis_zdarzenia));
            return View(kontrola);
        }

        // GET: Kontrole/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontrola kontrola = db.Kontrolas.Find(id);
            if (kontrola == null)
            {
                return HttpNotFound();
            }
            return View(kontrola);
        }

        // POST: Kontrole/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kontrola kontrola = db.Kontrolas.Find(id);
            db.Kontrolas.Remove(kontrola);
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

        private List<SelectListItem> przystanki(string wybrany = "")
        {
            List<SelectListItem> odp = new List<SelectListItem>();
            List<Przystanek> przystanki = db.Przystanki.ToList();
            foreach (var przystanek in przystanki)
            {
                if(przystanek.Nazwa == wybrany)
                {
                    odp.Add(new SelectListItem() { Selected = true, Text = przystanek.Nazwa, Value = przystanek.Nazwa });
                }
                else
                {
                    odp.Add(new SelectListItem() { Text = przystanek.Nazwa, Value = przystanek.Nazwa });
                }
            }
            return odp;
        }

        private List<SelectListItem> incydenty(string wybrany = "")
        {
            List<SelectListItem> odp = new List<SelectListItem>();
            List<Incydent> incydenty = db.Incydenty.ToList();
            foreach (var incydent in incydenty)
            {
                if (incydent.Nazwa == wybrany)
                {
                    odp.Add(new SelectListItem() { Selected = true, Text = incydent.Nazwa, Value = incydent.Nazwa });
                }
                else
                {
                    odp.Add(new SelectListItem() { Text = incydent.Nazwa, Value = incydent.Nazwa });
                }
            }
            return odp;
        }

    }
}


