using System;
using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Respondente : BaseEntity
    {
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<AvaliacaoRespondente> AvaliacoesRespondente { get; set; }
        public ICollection<TurmaRespondente> TurmasRespondente { get; set; }
    }
}