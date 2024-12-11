using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "��'� ����'������.")]
        [StringLength(20, ErrorMessage = "��'� �� ���� ������������ 20 �������.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email ����'�������.")]
        [EmailAddress(ErrorMessage = "������������ Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "³� ����'�������.")]
        [Range(1, 100, ErrorMessage = "³� ������� ���� � ������� 1-100 ����.")]
        public int Age { get; set; }
    }
}
