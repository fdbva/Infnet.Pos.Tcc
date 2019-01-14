namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class TurmaProfessor : BaseEntity
    {
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}