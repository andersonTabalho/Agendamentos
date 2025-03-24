using barbearia.Domain.Interfaces.Adapters;
using barbearia.Domain.Interfaces.Applications;
using barbearia.Domain.Interfaces.Repositories;
using barbearia.Domain.Models;
using barbearia.Domain.ViewModels.Request;

namespace barbearia.Application.Applications
{
    public class AgendamentoApp(IAgendamentoModelToViewModel agendamentoApp,
                                IAgendamentoRepository<AgendamentoModel> agendamentoRepository) : IAgendamentoApp
    {
        private readonly IAgendamentoModelToViewModel _agendamentoAdapter = agendamentoApp;
        private readonly IAgendamentoRepository<AgendamentoModel> _agendamentoRepository = agendamentoRepository;

        public void Adicionar(AgendamentoRequest agendamento)
        {
            AgendamentoModel map = _agendamentoAdapter.ViewModelToModel(agendamento);
            _agendamentoRepository.Insert(map);
        }
    }
}