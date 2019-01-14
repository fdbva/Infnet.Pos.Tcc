using Infnet.Pos.Tcc.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration
{
    public class RespostaAvaliacaoLogConfig : IEntityTypeConfiguration<RespostaAvaliacaoLog>
    {
        public void Configure(EntityTypeBuilder<RespostaAvaliacaoLog> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}