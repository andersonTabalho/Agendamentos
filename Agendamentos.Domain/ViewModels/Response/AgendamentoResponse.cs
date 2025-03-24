using barbearia.Domain.Models;
using Stratega.Domain.Models;

namespace barbearia.Domain.ViewModels.Response
{
    internal class AgendamentoResponse : BaseEntity
    {
        public ClienteModel ClienteId { get; private set; }
        public BarbeariaModel BarbeiroId { get; private set; }
        public DateTime DataHora { get; private set; }
        public string Status { get; private set; }
    }
}
