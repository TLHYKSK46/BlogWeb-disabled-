using BlogCore.Dao.EntityFramework;
using BlogEntities.BlogDb;
using BlogEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using BlogEntites.BlogDb;
using BlogDataAccess.Concreate.EntityFramework;
using BlogDataAccess.Abstract;

namespace BlogDal.Concreate.EntityFramework
{
    public class EfRolDal : EfEntityRepositoryBase<Rol, BlogContext>, IRolDal
    {
    }
}
