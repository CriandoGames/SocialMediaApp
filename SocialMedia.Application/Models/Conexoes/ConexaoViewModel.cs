using SocialMedia.Core.Entities;

namespace SocialMedia.Application.Models.Conexoes
{
    public class ConexaoViewModel
    {
        public ConexaoViewModel(int id, int idPerfil, int idPerfilSeguido, DateTime dataConexao)
        {
            Id = id;
            IdPerfil = idPerfil;
            IdPerfilSeguido = idPerfilSeguido;
            DataConexao = dataConexao;
        }

        public int Id { get; set; }

        public int IdPerfil { get; private set; }

        public int IdPerfilSeguido { get; private set; }

        public DateTime DataConexao { get;  set; }

        public static ConexaoViewModel? FromEntity(Conexao entity)
            => new(
                entity.Id,
                entity.IdPerfil,
                entity.IdPerfilSeguido,
                entity.DataConexao
                );
    }
}
