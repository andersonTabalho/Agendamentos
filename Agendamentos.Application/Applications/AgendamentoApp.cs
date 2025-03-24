using Agendamentos.Domain.Interfaces.Adapters;
using Agendamentos.Domain.Interfaces.Applications;
using Agendamentos.Domain.Interfaces.Repositories;
using Agendamentos.Domain.Models;
using Agendamentos.Domain.ViewModels.Request;

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