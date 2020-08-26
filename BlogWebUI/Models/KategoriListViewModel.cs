using BlogEntites.BlogDb;
using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebUI.Models
{
    public class KategoriListViewModel
    {
        public List<Kategori> Kategoriler { get; internal set; }
        public int seciliOlanKategori { get; internal set; }
        public List<Makale> Makaleler { get; internal set; }
    }
}
