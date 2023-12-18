using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCreate
    {
        [Required(ErrorMessage = "O nome do município é obrigatótio!")]
        [MaxLength(60, ErrorMessage = "Nome do município deve ter no máximo {1} caracteres!")]
        public string Nome { get; set; }

        [Range(0,int.MaxValue, ErrorMessage = "Código do IBGE inválido!")]
        public int CodIbge { get; set; }

        [Required(ErrorMessage = "Código de UF é campo obrigatório!")]
        public Guid UfId { get; set; }
    }
}
