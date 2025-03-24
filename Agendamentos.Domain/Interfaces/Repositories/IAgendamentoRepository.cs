using Stratega.Domain.Interfaces.Repositories;

namespace Agendamentos.Domain.Interfaces.Repositories
{
    public interface IAgendamentoRepository<T> : IRepository<T> where T : class
    {
    }
}
