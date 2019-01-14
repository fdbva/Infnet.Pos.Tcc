using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class AvaliacaoQuestaoConfig : IEntityTypeConfiguration<AvaliacaoQuestao>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoQuestao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Avaliacao)
                .WithMany(x => x.AvaliacaoQuestoes)
                .HasForeignKey(x=>x.AvaliacaoId);
        }
    }
}