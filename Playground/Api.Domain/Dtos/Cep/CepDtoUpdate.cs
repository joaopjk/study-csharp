using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoUpdate
    {
        [Required(ErrorMessage = "Id do Municipío é um campo obrigatório!")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "CEP é campo obrigatório!")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é um campo obrigatório!")]
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        [Required(ErrorMessage = "Id do Municipío é um campo obrigatório!")]
        public Guid MunicipioId { get; set; }
    }
}
