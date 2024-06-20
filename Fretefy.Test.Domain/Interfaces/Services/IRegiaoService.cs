using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface IRegiaoService
    {
        Regiao Get(Guid id);
        IEnumerable<Regiao> List();
        Task AddAsync(Regiao regiao);
        Task UpdateAsync(Regiao regiao);
    }
}
