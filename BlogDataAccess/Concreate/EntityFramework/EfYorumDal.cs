﻿using BlogCore.Dao.EntityFramework;
using BlogDataAccess.Abstract;
using BlogDataAccess.Concreate.EntityFramework;
using BlogEntites.BlogDb;
using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDataAccess.Concreate.EntityFramework
{
    public class EfYorumDal : EfEntityRepositoryBase<Yorum, BlogContext>, IYorumDal
    {
    }
}
