using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Context
{
    public class AvaliacaoContextFactory : IDesignTimeDbContextFactory<AvaliacaoContext>
    {
        public AvaliacaoContext CreateDbContext(string[] args)
        {
            //TODO: resolver acesso a banco e connection strings
            var optionsBuilder = new DbContextOptionsBuilder<AvaliacaoContext>();
            optionsBuilder.UseSqlServer(
                "Server=fva;Database=InfnetPosMvc;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new AvaliacaoContext(optionsBuilder.Options);
        }
    }
}