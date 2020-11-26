
using System;
using System.ComponentModel.DataAnnotations;

namespace BlogWebUI.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Rolü boş geçmeyiniz.")]
        [Display(Name = "Rol Adı")]
        public string Name { get; internal set; }
    
    }
}