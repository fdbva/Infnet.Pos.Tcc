using System;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Enums;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class AvaliacaoRespondente : BaseEntity
    {
        public Guid AvaliacaoId { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Guid RespondenteId { get; set; }
        public Respondente Respondente { get; set; }
        public DateTime Respondido { get; set; }
        public DateTime Enviado { get; set; }
        public StatusEmail StatusEmail { get; set; }
    }
}