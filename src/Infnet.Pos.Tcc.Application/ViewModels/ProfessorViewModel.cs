using System.Collections.Generic;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class ProfessorViewModel : BaseViewModel
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public ICollection<TurmaProfessorViewModel> TurmasProfessor { get; set; }
    }
}