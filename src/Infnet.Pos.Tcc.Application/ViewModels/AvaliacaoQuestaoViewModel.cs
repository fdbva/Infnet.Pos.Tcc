using System;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class AvaliacaoQuestaoViewModel : BaseViewModel
    {
        [Display(Name = "Código")]
        public string Questao { get; set; }

        [Display(Name = "Grupo de Questões")]
        public string GrupoQuestao { get; set; }

        public Guid AvaliacaoId { get; set; }

        [Display(Name = "Avaliação")]
        public AvaliacaoViewModel Avaliacao { get; set; }
    }
}