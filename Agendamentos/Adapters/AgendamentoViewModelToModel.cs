using barbearia.Domain.Interfaces.Adapters;
using barbearia.Domain.Models;
using barbearia.Domain.ViewModels.Request;

namespace AgendamentoHelper.Adapters
{
    internal class AgendamentoViewModelToModel : IAgendamentoModelToViewModel
    {
        public AgendamentoModel ViewModelToModel(AgendamentoRequest request) => new()
        {
            Id = request.Id,
            BarbeiroId = request.BarbeiroId,
            ClienteId = request.ClienteId,
            DataHora = request.DataHora,
            Status = request.Status
        };
    }
}
