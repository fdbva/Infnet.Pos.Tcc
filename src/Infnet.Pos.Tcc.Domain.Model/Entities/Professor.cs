using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Professor : BaseEntity
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<TurmaProfessor> TurmasProfessor { get; set; }
    }
}