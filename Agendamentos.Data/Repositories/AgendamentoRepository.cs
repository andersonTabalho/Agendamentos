using barbearia.Domain.Interfaces.Repositories;
using barbearia.Domain.Models;

namespace barbearia.Data.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository<AgendamentoModel>
    {
        private readonly AgendamentoContext _context;

        public AgendamentoRepository(AgendamentoContext context)
        {
            _context = context;
        }
    }
}