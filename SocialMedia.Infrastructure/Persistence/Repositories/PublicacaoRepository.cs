using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Persistence.Repositories
{
    internal class PublicacaoRepository : IPublicacaoRepository
    {
        private readonly SocialMediaDbContext _context;

        public PublicacaoRepository(SocialMediaDbContext context)
        {
            _context = context;
        }

        public int Add(Publicacao publicacao)
        {
            _context.Publicacoes.Add(publicacao);
            _context.SaveChanges();

            return publicacao.Id;
        }
        public void Update(Publicacao publicacao)
        {
            _context.Publicacoes.Update(publicacao);
            _context.SaveChanges();
        }
        public void Delete(Publicacao publicacao)
        {
            _context.Publicacoes.Update(publicacao);
            _context.SaveChanges();
        }
        public Publicacao? GetById(int id)
        {
            var publicacao = _context
                .Publicacoes
                .SingleOrDefault(p => p.Id == id);  

            return publicacao;
        }
        public List<Publicacao>? GetAll(int idPerfil)
        {
            var listaPublicacoes = _context
                .Publicacoes
                .Where(p => p.IdPerfil == idPerfil && p.IsDeleted == false)
                .ToList();

            return listaPublicacoes;
        }
    }
}
