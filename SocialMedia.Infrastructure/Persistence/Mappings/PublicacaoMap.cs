using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Persistence.Mappings
{
    public class PublicacaoMap : IEntityTypeConfiguration<Publicacao>
    {
        public void Configure(EntityTypeBuilder<Publicacao> builder)
        {
            builder.ToTable("Publicacao");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Conteudo)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(p => p.DataPublicacao)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.Localidade)
                .HasColumnType("varchar(20)")
                .IsRequired();

        }
    }
}
