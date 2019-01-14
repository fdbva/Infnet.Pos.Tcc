using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class CursoConfig : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}