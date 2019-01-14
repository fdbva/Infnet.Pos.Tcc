using System;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class TurmaRespondenteViewModel : BaseViewModel
    {
        public Guid TurmaId { get; set; }
        public TurmaViewModel Turma { get; set; }
        public Guid RespondenteId { get; set; }
        public RespondenteViewModel Respondente { get; set; }
    }
}