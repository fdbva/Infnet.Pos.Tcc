﻿using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public class Modulo : BaseEntity
    {
        public string Descricao { get; set; }
        public int BlocoId { get; set; }
        public Bloco Bloco { get; set; }
        public ICollection<Turma> Turmas { get; set; }
    }
}