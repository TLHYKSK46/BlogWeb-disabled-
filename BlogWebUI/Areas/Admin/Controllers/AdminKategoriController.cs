﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogBusiness.Abstract;
using BlogumUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebUI.Areas.Admin.Controllers
{
    public class AdminKategoriController : Controller
    {
        IKategoriServis _kategoriServis;

        public AdminKategoriController(IKategoriServis kategoriServis)
        {
            _kategoriServis = kategoriServis;
        }

        public IActionResult Index()
        {
            var kategori = _kategoriServis.KategorileriGetir();
            AdminKategoriViewModel model = new AdminKategoriViewModel
            {
                Kategori=kategori
            };

            return View(model);
        }
    }
}
