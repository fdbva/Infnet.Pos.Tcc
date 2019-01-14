namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class AvaliacaoQuestao : BaseEntity
    {
        public string Questao { get; set; }
        public string GrupoQuestao { get; set; }
        public int AvaliacaoId { get; set; }
        public Avaliacao Avaliacao { get; set; }
    }
}