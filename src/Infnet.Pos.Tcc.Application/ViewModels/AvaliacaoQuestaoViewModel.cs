using System;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class AvaliacaoQuestaoViewModel : BaseViewModel
    {
        public string Questao { get; set; }
        public string GrupoQuestao { get; set; }
        public Guid AvaliacaoId { get; set; }
        public AvaliacaoViewModel Avaliacao { get; set; }
    }
}