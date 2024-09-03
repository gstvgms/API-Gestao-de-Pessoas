using Adapter.DataPersistency;
using BusinessModels;
using BusinessModels.Comands;

namespace Application
{
    public class GerenciamentoPessoaService
    {
        private readonly IGerenciamentoPessoaRepository _fonteDeDados;

        public GerenciamentoPessoaService(IGerenciamentoPessoaRepository fonteDeDados)
        {
            _fonteDeDados = fonteDeDados;
        }

        public void AtualizarNome(Guid id, string novoNome)
        {
            var pessoa = _fonteDeDados.ObterTodasPessoas().FirstOrDefault(p => p.Id == id);

            if (pessoa != null)
            {
               pessoa.AtualizarNome(novoNome);
            }
        }

        public void AtualizarEmail(Guid id, string novoEmail)
        {
            var pessoa = _fonteDeDados.ObterTodasPessoas().FirstOrDefault(p => p.Id == id);

            if (pessoa != null)
            {
                pessoa.AtualizarEmail(novoEmail);
            }
        }

        public void AtualizarIdade(Guid id, int novaIdade)
        {
            var pessoa = _fonteDeDados.ObterTodasPessoas().FirstOrDefault(p => p.Id == id);

            if (pessoa != null)
            {
                pessoa.AtualizarIdade(novaIdade);
            }
        }

        public IEnumerable<GerenciamentoPessoas> ObterTodasPessoas()
        {
            return _fonteDeDados.ObterTodasPessoas();
        }

        public RegistrarPessoaDTO.Resultado RegistrarPessoa(RegistrarPessoaDTO.Requisito requisito)
        {
            var pessoa = new GerenciamentoPessoas(requisito);
            var registrado = _fonteDeDados.RegistrarPessoa(pessoa);
            var pessoaRegistrada = new RegistrarPessoaDTO.Resultado(registrado);
            return pessoaRegistrada;
        }

        public void DeletarPessoa(Guid id)
        {
            var pessoa = _fonteDeDados.ObterTodasPessoas().FirstOrDefault(p => p.Id == id);

            if (pessoa != null)
            {
                _fonteDeDados.DeletarPessoa(id);
            }
        }
    }
}
