using Agendamentos.Domain.Interfaces.Adapters;
using Agendamentos.Domain.Models;
using Agendamentos.Domain.ViewModels.Request;

namespace AgendamentoHelper.Adapters
{
    internal class AgendamentoViewModelToModel : IAgendamentoModelToViewModel
    {
        public AgendamentoModel ViewModelToModel(AgendamentoRequest request) => new()
        {
            Id = request.Id,
            LojaId = request.LojaId,
            ClienteId = request.ClienteId,
            DataHora = request.DataHora,
            Status = request.Status
        };
    }
}
