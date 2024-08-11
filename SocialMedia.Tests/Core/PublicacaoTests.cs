using SocialMedia.Core.Entities;

namespace SocialMedia.Tests.Core
{
    public class PublicacaoTests
    {
        [Fact]
        public void TestaCriarObjetoPublicacaoValido()
        {
            //Arrange
            var idPerfil = 1;
            var conteudo = "Uma nova publicação.";
            var dataPublicacao = DateTime.Today;
            var localidade = "Fortaleza-CE";

            //Act
            var publicacao = new Publicacao(idPerfil, conteudo, dataPublicacao, localidade);

            //Assert
            Assert.Equal(idPerfil, publicacao.IdPerfil);
            Assert.Equal(conteudo, publicacao.Conteudo);
            Assert.Equal(dataPublicacao, publicacao.DataPublicacao);
            Assert.Equal(localidade, publicacao.Localidade);
        }

        [Fact]
        public void TestaUpdate()
        {
            //Arrange
            var idPerfil = 1;
            var conteudo = "Uma nova publicação.";
            var dataPublicacao = DateTime.Today;
            var localidade = "Fortaleza-CE";

            var publicacao = new Publicacao(idPerfil, conteudo, dataPublicacao, localidade);

            var NovoConteudo = "Uma mais nova publicação.";
            var NovaDataPublicacao = DateTime.Today.AddDays(10);
            var NovaLocalidade = "Fortaleza-CE";

            //Act
            publicacao.Update(NovoConteudo, NovaDataPublicacao, NovaLocalidade);

            //Assert
            Assert.Equal(NovoConteudo, publicacao.Conteudo);
            Assert.Equal(NovaDataPublicacao, publicacao.DataPublicacao);
            Assert.Equal(NovaLocalidade, publicacao.Localidade);
        }

    }

}
