using Linq_RemoverAcentuacao.Entities;
using System;
using System.Collections.Generic;

namespace Linq_RemoverAcentuacao
{
    public static class Dados
    {
        public static List<Pessoa> ObterPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa(new Guid(), "Maria José", "Maringá"),
                new Pessoa(new Guid(), "Marcos Antônio", "São Paulo"),
                new Pessoa(new Guid(), "Carlos", "Ibirité"),
                new Pessoa(new Guid(), "Cláudio André", "Maceió"),
                new Pessoa(new Guid(), "Sérgio", "Rio de Janeiro"),
                new Pessoa(new Guid(), "Paulo", "Belo Horizonte"),
                new Pessoa(new Guid(), "Aparecida", "Curitiba"),
                new Pessoa(new Guid(), "Teste", "Teste")
            };
        }
    }
}
