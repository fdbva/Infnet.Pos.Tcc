namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class TurmaRespondente : BaseEntity
    {
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int RespondenteId { get; set; }
        public Respondente Respondente { get; set; }
    }
}