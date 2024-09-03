using Adapter.DataPersistency;
using BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.InMemory
{
    public class GerenciamentoPessoaInMemoryRepository
        : IGerenciamentoPessoaRepository
    {

        private static List<GerenciamentoPessoas> GerenciamentoPessoas { get; set; } = new List<GerenciamentoPessoas>();


        public GerenciamentoPessoas ObterRegistro(Guid pessoaId)
        {
            var pessoa = GerenciamentoPessoas.FirstOrDefault(p => p.Id == pessoaId);
            if (pessoa == null)
            {
                throw new InvalidOperationException("Pessoa não encontrada");
            }
            return pessoa;
        }

        public IEnumerable<GerenciamentoPessoas> ObterTodasPessoas()
        {
            return GerenciamentoPessoas;
        }

        public GerenciamentoPessoas RegistrarPessoa(GerenciamentoPessoas pessoas)
        {
            GerenciamentoPessoas.Add(pessoas);
            return pessoas;
        }

        public GerenciamentoPessoas EditarPessoa(GerenciamentoPessoas pessoas)
        {
            var existingPessoa = GerenciamentoPessoas.FirstOrDefault(p => p.Id == pessoas.Id);
            if (existingPessoa == null)
            {
                throw new InvalidOperationException("Pessoa não encontrada");
            }

            existingPessoa.AtualizarNome(pessoas.Name);
            existingPessoa.AtualizarEmail(pessoas.Email);
            existingPessoa.AtualizarIdade(pessoas.Age);
            return existingPessoa;

        }

        public void DeletarPessoa(Guid id)
        {
            var pessoa = GerenciamentoPessoas.FirstOrDefault(p => p.Id == id);
            if (pessoa == null)
            {
                throw new InvalidOperationException("Pessoa não encontrada");
            }

            GerenciamentoPessoas.Remove(pessoa);
        }
    }
}
