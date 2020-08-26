using BlogCore.Dao.EntityFramework;
using BlogEntities.BlogDb;
using BlogEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using BlogDataAccess.Abstract;

namespace BlogDataAccess.Concreate.EntityFramework
{
    public class EfHakkimdaDal : EfEntityRepositoryBase<Hakkimda, BlogContext>, IHakkimdaDal
    {
    }
}
