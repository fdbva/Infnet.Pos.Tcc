using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class ModuloConfig : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Bloco)
                .WithMany(x => x.Modulos)
                .HasForeignKey(x => x.BlocoId);
        }
    }
}