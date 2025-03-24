using Stratega.Domain.Models;

namespace Agendamentos.Domain.Models
{
    public class LojaModel : BaseEntity
    {
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        public string Responsavel { get; private set; }
    }
}