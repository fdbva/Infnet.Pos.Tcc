using System;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class TurmaRespondente : BaseEntity
    {
        public Guid TurmaId { get; set; }
        public Turma Turma { get; set; }
        public Guid RespondenteId { get; set; }
        public Respondente Respondente { get; set; }
    }
}