using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class GrupoQuestao : BaseEntity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public ICollection<Questao> Questoes { get; set; }
    }
}