using Stratega.Domain.Interfaces.Repositories;

namespace barbearia.Domain.Interfaces.Repositories
{
    public interface IAgendamentoRepository<T> : IRepository<T> where T : class
    {
    }
}
