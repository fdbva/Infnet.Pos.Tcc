using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class GrupoQuestaoConfig : IEntityTypeConfiguration<GrupoQuestao>
    {
        public void Configure(EntityTypeBuilder<GrupoQuestao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Codigo).IsUnique();
        }
    }
}