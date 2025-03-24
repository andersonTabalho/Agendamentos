using barbearia.Domain.Models;
using barbearia.Domain.ViewModels.Request;

namespace barbearia.Domain.Interfaces.Adapters
{
    public interface IAgendamentoModelToViewModel
    {
        AgendamentoModel ViewModelToModel(AgendamentoRequest agendamentoRequest);
    }
}