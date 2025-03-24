using Agendamentos.Data;
using Agendamentos.Domain.Interfaces.Repositories;
using Agendamentos.Domain.Models;
using System.Linq.Expressions;

namespace barbearia.Data.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository<AgendamentoModel>
    {
        private readonly AgendamentoContext _context;

        public AgendamentoRepository(AgendamentoContext context)
        {
            _context = context;
        }

        public void Delete(AgendamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(AgendamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<AgendamentoModel> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(List<AgendamentoModel> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AgendamentoModel?> Find(Expression<Func<AgendamentoModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AgendamentoModel? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<AgendamentoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AgendamentoModel?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(AgendamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(AgendamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public void InsertRange(List<AgendamentoModel> entities)
        {
            throw new NotImplementedException();
        }

        public Task InsertRangeAsync(List<AgendamentoModel> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(AgendamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AgendamentoModel entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<AgendamentoModel> entities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<AgendamentoModel> entities)
        {
            throw new NotImplementedException();
        }
    }
}