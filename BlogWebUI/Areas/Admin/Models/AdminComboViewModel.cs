using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogWebUI.Areas.Admin.Models
{
    public class AdminComboViewModel
    {
        public int SelectedKatId { get; internal set; }
        public SelectList SelectedKatData { get; internal set; }
    }
}