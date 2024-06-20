using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private readonly TestDbContext _context;

        public RegiaoRepository(TestDbContext context)
        {
            _context = context;
        }

        public IQueryable<Regiao> List()
        {
            return _context.Regioes.Include(r => r.RegiaoCidades).AsQueryable();
        }

        public async Task<Regiao> GetByIdAsync(Guid id)
        {
            return await _context.Regioes.Include(r => r.RegiaoCidades)
                                         .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task AddAsync(Regiao regiao)
        {
            await _context.Regioes.AddAsync(regiao);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Regiao regiao)
        {
            _context.Regioes.Update(regiao);
            await _context.SaveChangesAsync();
        }
    }
}
