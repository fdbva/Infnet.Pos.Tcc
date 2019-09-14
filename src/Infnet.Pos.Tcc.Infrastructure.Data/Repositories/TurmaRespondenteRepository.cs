﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories;
using Infnet.Pos.Tcc.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Repositories
{
    public class TurmaRespondenteRepository : BaseRepository<TurmaRespondente>, ITurmaRespondenteRepository
    {
        public TurmaRespondenteRepository(AvaliacaoContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TurmaRespondente>> GetAllAsNoTrackingAsync()
        {
            return await Set.AsNoTracking()
                .Include(x => x.Turma)
                .Include(x => x.Respondente)
                .ToListAsync();
        }
    }
}