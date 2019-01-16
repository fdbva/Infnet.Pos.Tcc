using System.Collections.Generic;
using System.Threading.Tasks;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories;
using Infnet.Pos.Tcc.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Repositories
{
    public class BlocoRepository : BaseRepository<Bloco>, IBlocoRepository
    {
        public BlocoRepository(AvaliacaoContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Bloco>> GetAllAsNoTrackingAsync()
        {
            return await Set.AsNoTracking().Include(x => x.Curso).ToListAsync();
        }
    }
}