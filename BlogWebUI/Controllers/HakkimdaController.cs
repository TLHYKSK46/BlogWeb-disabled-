using BlogBusiness.Abstract;
using BlogWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebUI.Controllers
{
    public class HakkimdaController : Controller
    {
        IHakkimdaServis _hakkimdaServis;
        IKullaniciServis _kullaniciServis;

        public HakkimdaController(IHakkimdaServis hakkimdaServis,IKullaniciServis kullaniciServis)
        {
            _hakkimdaServis = hakkimdaServis;
            _kullaniciServis = kullaniciServis;
        }

        public IActionResult Index()
        {
           
            var hakkimda = _hakkimdaServis.HakkimdaGetir();
            var kullanici = _kullaniciServis.KullanicilariGetir();
            HakkimdaModel model = new HakkimdaModel
            {
                Hakkimda = hakkimda,
                SuperAdmin = kullanici

            };
            return View(model);
        }
    }
}
