using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Persistence.Mappings
{
    public class ConexaoMap : IEntityTypeConfiguration<Conexao>
    {
        public void Configure(EntityTypeBuilder<Conexao> builder)
        {
            builder.ToTable("Conexao");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataConexao)
                .HasColumnType("datetime")
                .IsRequired();

        }
    }
}
