using Agendamentos.Domain.Models;
using Agendamentos.Domain.ViewModels.Request;

namespace Agendamentos.Domain.Interfaces.Adapters
{
    public interface IAgendamentoModelToViewModel
    {
        AgendamentoModel ViewModelToModel(AgendamentoRequest agendamentoRequest);
    }
}