using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VectisPackers;

namespace PackerApp28_11.Controllers
{
    public class PackingStaffsController : Controller
    {
        private PackingEntities db = new PackingEntities();

        // GET: PackingStaffs
        public ActionResult Index()
        {
            return View(db.PackingStaffs.ToList());
        }

        // GET: PackingStaffs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PackingStaff packingStaff = db.PackingStaffs.Find(id);
            if (packingStaff == null)
            {
                return HttpNotFound();
            }
            return View(packingStaff);
        }

        // GET: PackingStaffs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PackingStaffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PackerId,Name,Active")] PackingStaff packingStaff)
        {
            if (ModelState.IsValid)
            {
                db.PackingStaffs.Add(packingStaff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(packingStaff);
        }

        // GET: PackingStaffs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PackingStaff packingStaff = db.PackingStaffs.Find(id);
            if (packingStaff == null)
            {
                return HttpNotFound();
            }
            return View(packingStaff);
        }

        // POST: PackingStaffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PackerId,Name,Active")] PackingStaff packingStaff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(packingStaff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(packingStaff);
        }

        // GET: PackingStaffs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PackingStaff packingStaff = db.PackingStaffs.Find(id);
            if (packingStaff == null)
            {
                return HttpNotFound();
            }
            return View(packingStaff);
        }

        // POST: PackingStaffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PackingStaff packingStaff = db.PackingStaffs.Find(id);
            db.PackingStaffs.Remove(packingStaff);
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
