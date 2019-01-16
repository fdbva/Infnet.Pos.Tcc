using System;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class QuestaoViewModel : BaseViewModel
    {
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public bool Ativa { get; set; }
        public Guid GrupoQuestaoId { get; set; }
        public GrupoQuestaoViewModel GrupoQuestao { get; set; }
    }
}