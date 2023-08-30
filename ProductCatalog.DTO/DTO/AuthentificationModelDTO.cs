using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.DTO
{
    public class AuthentificationModelDTO
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = null!;
    }
}
