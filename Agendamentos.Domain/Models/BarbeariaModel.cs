﻿using Stratega.Domain.Models;

namespace barbearia.Domain.Models
{
    public class BarbeariaModel : BaseEntity
    {
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        public string Responsavel { get; private set; }
    }
}