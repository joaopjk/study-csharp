﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class MunicipioEntity : BaseEntity
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }

        public int CodIbge { get; set; }

        [Required]
        public Guid EfId { get; set; }
        public UfEntity Uf { get; set; }
        public IEnumerable<CepEntity> Ceps { get; set; }
    }
}
