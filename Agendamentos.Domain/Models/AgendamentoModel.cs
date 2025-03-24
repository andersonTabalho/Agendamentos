using Stratega.Domain.Models;

namespace Agendamentos.Domain.Models
{
    public class AgendamentoModel : BaseEntity
    {
        public ClienteModel ClienteId { get;  set; }
        public LojaModel LojaId { get;  set; }
        public DateTime DataHora { get;  set; }
        public string Status { get;  set; }
    }
}