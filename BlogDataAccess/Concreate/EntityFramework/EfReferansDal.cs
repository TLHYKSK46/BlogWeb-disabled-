using BlogCore.Dao.EntityFramework;
using BlogEntities.BlogDb;
using BlogEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

using BlogEntites.BlogDb;
using BlogDataAccess.Abstract;
using BlogDataAccess.Concreate.EntityFramework;

namespace BlogDataAccess.Concreate.EntityFramework
{
    public class EfReferansDal : EfEntityRepositoryBase<Referans, BlogContext>, IReferansDal
    {
    }
}
