using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Infrastructure.Persistence.Repositories
{
    internal class ConexaoRepository : IConexaoRepository
    {
        private readonly SocialMediaDbContext _context;

        public ConexaoRepository(SocialMediaDbContext context)
        {
            _context = context;
        }

        public int Add(Conexao conexao)
        {
            _context.Conexoes.Add(conexao);
            _context.SaveChanges();

            return conexao.Id;
        }

        public void Delete(Conexao conexao)
        {
            _context.Conexoes.Update(conexao);
            _context.SaveChanges();
        }

        public Conexao? GetById(int id)
        {
            var conexao = _context.Conexoes
                .SingleOrDefault(c => c.Id == id);

            return conexao;
        }

        public void Update(Conexao conexao)
        {
            _context.Conexoes.Update(conexao);
            _context.SaveChanges();
        }
        public List<Conexao>? GetAll(int idPerfil)
        {
           var listaConexao = _context
                .Conexoes
                .Where(c => c.IdPerfil == idPerfil)
                .ToList();

            return listaConexao;
        }

    }
}
