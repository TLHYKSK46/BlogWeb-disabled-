using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogumUI.Areas.Admin.Models
{
    public class AdminMakaleViewModel
    {
        public List<Makale> Makaleler { get; internal set; }
    }
}
