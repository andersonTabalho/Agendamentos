using barbearia.Domain.Models;
using barbearia.Domain.ViewModels.Request;

namespace barbearia.Domain.Interfaces.Applications
{
    public interface IAgendamentoApp
    {
        void Adicionar(AgendamentoRequest agendamento);
    }
}