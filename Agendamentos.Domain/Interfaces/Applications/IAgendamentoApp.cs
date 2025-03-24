
using Agendamentos.Domain.ViewModels.Request;

namespace Agendamentos.Domain.Interfaces.Applications
{
    public interface IAgendamentoApp
    {
        void Adicionar(AgendamentoRequest agendamento);
    }
}