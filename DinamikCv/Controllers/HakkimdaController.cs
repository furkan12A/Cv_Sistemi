using DinamikCv.Models.Entity;
using DinamikCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinamikCv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();

        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }

        [HttpPost]
        public ActionResult Index(TblHakkimda h)
        {
            var t = repo.Find(x => x.ID == 1);
            t.AD = h.AD;
            t.SOYAD = h.SOYAD;
            t.ADRES = h.ADRES;
            t.MAIL = h.MAIL;
            t.TELEFON = h.TELEFON;
            t.RESİM = h.RESİM;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}