using System;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class TurmaProfessorViewModel : BaseViewModel
    {
        public Guid TurmaId { get; set; }
        public TurmaViewModel Turma { get; set; }
        public Guid ProfessorId { get; set; }
        public ProfessorViewModel Professor { get; set; }
    }
}