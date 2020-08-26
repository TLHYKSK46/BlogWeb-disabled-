

using Microsoft.AspNetCore.Mvc;

namespace Blogum.Areas.Admin.Controllers
{
    public class AdminKullaniciController:Controller

    {
        public AdminKullaniciController()
        {
        }

        public IActionResult index() {

            return View();

         }
        
    }
}