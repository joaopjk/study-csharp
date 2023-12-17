using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo email é obrigátorio!")]
        [EmailAddress(ErrorMessage = "Email em formato inválido!")]
        public string Email { get; set; }
    }
}
