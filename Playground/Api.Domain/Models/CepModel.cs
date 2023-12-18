using System;

namespace Api.Domain.Models
{
    public class CepModel
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }

        private string _numero;
        public string Numero
        {
            get => _numero;
            set => _numero = value ?? "S/N";
        }

        public Guid MunicipioId { get; set; }
    }
}
