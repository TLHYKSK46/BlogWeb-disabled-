using BlogCore.Dao.EntityFramework;
using BlogDataAccess.Abstract;
using BlogDataAccess.Concreate.EntityFramework;
using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDataAccess.Concreate.EntityFramework
{
    public class EfMakaleDal : EfEntityRepositoryBase<Makale, BlogContext>, IMakaleDal
    {
    }
}
