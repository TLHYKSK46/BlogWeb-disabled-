﻿using BlogEntities.BlogDb;
using BlogWebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebUI.Areas.Admin.ViewComponents
{
    public class UserSummerViewComponent:ViewComponent

    {
        public string AdSoyad { get; internal set; }
        public string Email { get; internal set; }
        public int RolId { get; internal set; }
        public string FotoUrl { get; internal set; }
       

        public  ViewViewComponentResult Invoke() {
          
            List<AdminKullaniciViewModel> viewModels = new List<AdminKullaniciViewModel>();

            foreach (var item in viewModels)
            {
                //Kullanici kullanici = new Kullanici {
                //Email=item.Email,
                // FotoUrl=item.FotoUrl,
                // KulAdSoyad=item.AdSoyad,
                // RolId=item.RolId
                
                //};
                //return View(kullanici);
                AdSoyad = item.AdSoyad;
                Email = item.Email;
                RolId = item.RolId;
                FotoUrl = item.FotoUrl;


            }

            AdminUserSummerViewCompenentModel model = new AdminUserSummerViewCompenentModel
            {
                AdSoyad=AdSoyad,
                Email=Email,
                FotoUrl=FotoUrl,
                RolId=RolId

            };
            return View(model);

        }
    }
}
