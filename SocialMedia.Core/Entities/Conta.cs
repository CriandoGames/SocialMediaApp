namespace SocialMedia.Core.Entities
{
    public class Conta : BaseEntity
    {
        public Conta(string nomeCompleto, string senha, string email, DateTime dataNascimento, string telefone)
            : base()
        {
            NomeCompleto = nomeCompleto;
            Senha = senha;
            Email = email;
            DataNascimento = dataNascimento;
            Telefone = telefone;

            Perfis = [];
        }

        public string NomeCompleto { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public List<Perfil> Perfis { get; private set; }

        public void Update(string nomeCompleto, DateTime dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
        }

        public void MudarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }

    }

}
