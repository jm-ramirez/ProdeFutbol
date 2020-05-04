using System.ComponentModel.DataAnnotations;

namespace ProdeFutbol.Web.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
