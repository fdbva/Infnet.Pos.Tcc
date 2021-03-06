﻿using System;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Questao : BaseEntity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Ativa { get; set; }
        public Guid GrupoQuestaoId { get; set; }
        public GrupoQuestao GrupoQuestao { get; set; }
    }
}