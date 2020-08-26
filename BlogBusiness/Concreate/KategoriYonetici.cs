﻿using BlogBusiness.Abstract;
using BlogDataAccess.Abstract;
using BlogEntites.BlogDb;
using BlogEntities.Abstract;
using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBusiness.Concreate
{
    public class KategoriYonetici : IKategoriServis
    {
        private IKategoriDal _kategoriDal;

        public KategoriYonetici(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }
        public void Ekle(Kategori kategori)
        {
            _kategoriDal.Ekle(kategori);

        }

        public void Guncelle(Kategori kategori)
        {
            _kategoriDal.Guncelle(kategori);
        }

        public List<Kategori> KategoriGetir(int KategoriId)
        {
            return _kategoriDal.ListeGetir(p => p.KategoriId == KategoriId);

        }

        public List<Kategori> KategorileriGetir()
        {
            return _kategoriDal.ListeGetir();
        }

        public void Sil(int id)
        {
            _kategoriDal.Sil(new Kategori { KategoriId = id });

        }
    }
}
