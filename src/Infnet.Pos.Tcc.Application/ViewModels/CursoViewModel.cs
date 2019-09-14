using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class CursoViewModel : BaseViewModel
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<BlocoViewModel> Blocos { get; set; }
    }
}