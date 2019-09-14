using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class TurmaViewModel : BaseViewModel
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public Guid ModuloId { get; set; }
        public ModuloViewModel Modulo { get; set; }
        public ICollection<TurmaRespondenteViewModel> TurmaRespondentes { get; set; }
        public ICollection<TurmaProfessorViewModel> TurmaProfessores { get; set; }
    }
}