using System;
using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class BlocoViewModel : BaseViewModel
    {
        public string Descricao { get; set; }
        public Guid CursoId { get; set; }
        public CursoViewModel Curso { get; set; }
        public ICollection<ModuloViewModel> Modulos { get; set; }
    }
}