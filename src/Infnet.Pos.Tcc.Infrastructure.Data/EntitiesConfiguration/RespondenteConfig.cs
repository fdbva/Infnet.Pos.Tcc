using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class RespondenteConfig : IEntityTypeConfiguration<Respondente>
    {
        public void Configure(EntityTypeBuilder<Respondente> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}