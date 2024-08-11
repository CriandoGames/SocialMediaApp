using Moq;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Tests.Infrastructure
{
    public class ContaRepositoryTests
    {
        public ContaRepositoryTests()
        {
           
            IList<Conta> contas = new List<Conta>
            {
                new Conta("Marcos Paulo", "12345", "mp.com.br", DateTime.Today, "85 9 87975543"),
                new Conta("Paulo Marcos", "12345", "pm.com.br", DateTime.Today, "85 9 88986523")
            };

            Mock<IContaRepository> mockContaRepository = new Mock<IContaRepository>();

            // return a product by Email
            mockContaRepository.Setup(mr => mr.GetByEmail(
                It.IsAny<string>())).Returns((string s) => contas.Where(
                    x => x.Email == s).Single());

            //mockContaRepository.Setup(mr => mr.Add(It.IsAny<Conta>())).Returns(
            //    (Conta target) =>
            //    {
            //        DateTime now = DateTime.Now;

            //        if (target.Id.Equals(default(int)))
            //        {
            //            target.Id = contas.Count() + 1;
            //            contas.Add(target);
            //        }
            //        else
            //        {
            //            var original = contas.Where(
            //                q => q.Id == target.Id).Single();

            //            if (original is null)
            //            {
            //                return 0;
            //            }
            //            original.NomeCompleto = target.NomeCompleto;
            //            original.Senha = target.Senha;
            //            original.Email = target.Email;
            //            original.DataNascimento = target.DataNascimento;
            //            original.Telefone = target.Telefone;
            //        }
            //        return 1;
            //    });

            this.MockContasRepository = mockContaRepository.Object;
        }

        public readonly IContaRepository MockContasRepository;


        [Fact]
        public void TestaGetByEmail()
        {
            //Arange + Act
            var testConta = this.MockContasRepository.GetByEmail("mp.com.br");

            //Assert
            Assert.NotNull(testConta);
        }

        [Fact]
        public void TestaAdd()
        {
            //Arange
            Conta novaConta = new Conta("Rebeca", "12345", "rc.com.br", DateTime.Today, "85 9 87975543");
            this.MockContasRepository.Add(novaConta);

            //Act
            var testConta = MockContasRepository.GetByEmail("rc.com.br");

            //Assert
            Assert.NotNull(testConta);
        }

        [Fact]
        public void TestaUpdate()
        {
            //Arange + 
            var conta = this.MockContasRepository.GetByEmail("mp.com.br");

            var novoNome = "Novo Nome";
            var novaDataNascimento = DateTime.Today.AddDays(10);

            conta.Update(novoNome, novaDataNascimento);

            //Act
            this.MockContasRepository.Update(conta);

            //Assert
            Assert.Equal(novoNome, MockContasRepository.GetByEmail("mp.com.br").NomeCompleto);
            Assert.Equal(novaDataNascimento, MockContasRepository.GetByEmail("mp.com.br").DataNascimento);

        }
    }
}
