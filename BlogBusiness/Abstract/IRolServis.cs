using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBusiness.Abstract
{
   public interface IRolServis
    {
        List<Rol> RolleriGetir();
        List<Rol> RolGetir(int rolId);
        void Ekle(Rol rol);
        void Guncelle(Rol rol);
        void Sil(int id);

    }
}
