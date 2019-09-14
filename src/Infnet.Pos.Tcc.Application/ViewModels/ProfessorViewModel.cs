using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class ProfessorViewModel : BaseViewModel
    {
        [Display(Name = "CPF")]
        public int Cpf { get; set; }

        public string Nome { get; set; }
        public ICollection<TurmaProfessorViewModel> TurmasProfessor { get; set; }
    }
}