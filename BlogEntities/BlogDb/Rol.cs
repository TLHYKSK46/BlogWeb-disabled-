using BlogEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEntities.BlogDb
{
   public class Rol:IEntity
    {
        public int RolId { get; set; }
        public String RolAdi { get; set; }
        public string RolYetki { get; set; }

    }
}
