namespace SocialMedia.Core.Entities
{
    public class Perfil : BaseEntity
    {
        public Perfil(int idConta, string nomeExibicao, string sobre, string foto, string localidade, string profissao)
            : base()
        {
            IdConta = idConta;
            NomeExibicao = nomeExibicao;
            Sobre = sobre;
            Foto = foto;
            Localidade = localidade;
            Profissao = profissao;

            Publicacoes = [];
            ConexoesPerfil = [];
            ConexoesPerfilSeguido = [];
        }

        public int IdConta { get; private set; }
        public Conta Conta { get; private set; }
        public string NomeExibicao { get; private set; }
        public string Sobre { get; private set; }
        public string Foto { get; private set; }
        public string Localidade { get; private set; }
        public string Profissao { get; private set; }
        public List<Publicacao> Publicacoes { get; private set; }


        public List<Conexao> ConexoesPerfil { get; private set; }
        public List<Conexao> ConexoesPerfilSeguido { get; private set; }

        public void Update(string nomeExibicao, string sobre, string foto, string localidade, string profissao)
        {
            NomeExibicao = nomeExibicao;
            Sobre = sobre;
            Foto = foto;
            Localidade = localidade;
            Profissao = profissao;
        }

    }
}
