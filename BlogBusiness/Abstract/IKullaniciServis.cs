using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBusiness.Abstract
{
   public interface IKullaniciServis
    {
        List<Kullanici> KullanicilariGetir();
        List<Kullanici> RoleGoreGetir(int rolId);
        void Ekle(Kullanici kullanici);
        void Guncelle(Kullanici kullanici);
        void Sil(int id);

    }
}
