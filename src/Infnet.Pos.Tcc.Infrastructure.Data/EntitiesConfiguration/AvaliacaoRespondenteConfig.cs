using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class AvaliacaoRespondenteConfig : IEntityTypeConfiguration<AvaliacaoRespondente>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoRespondente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Avaliacao)
                .WithMany(x => x.AvaliacaoRespondentes)
                .HasForeignKey(x => x.AvaliacaoId);

            builder.HasOne(x => x.Respondente)
                .WithMany(x => x.AvaliacoesRespondente)
                .HasForeignKey(x => x.RespondenteId);
        }
    }
}