﻿using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class AvaliacaoQuestaoAppService : BaseAppService<IAvaliacaoQuestaoService, AvaliacaoQuestao, AvaliacaoQuestaoViewModel>, IAvaliacaoQuestaoAppService
    {
        public AvaliacaoQuestaoAppService(IAvaliacaoQuestaoService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}