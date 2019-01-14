using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class CursoViewModel : BaseViewModel
    {
        public string Descricao { get; set; }
        public ICollection<BlocoViewModel> Blocos { get; set; }
    }
}