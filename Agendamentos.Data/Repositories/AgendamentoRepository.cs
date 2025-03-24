using barbearia.Domain.Interfaces.Repositories;
using barbearia.Domain.Models;

namespace barbearia.Data.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository<AgendamentoModel>
    {
        private readonly BarberShopContext _context;

        public AgendamentoRepository(BarberShopContext context)
        {
            _context = context;
        }
    }
}