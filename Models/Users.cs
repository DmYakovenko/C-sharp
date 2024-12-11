using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ім'я обов'язкове.")]
        [StringLength(20, ErrorMessage = "Ім'я не може перевищувати 20 символів.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email обов'язковий.")]
        [EmailAddress(ErrorMessage = "Неправильний Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Вік обов'язковий.")]
        [Range(1, 100, ErrorMessage = "Вік повинен бути в діапазоні 1-100 років.")]
        public int Age { get; set; }
    }
}
