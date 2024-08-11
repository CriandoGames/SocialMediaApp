using SocialMedia.Core.Entities;

namespace SocialMedia.Tests.Core
{
    public class PerfilTests
    {
        [Fact]
        public void TestaCriarObjetoPerfilValido()
        {
            //Arrange
            var idConta = 1;
            var nomeExibicao = "Marcos Paulo";
            var sobre = "Olá, Eu sou Marcos Paulo.";
            var foto = "link da foto";
            var localidade = "Fortaleza-CE";
            var profissao = "Desenvolvedor .NET";

            //Act
            var perfil = new Perfil(idConta, nomeExibicao,sobre,foto,localidade, profissao);

            //Assert
            Assert.Equal(idConta,perfil.IdConta);
            Assert.Equal(nomeExibicao, perfil.NomeExibicao);
            Assert.Equal(sobre, perfil.Sobre);
            Assert.Equal(foto, perfil.Foto);
            Assert.Equal(localidade, perfil.Localidade);
            Assert.Equal(profissao, perfil.Profissao);
            Assert.True(perfil.Publicacoes.Count == 0);
        }

        [Fact]
        public void TestaUpdate()
        {
            //Arrange
            var idConta = 1;
            var nomeExibicao = "Marcos Paulo";
            var sobre = "Olá, Eu sou Marcos Paulo.";
            var foto = "link da foto";
            var localidade = "Fortaleza-CE";
            var profissao = "Desenvolvedor .NET";

            var perfil = new Perfil(idConta, nomeExibicao, sobre, foto, localidade, profissao);

            var NovoNomeExibicao = "Paulo Marcos";
            var NovoSobre = "Hello, I´m Paulo Marcos";
            var NovaFoto = "link photo";
            var NovaLocalidade = "Fortaleza-CE";
            var NovaProfissao = "Develop .NET";

            //Act
            perfil.Update(NovoNomeExibicao, NovoSobre, NovaFoto, NovaLocalidade, NovaProfissao);

            //Assert
            Assert.Equal(NovoNomeExibicao, perfil.NomeExibicao);
            Assert.Equal(NovoSobre, perfil.Sobre);
            Assert.Equal(NovaFoto, perfil.Foto);
            Assert.Equal(NovaLocalidade, perfil.Localidade);
            Assert.Equal(NovaProfissao, perfil.Profissao);

        }

    }

}
