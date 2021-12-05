using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BackendCoffee;
using BackendCoffee.Data;

namespace BackendCoffee.Controllers
{
    public class ShaurmasController : Controller
    {
        private ShaurmaContext db = new ShaurmaContext();

        // GET: Shaurmas
        public ActionResult Index()
        {
            return View(db.Shaurmas.ToList());
        }

        // GET: Shaurmas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shaurma shaurma = db.Shaurmas.Find(id);
            if (shaurma == null)
            {
                return HttpNotFound();
            }
            return View(shaurma);
        }

        // GET: Shaurmas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shaurmas/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "primaryKey,Name,Description,Price,ReadyMadeKits,Availability")] Shaurma shaurma)
        {
            if (ModelState.IsValid)
            {
                db.Shaurmas.Add(shaurma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shaurma);
        }

        // GET: Shaurmas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shaurma shaurma = db.Shaurmas.Find(id);
            if (shaurma == null)
            {
                return HttpNotFound();
            }
            return View(shaurma);
        }

        // POST: Shaurmas/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "primaryKey,Name,Description,Price,ReadyMadeKits,Availability")] Shaurma shaurma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shaurma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shaurma);
        }

        // GET: Shaurmas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shaurma shaurma = db.Shaurmas.Find(id);
            if (shaurma == null)
            {
                return HttpNotFound();
            }
            return View(shaurma);
        }

        // POST: Shaurmas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shaurma shaurma = db.Shaurmas.Find(id);
            db.Shaurmas.Remove(shaurma);
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
