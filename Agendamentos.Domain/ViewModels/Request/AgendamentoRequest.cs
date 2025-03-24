
using Agendamentos.Domain.Models;
using Stratega.Domain.Models;

namespace Agendamentos.Domain.ViewModels.Request
{
    public class AgendamentoRequest : BaseEntity
    {
        public ClienteModel ClienteId { get; private set; }
        public LojaModel LojaId { get; private set; }
        public DateTime DataHora { get; private set; }
        public string Status { get; private set; }
    }

}