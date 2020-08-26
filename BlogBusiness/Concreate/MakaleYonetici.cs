﻿using BlogBusiness.Abstract;
using BlogEntities.BlogDb;
using System.Collections.Generic;
using BlogBusinnes.FluentRules.FluentValidation;
using BlogCores.Aspects.Postsharp;
using BlogDataAccess.Abstract;

namespace BlogBusiness.Concreate
{
    public class MakaleYonetici : IMakaleServis
    {
        private IMakaleDal _makaleDal;

        public MakaleYonetici(IMakaleDal makaleDal)
        {
            _makaleDal = makaleDal;
        }
        
        //[FluentValidationAspect(typeof(MakaleValidatior))]
        public void Ekle(Makale makale)
        {
            //ValidatorTool.FluentValidate(new MakaleValidatior(),makale);//FLUENT VALİdation bu şekilde de kullanılır ama bu solid e uymuyor onda attirbute olrak yazdık
            _makaleDal.Ekle(makale);
        }

        //[FluentValidationAspect(typeof(MakaleValidatior))]
        public void Guncelle(Makale makale)
        {
            //ValidatorTool.FluentValidate(new MakaleValidatior(),makale);//FLUENT VALİdation
            _makaleDal.Guncelle(makale);

        }

        public List<Makale> KategoriyeGoreGetir(int KategoriId)
        {

            return _makaleDal.ListeGetir(p => p.KategoriId == KategoriId || KategoriId == 0);


        }



        public List<Makale> MakaleGetir(int MakaleId)
        {
            return _makaleDal.ListeGetir(p => p.MakaleId == MakaleId);
        }

        public List<Makale> MakaleleriGetir()
        {
            return _makaleDal.ListeGetir();

        }


        public void Sil(int id)
        {
            _makaleDal.Sil(new Makale { MakaleId = id });


        }
    }
}
