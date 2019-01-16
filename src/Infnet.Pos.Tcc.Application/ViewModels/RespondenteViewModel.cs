using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class RespondenteViewModel : BaseViewModel
    {
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }
        public ICollection<AvaliacaoRespondenteViewModel> AvaliacoesRespondente { get; set; }
        public ICollection<TurmaRespondenteViewModel> TurmasRespondente { get; set; }
    }
}