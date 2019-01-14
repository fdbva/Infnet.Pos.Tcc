using System;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class TurmaProfessor : BaseEntity
    {
        public Guid TurmaId { get; set; }
        public Turma Turma { get; set; }
        public Guid ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}