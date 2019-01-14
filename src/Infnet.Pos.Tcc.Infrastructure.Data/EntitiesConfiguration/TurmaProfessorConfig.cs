using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class TurmaProfessorConfig : IEntityTypeConfiguration<TurmaProfessor>
    {
        public void Configure(EntityTypeBuilder<TurmaProfessor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Turma)
                .WithMany(x => x.TurmaProfessores)
                .HasForeignKey(x => x.TurmaId);

            builder.HasOne(x => x.Professor)
                .WithMany(x => x.TurmasProfessor)
                .HasForeignKey(x => x.ProfessorId);
        }
    }
}