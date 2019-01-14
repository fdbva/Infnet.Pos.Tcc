using System;
using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Turma : BaseEntity
    {
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int ModuloId { get; set; }
        public Modulo Modulo { get; set; }
        public ICollection<Professor> Professores { get; set; }
        public ICollection<Respondente> Respondentes { get; set; }
        public ICollection<TurmaRespondente> TurmaRespondentes { get; set; }
        public ICollection<TurmaProfessor> TurmaProfessores { get; set; }
    }
}