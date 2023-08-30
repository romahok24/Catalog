using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.DTO
{
    public class RegistrationModelDTO
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; } = null!;

        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = null!;
    }
}