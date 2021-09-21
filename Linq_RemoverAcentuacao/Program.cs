using Linq_RemoverAcentuacao.Entities;
using Linq_RemoverAcentuacao.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Linq_RemoverAcentuacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = Dados.ObterPessoas();
            Filtro filtro = MontarFiltro();

            pessoas = Filtrar(filtro, pessoas);
            GerarResposta(pessoas);

            Console.ReadKey();
        }

        private static Filtro MontarFiltro()
        {
            Filtro filtro = new Filtro();

            Console.WriteLine("Nome: ");
            filtro.Nome = Console.ReadLine();

            Console.WriteLine("Cidade: ");
            filtro.Cidade = Console.ReadLine();

            return filtro;
        }

        private static List<Pessoa> Filtrar(Filtro filtros, List<Pessoa> pessoas)
        {
            Type type = filtros.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo p in properties)
            {
                var nomeCampo = p.Name;
                var valorCampo = p.GetValue(filtros, null).ToString().RemoveDiacritics();

                if (!string.IsNullOrEmpty(valorCampo))
                {
                    pessoas = pessoas.Where(p => p.GetType().GetProperties().Where(x => x.Name == nomeCampo).FirstOrDefault().GetValue(p, null).ToString().ToLower().RemoveDiacritics().Contains(valorCampo.ToLower())).ToList();
                }
            }

            return pessoas;
        }

        private static void GerarResposta(List<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Cidade}");
            }
        }
    }
}
