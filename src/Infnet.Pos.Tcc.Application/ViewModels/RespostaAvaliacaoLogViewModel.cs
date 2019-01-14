using System;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Enums;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class RespostaAvaliacaoLogViewModel : BaseViewModel
    {
        public string AvaliacaoCodigo { get; set; }
        public string Questao { get; set; }
        public EscalaLikert Resposta { get; set; }
        public string ProfessorCpf { get; set; }
        public string ProfessorNome { get; set; }
        public string AlunoCpf { get; set; }
        public string AlunoNome { get; set; }
        public string TurmaDescricao { get; set; }
        public DateTime TurmaInicio { get; set; }
        public DateTime TurmaTermino { get; set; }
        public string ModuloDescricao { get; set; }
        public string BlocoDescricao { get; set; }
        public string CursoDescricao { get; set; }
    }
}