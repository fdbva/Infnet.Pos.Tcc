using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Bloco : BaseEntity
    {
        public string Descricao { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public ICollection<Modulo> Modulos { get; set; }
    }
}