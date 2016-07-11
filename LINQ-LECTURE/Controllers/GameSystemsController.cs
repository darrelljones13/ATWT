using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamerLinqDemoApp.Models;

namespace GamerLinqDemoApp.Controllers
{
    public class GameSystemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GameSystems
        public ActionResult Index()
        {
            return View(db.GameSystems.ToList());
        }

        // GET: GameSystems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameSystem gameSystem = db.GameSystems.Find(id);
            if (gameSystem == null)
            {
                return HttpNotFound();
            }
            return View(gameSystem);
        }

        // GET: GameSystems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameSystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SystemName")] GameSystem gameSystem)
        {
            if (ModelState.IsValid)
            {
                db.GameSystems.Add(gameSystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameSystem);
        }

        // GET: GameSystems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameSystem gameSystem = db.GameSystems.Find(id);
            if (gameSystem == null)
            {
                return HttpNotFound();
            }
            return View(gameSystem);
        }

        // POST: GameSystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SystemName")] GameSystem gameSystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameSystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameSystem);
        }

        // GET: GameSystems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameSystem gameSystem = db.GameSystems.Find(id);
            if (gameSystem == null)
            {
                return HttpNotFound();
            }
            return View(gameSystem);
        }

        // POST: GameSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameSystem gameSystem = db.GameSystems.Find(id);
            db.GameSystems.Remove(gameSystem);
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
