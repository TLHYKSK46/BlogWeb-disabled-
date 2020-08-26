using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogBusiness.Abstract;
using BlogEntities.BlogDb;
using BlogumUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogumUI.Areas.Admin.Controllers
{
    public class AdminMakaleController : Controller
    {
        IMakaleServis _makaleServis;

        public AdminMakaleController(IMakaleServis makaleServis)
        {
            _makaleServis = makaleServis;
        }

        public IActionResult Index()
        {
            var makaleler = _makaleServis.MakaleleriGetir();

            AdminMakaleViewModel model = new AdminMakaleViewModel
            {
                Makaleler=makaleler

            };

            return View(model);
        }
        public IActionResult MakaleOlustur(Makale makale) {
            return View();
        }
        public IActionResult MakaleDüzenle(Makale makale)
        {
            //Makale makaleOkunmaSayisi = makaleler.First(u => u.MakaleId == ID);
            //makaleOkunmaSayisi.MakaleOkunmaSayisi += 1;
            //_makaleServis.Guncelle(makaleOkunmaSayisi);
            return View();
        }
        public IActionResult MakaleSil(int id)
        {
           _makaleServis.Sil(id);
            return View();
        }
    }
}
