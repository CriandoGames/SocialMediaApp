using SocialMedia.Core.Entities;

namespace SocialMedia.Tests.Core
{
    public class ContaTests
    {
        [Fact]
        public void TestaCriarObjetoContaValido()
        {
            //Arrange
            var nomeCompleto = "Marcos Paulo";
            var senha = "12345";
            var email = "email.com.br";
            var dataNascimento = DateTime.Now;
            var telefone = "85 9 87975543";

            //Act
            var conta = new Conta(nomeCompleto, senha, email, dataNascimento, telefone);

            //Assert
            Assert.Equal(nomeCompleto, conta.NomeCompleto);
            Assert.Equal(senha, conta.Senha);
            Assert.Equal(email, conta.Email);
            Assert.Equal(dataNascimento, conta.DataNascimento);
            Assert.Equal(telefone, conta.Telefone);
            Assert.True(conta.Perfis.Count == 0);
        }

        [Fact]
        public void TestaUpdate()
        {
            //Arrange
            var nomeCompleto = "Marcos Paulo";
            var senha = "12345";
            var email = "email.com.br";
            var dataNascimento = DateTime.Today;
            var telefone = "85 9 87975543";

            var conta = new Conta(nomeCompleto, senha, email, dataNascimento, telefone);

            var novoNomeCompleto = "Paulo Marcos";
            var novaDataNascimento = DateTime.Today.AddDays(10);

            //Act
            conta.Update(novoNomeCompleto, novaDataNascimento);

            //Assert
            Assert.Equal(novoNomeCompleto, conta.NomeCompleto);
            Assert.Equal(novaDataNascimento, conta.DataNascimento);

        }

        [Fact]
        public void TestaMudarSenha()
        {
            //Arrange
            var nomeCompleto = "Marcos Paulo";
            var senha = "12345";
            var email = "email.com.br";
            var dataNascimento = DateTime.Now;
            var telefone = "85 9 87975543";

            var conta = new Conta(nomeCompleto, senha, email, dataNascimento, telefone);

            var novaSenha = "abcdef";

            //Act
            conta.MudarSenha(novaSenha);

            //Assert
            Assert.Equal(novaSenha, conta.Senha);
        }

    }

}
