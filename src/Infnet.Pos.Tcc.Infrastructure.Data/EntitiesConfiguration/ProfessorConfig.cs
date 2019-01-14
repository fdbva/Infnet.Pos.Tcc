using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class ProfessorConfig : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}