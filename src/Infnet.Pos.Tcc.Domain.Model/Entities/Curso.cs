using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Curso : BaseEntity
    {
        public string Descricao { get; set; }
        public ICollection<Bloco> Blocos { get; set; }
    }
}