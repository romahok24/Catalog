using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.DTO.DTO
{
    public class UserDTO
    {
        public string Id { get; set; }

        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Роль")]
        public string Role { get; set; }

        [Display(Name = "Блокировка")]
        public bool IsBlocked { get; set; }
    }
}
