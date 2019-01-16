using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class AvaliacaoViewModel : BaseViewModel
    {
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public ICollection<AvaliacaoQuestaoViewModel> AvaliacaoQuestoes { get; set; }
        public ICollection<AvaliacaoRespondenteViewModel> AvaliacaoRespondentes { get; set; }
    }
}