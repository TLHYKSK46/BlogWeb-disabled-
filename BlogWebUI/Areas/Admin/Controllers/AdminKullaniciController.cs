

using Microsoft.AspNetCore.Mvc;

namespace BlogWebUI.Areas.Admin.Controllers
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