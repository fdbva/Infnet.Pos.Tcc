using System;
using System.ComponentModel.DataAnnotations;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Enums;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class AvaliacaoRespondenteViewModel : BaseViewModel
    {
        public Guid AvaliacaoId { get; set; }

        [Display(Name = "Avaliação")]
        public AvaliacaoViewModel Avaliacao { get; set; }

        public Guid RespondenteId { get; set; }

        [Display(Name = "Respondente")]
        public RespondenteViewModel Respondente { get; set; }

        public DateTime Respondido { get; set; }
        public DateTime Enviado { get; set; }
        public StatusEmail StatusEmail { get; set; }
    }
}