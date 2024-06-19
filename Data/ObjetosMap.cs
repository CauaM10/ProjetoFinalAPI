using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class ObjetosMap : IEntityTypeConfiguration<ObjetosModel>
    {
        public void Configure(EntityTypeBuilder<ObjetosModel> builder)
        {
            builder.HasKey(x => x.ObjetoId);
            builder.Property(x => x.ObjetoNome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObjetoCor).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObjetoObservacao).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObjetoLocalDesaparecimeto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObjetoFoto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObjetoDtDesaparecimeto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObjetoDtEncontro).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObjetoStatus).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UsuarioId).IsRequired().HasMaxLength(255);
        }
    }
}