using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class TurmaRespondenteConfig : IEntityTypeConfiguration<TurmaRespondente>
    {
        public void Configure(EntityTypeBuilder<TurmaRespondente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Turma)
                .WithMany(x => x.TurmaRespondentes)
                .HasForeignKey(x => x.TurmaId);

            builder.HasOne(x => x.Respondente)
                .WithMany(x => x.TurmasRespondente)
                .HasForeignKey(x => x.RespondenteId);
        }
    }
}