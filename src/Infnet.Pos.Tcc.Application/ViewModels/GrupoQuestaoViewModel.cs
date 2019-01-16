using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class GrupoQuestaoViewModel : BaseViewModel
    {
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<QuestaoViewModel> Questoes { get; set; }
    }
}