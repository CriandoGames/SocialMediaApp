using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Infrastructure.Persistence.Repositories
{
    public class ContaRepository : IContaRepository
    {
        private readonly SocialMediaDbContext _context;

        public ContaRepository(SocialMediaDbContext context)
        {
            _context = context;
        }

        public int Add(Conta conta)
        {
            _context.Contas.Add(conta);
            _context.SaveChanges();

            return conta.Id;
        }
        public void Update(Conta conta)
        {
            _context.Contas.Update(conta);
            _context.SaveChanges();
        }
        public Conta? GetById(int id)
        {
            var conta = _context.Contas
                .SingleOrDefault(c => c.Id == id);

            return conta;
        }
        public Conta? GetByEmail(string email)
        {
            var conta = _context.Contas
                .SingleOrDefault(c => c.Email == email);

            return conta;
        }
        public void Delete(Conta conta)
        {
            _context.Contas.Update(conta);
            _context.SaveChanges();
        }

        public void AddPerfil(Perfil perfil)
        {
            _context.Perfis.Add(perfil);
            _context.SaveChanges();
        }
    }
}
