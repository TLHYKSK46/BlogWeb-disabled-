
using BlogEntites.BlogDb;
using BlogEntities.BlogDb;
using FluentValidation;

namespace BlogBusinnes.FluentRules.FluentValidation
{
    public class ReferansValidatior : AbstractValidator<Referans>
    {
        public ReferansValidatior()
        {

            RuleFor(p => p.ProjeAdi).NotEmpty().WithMessage("Kategori Boş Geçemez");//bu şekilde kendi mesajlarımızı verebiliyoruz..
            RuleFor(p => p.ProjedeKullanilanTeknolojiler).NotEmpty();//boş olamaz
            RuleFor(p => p.ProjeTanim).NotEmpty();//boş olmaz
            RuleFor(p => p.ProjeTarih).NotEmpty();//boş olmaz
            RuleFor(p => p.ProjeFoto).NotEmpty();//boş olmaz


        }


    }
}