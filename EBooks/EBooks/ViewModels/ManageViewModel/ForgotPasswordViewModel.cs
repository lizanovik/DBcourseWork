using System.ComponentModel.DataAnnotations;

namespace EBooks.ViewModels.ManageViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
