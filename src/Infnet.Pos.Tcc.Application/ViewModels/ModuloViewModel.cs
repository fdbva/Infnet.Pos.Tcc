using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class ModuloViewModel : BaseViewModel
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public Guid BlocoId { get; set; }
        public BlocoViewModel Bloco { get; set; }
        public ICollection<TurmaViewModel> Turmas { get; set; }
    }
}