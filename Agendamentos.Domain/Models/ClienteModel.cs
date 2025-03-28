﻿using Stratega.Domain.Models;

namespace Agendamentos.Domain.Models
{
    public class ClienteModel : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
    }
}
