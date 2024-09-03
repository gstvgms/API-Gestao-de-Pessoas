using BusinessModels;

namespace Adapter.DataPersistency
{
    public interface IGerenciamentoPessoaRepository
    {
        IEnumerable<GerenciamentoPessoas> ObterTodasPessoas();
        GerenciamentoPessoas RegistrarPessoa(GerenciamentoPessoas pessoas);

        GerenciamentoPessoas ObterRegistro(Guid pessoaId);
        void DeletarPessoa(Guid id);
    }
}
