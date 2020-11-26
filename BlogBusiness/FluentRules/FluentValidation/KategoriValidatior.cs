
using BlogEntites.BlogDb;
using BlogEntities.BlogDb;
using FluentValidation;

namespace BlogBusinnes.FluentRules.FluentValidation
{
    public class KategoriValidatior : AbstractValidator<Kategori>
    {
        public KategoriValidatior()
        {

            RuleFor(p => p.KategoriId).NotEmpty().WithMessage("Kategori Boş Geçemez");//bu şekilde kendi mesajlarımızı verebiliyoruz..
            RuleFor(p => p.KategoriAdi).NotEmpty();//boş olamaz
     

        }


    }
}