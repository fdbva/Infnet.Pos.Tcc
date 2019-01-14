using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class TurmaConfig : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Modulo)
                .WithMany(x => x.Turmas)
                .HasForeignKey(x => x.ModuloId);
        }
    }
}