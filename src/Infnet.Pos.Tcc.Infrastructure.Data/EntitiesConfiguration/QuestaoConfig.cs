using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class QuestaoConfig : IEntityTypeConfiguration<Questao>
    {
        public void Configure(EntityTypeBuilder<Questao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.GrupoQuestao)
                .WithMany(x => x.Questoes)
                .HasForeignKey(x => x.GrupoQuestaoId);
        }
    }
}