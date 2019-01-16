using System.Collections.Generic;
using System.Threading.Tasks;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories;
using Infnet.Pos.Tcc.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Repositories
{
    public class AvaliacaoRespondenteRepository : BaseRepository<AvaliacaoRespondente>, IAvaliacaoRespondenteRepository
    {
        public AvaliacaoRespondenteRepository(AvaliacaoContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<AvaliacaoRespondente>> GetAllAsNoTrackingAsync()
        {
            return await Set.AsNoTracking()
                .Include(x => x.Avaliacao)
                .Include(x => x.Respondente)
                .ToListAsync();
        }
    }
}