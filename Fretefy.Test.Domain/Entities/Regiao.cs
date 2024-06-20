using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        public Regiao()
        {
            RegiaoCidades = new List<RegiaoCidade>();
        }

        public Regiao(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            RegiaoCidades = new List<RegiaoCidade>();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<RegiaoCidade> RegiaoCidades { get; set; }
    }

    public class RegiaoCidade : IEntity
    {
        public RegiaoCidade()
        {
        }

        public RegiaoCidade(Guid regiaoId, string nome)
        {
            Id = Guid.NewGuid();
            RegiaoId = regiaoId;
            Nome = nome;
        }

        public Guid Id { get; set; }
        public Guid RegiaoId { get; set; }
        public Regiao Regiao { get; set; }
        public string Nome { get; set; }
    }
}
