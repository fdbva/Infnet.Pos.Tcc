using System;
using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Avaliacao : BaseEntity
    {
        public string Codigo { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public ICollection<AvaliacaoQuestao> AvaliacaoQuestoes { get; } = new List<AvaliacaoQuestao>();
        public ICollection<AvaliacaoRespondente> AvaliacaoRespondentes { get; } = new List<AvaliacaoRespondente>();
    }
}