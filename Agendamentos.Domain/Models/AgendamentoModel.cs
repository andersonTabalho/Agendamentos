using Stratega.Domain.Models;

namespace barbearia.Domain.Models
{
    public class AgendamentoModel : BaseEntity
    {
        public ClienteModel ClienteId { get;  set; }
        public BarbeariaModel BarbeiroId { get;  set; }
        public DateTime DataHora { get;  set; }
        public string Status { get;  set; }
    }
}