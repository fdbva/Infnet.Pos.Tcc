using System;
using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class AvaliacaoViewModel : BaseViewModel
    {
        public string Codigo { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public ICollection<AvaliacaoQuestaoViewModel> AvaliacaoQuestoes { get; set; }
        public ICollection<AvaliacaoRespondenteViewModel> AvaliacaoRespondentes { get; set; }
    }
}