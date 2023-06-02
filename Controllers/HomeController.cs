using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var makale = db.Makales.Where(i => i.Onay == true).Select(i => new MakaleModel()
            {
                Id = i.Id,
                Baslik = i.Baslik,
                KullanıcıAd = i.KullanıcıAd,
                Resim = i.Resim,
                YayinTarih = i.YayinTarih,
                Onay=i.Onay,
                Goruntulenme=i.Goruntulenme,
                yorum=i.yorum,
                Acıklama=i.Acıklama.Length>60?i.Acıklama.Substring(0,60)+("[...]"):i.Acıklama

            }).ToList();
            return View(makale);
        }
        public ActionResult Detay(int id)
        {
            var makale = db.Makales.Find(id);
            ViewBag.makale = makale;
            return View();
        }

    }
}