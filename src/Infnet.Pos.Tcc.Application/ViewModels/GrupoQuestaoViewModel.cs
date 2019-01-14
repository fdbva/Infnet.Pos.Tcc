using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class GrupoQuestaoViewModel : BaseViewModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public ICollection<QuestaoViewModel> Questoes { get; set; }
    }
}