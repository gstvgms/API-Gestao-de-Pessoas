using BusinessModels.Comands;

namespace BusinessModels
{
    public class GerenciamentoPessoas
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public String Email { get; private set; }
        public int Age { get; private set; }
        public GerenciamentoPessoas() { }
        public GerenciamentoPessoas(RegistrarPessoaDTO.Requisito requisito)
        {
            Id = Guid.NewGuid();
            Name = requisito.Name;
            Email = requisito.Email;
            Age = requisito.Age;
        }

        public void AtualizarNome(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
            {
                throw new ArgumentException("Nome não pode ser vazio ou nulo.");
            }

            Name = novoNome;
        }

        public void AtualizarEmail(string novoEmail)
        {
            if (string.IsNullOrWhiteSpace(novoEmail))
            {
                throw new ArgumentException("Email não pode ser vazio ou nulo.");
            }

            Email = novoEmail;
        }

        public void AtualizarIdade(int novaIdade)
        {
            if (novaIdade < 0)
            {
                throw new ArgumentException("Idade não pode ser negativa.");
            }

            Age = novaIdade;
        }
    }
}
