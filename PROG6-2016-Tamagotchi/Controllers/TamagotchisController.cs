﻿using PROG6_2016_Tamagotchi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PROG6_2016_Tamagotchi.Controllers
{
    public class TamagotchisController : Controller
    {
        private Models.Database db = new Models.Database();

        // GET: Tamagotchi
        public ActionResult Index()
        {
            return View(db.Tamagotchis.ToList());
        }

        // GET: Tamagotchi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tamagotchi tamagotchi = db.Tamagotchis.Find(id);
            if (tamagotchi == null)
            {
                return HttpNotFound();
            }
            return View(tamagotchi);
        }

        // GET: Tamagotchi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tamagotchi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Gold,ItemUrl")] Tamagotchi tamagotchi)
        {
            if (ModelState.IsValid)
            {
                db.Tamagotchis.Add(tamagotchi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tamagotchi);
        }

        // GET: Tamagotchi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tamagotchi tamagotchi = db.Tamagotchis.Find(id);
            if (tamagotchi == null)
            {
                return HttpNotFound();
            }
            return View(tamagotchi);
        }

        // POST: Tamagotchi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Gold,ItemUrl")] Tamagotchi tamagotchi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tamagotchi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tamagotchi);
        }

        // GET: Tamagotchi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tamagotchi tamagotchi = db.Tamagotchis.Find(id);
            if (tamagotchi == null)
            {
                return HttpNotFound();
            }
            return View(tamagotchi);
        }

        // POST: Tamagotchi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tamagotchi tamagotchi = db.Tamagotchis.Find(id);
            db.Tamagotchis.Remove(tamagotchi);
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
