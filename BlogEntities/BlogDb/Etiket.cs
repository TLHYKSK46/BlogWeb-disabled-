using BlogEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEntites.BlogDb
{
   public class Etiket:IEntity
    {
        public int EtiketId { get; set; }
        public string EtiketAdi { get; set; }


    }
}
