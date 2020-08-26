﻿using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBusiness.Abstract
{
   public interface IIletisimServis
    {
        List<Iletisim> IletisimBilgileriniGetir();
        List<Iletisim> IletisimGetir(int IletisimId);
        void Ekle(Iletisim iletisim);
        void Guncelle(Iletisim iletisim);
        void Sil(int id);

    }
}
