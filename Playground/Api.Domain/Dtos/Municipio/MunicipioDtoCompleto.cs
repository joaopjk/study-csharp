﻿using Api.Domain.Dtos.UF;
using System;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCompleto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIbge { get; set; }
        public Guid UfId { get; set; }
        public UfDto Uf { get; set; }
    }
}
