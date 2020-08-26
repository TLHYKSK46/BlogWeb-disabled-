using BlogCore.Dao.EntityFramework;
using BlogEntities.BlogDb;
using BlogEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using BlogDataAccess.Abstract;
using BlogDataAccess.Concreate.EntityFramework;

namespace BlogDataAccess.Concreate.EntityFramework
{
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, BlogContext>, IKullaniciDal
    {
    }
}
