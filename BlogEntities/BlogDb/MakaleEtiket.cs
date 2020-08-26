using BlogEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEntites.BlogDb
{
   public  class MakaleEtiket:IEntity
    {
        public int MakaleId { get; set; }
        public int EtiketId { get; set; }
    }
}
