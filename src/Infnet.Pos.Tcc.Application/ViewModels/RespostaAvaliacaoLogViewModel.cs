using System;
using System.ComponentModel.DataAnnotations;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Enums;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class RespostaAvaliacaoLogViewModel : BaseViewModel
    {
        public string AvaliacaoCodigo { get; set; }

        [Display(Name = "Questão")]
        public string Questao { get; set; }

        public EscalaLikert Resposta { get; set; }

        [Display(Name = "CPF do Professor")]
        public string ProfessorCpf { get; set; }

        [Display(Name = "Nome do Professor")]
        public string ProfessorNome { get; set; }

        [Display(Name = "CPF do Aluno")]
        public string AlunoCpf { get; set; }

        [Display(Name = "Nome do Aluno")]
        public string AlunoNome { get; set; }

        [Display(Name = "Descrição da Turma")]
        public string TurmaDescricao { get; set; }

        [Display(Name = "Início da Turma")]
        public DateTime TurmaInicio { get; set; }

        [Display(Name = "Término da Turma")]
        public DateTime TurmaTermino { get; set; }

        [Display(Name = "Descrição do Módulo")]
        public string ModuloDescricao { get; set; }

        [Display(Name = "Descrição do Bloco")]
        public string BlocoDescricao { get; set; }

        [Display(Name = "Descrição do Curso")]
        public string CursoDescricao { get; set; }
    }
}