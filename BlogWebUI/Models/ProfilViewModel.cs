using BlogEntities.BlogDb;
using System.Collections.Generic;

namespace BlogWebUI.Models
{
    public class ProfilViewModel
    {
        public List<Kullanici> SuperAdmin { get; internal set; }
    }
}