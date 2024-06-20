using Fretefy.Test.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        IQueryable<Regiao> List();
        Task<Regiao> GetByIdAsync(Guid id);
        Task AddAsync(Regiao regiao);
        Task UpdateAsync(Regiao regiao);
    }
}
