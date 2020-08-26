
using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebUI.Models
{
    public class HakkimdaModel
    {
        public List<Hakkimda> Hakkimda { get; internal set; }
        public List<Kullanici> Kullanici { get; internal set; }
        public List<Kullanici> SuperAdmin { get; internal set; }
    }
}
