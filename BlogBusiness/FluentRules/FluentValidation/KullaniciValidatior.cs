
using BlogEntities.BlogDb;
using FluentValidation;

namespace BlogBusinnes.FluentRules.FluentValidation
{
    public class KullaniciValidatior : AbstractValidator<Kullanici>
    {
        public KullaniciValidatior()
        {

            /* RuleFor(p => p.CategoryID).NotEmpty().WithMessage("Kategori Boş Geçemez");//bu şekilde kendi mesajlarımızı verebiliyoruz..
             RuleFor(p => p.ProductName).NotEmpty();//boş olamaz
             RuleFor(p => p.UnitPrice).GreaterThan(0);//sıfırdan büyük olmalı
             RuleFor(p => p.QuantityPerUnit).NotEmpty();//boş olamaz
             RuleFor(p => p.ProductName).Length(2, 20);//min :2 max:20 olabilir
             RuleFor(p => p.UnitPrice).GreaterThan(20).When(p => p.CategoryID == 1);//kategori ıd 1 ise minumum degeri 20 olsun
             /*RuleFor(p => p.ProductName).Must(Kural);//Kendi Kurallarımızıda oluşturur
             */
            RuleFor(p => p.KullaniciId).NotEmpty().WithMessage("Kategori Boş Geçemez");//bu şekilde kendi mesajlarımızı verebiliyoruz..
            RuleFor(p => p.Parola).NotEmpty();//boş olamaz
            //RuleFor(p => p.).GreaterThan(0);//sıfırdan büyük olmalı
            RuleFor(p => p.RolId).NotEmpty();//boş olamaz
            RuleFor(p => p.KulAdSoyad).NotEmpty();//boş olamz
            RuleFor(p => p.Email).NotEmpty();//boş olamz

        }


    }
}