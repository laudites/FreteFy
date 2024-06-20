using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public Regiao Get(Guid id)
        {
            return _regiaoRepository.List().FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Regiao> List()
        {
            return _regiaoRepository.List();
        }

        public async Task AddAsync(Regiao regiao)
        {
            await _regiaoRepository.AddAsync(regiao);
        }

        public async Task UpdateAsync(Regiao regiao)
        {
            await _regiaoRepository.UpdateAsync(regiao);
        }
    }
}
