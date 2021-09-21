using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_RemoverAcentuacao.Entities
{
    public class Pessoa
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public Pessoa(Guid id, string nome, string cidade)
        {
            Id = id;
            Nome = nome;
            Cidade = cidade;
        }
    }
}
