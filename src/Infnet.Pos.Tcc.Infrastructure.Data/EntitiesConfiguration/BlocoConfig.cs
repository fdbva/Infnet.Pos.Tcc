using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class BlocoConfig : IEntityTypeConfiguration<Bloco>
    {
        public void Configure(EntityTypeBuilder<Bloco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Curso)
                .WithMany(x => x.Blocos)
                .HasForeignKey(x => x.CursoId);
        }
    }
}