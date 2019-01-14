﻿using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories;
using Infnet.Pos.Tcc.Infrastructure.Data.Context;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Repositories
{
    public class RespostaAvaliacaoLogRepository : BaseRepository<RespostaAvaliacaoLog>, IRespostaAvaliacaoLogRepository
    {
        public RespostaAvaliacaoLogRepository(AvaliacaoContext context) : base(context)
        {
        }
    }
}