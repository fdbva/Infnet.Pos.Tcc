using System;
using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class RespondenteViewModel : BaseViewModel
    {
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public ICollection<AvaliacaoRespondenteViewModel> AvaliacoesRespondente { get; set; }
        public ICollection<TurmaRespondenteViewModel> TurmasRespondente { get; set; }
    }
}