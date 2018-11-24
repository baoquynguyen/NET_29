using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLNhansu.Models;

namespace QLNhansu.Controllers
{
    public class NhanVienController : Controller
    {
        QLNhansuEntities db = new QLNhansuEntities();
        public ActionResult Index()
        {
            var lstnv = db.NhanViens.ToList();
            return View(lstnv);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MaPB = new SelectList(db.Phongbans.ToList().OrderBy(it => it.TenPB), "MaPB", "TenPB");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(NhanVien nv)
        {
           

            if (ModelState.IsValid)
            {
                db.NhanViens.Add(nv);
                db.SaveChanges();
            }
            ViewBag.MaPB = new SelectList(db.Phongbans.ToList().OrderBy(it => it.TenPB), "MaPB", "TenPB");
            return View("Index");
        }
        [HttpGet]
        public ActionResult Edit(string manv)
        {
            var nv = db.NhanViens.SingleOrDefault(it => it.MaNV == manv);
            ViewBag.MaPB = new SelectList(db.Phongbans.ToList().OrderBy(it => it.TenPB), "MaPB", "TenPB", nv.MaPB);
            return View(nv);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(NhanVien nv)
        {
            ViewBag.MaPB = new SelectList(db.Phongbans.ToList().OrderBy(it => it.TenPB), "MaPB", "TenPB", nv.MaPB);
            if (ModelState.IsValid)
            {
                db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                
            }
            return View("Index");
        
        }
        public ActionResult Details(string manv)
        {
            var nv = db.NhanViens.SingleOrDefault(it => it.MaNV == manv);
            ViewBag.MaPB = new SelectList(db.Phongbans.ToList().OrderBy(it => it.TenPB), "MaPB", "TenPB", nv.MaPB);
           
            return View(nv);
        }
        [HttpGet]
        public ActionResult Delete(string manv)
        {
            var nv = db.NhanViens.SingleOrDefault(it => it.MaNV == manv);
            return View(nv);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConFirm(string manv)
        {
            var nv = db.NhanViens.SingleOrDefault(it => it.MaNV == manv);
            db.NhanViens.Remove(nv);
            db.SaveChanges();
            return View("Index");
        }
        


       
    }
    //END
}