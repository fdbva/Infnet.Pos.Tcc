using AutoMapper;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;

namespace Infnet.Pos.Tcc.Application.AutoMapper
{
    public class MappingsWithReverse : Profile
    {
        public MappingsWithReverse()
        {
            CreateMap<Avaliacao, AvaliacaoViewModel>().ReverseMap();
            CreateMap<AvaliacaoQuestao, AvaliacaoQuestaoViewModel>().ReverseMap();
            CreateMap<AvaliacaoRespondente, AvaliacaoRespondenteViewModel>().ReverseMap();
            CreateMap<Bloco, BlocoViewModel>().ReverseMap();
            CreateMap<Curso, CursoViewModel>().ReverseMap();
            CreateMap<GrupoQuestao, GrupoQuestaoViewModel>().ReverseMap();
            CreateMap<Modulo, ModuloViewModel>().ReverseMap();
            CreateMap<Professor, ProfessorViewModel>().ReverseMap();
            CreateMap<Questao, QuestaoViewModel>().ReverseMap();
            CreateMap<Respondente, RespondenteViewModel>().ReverseMap();
            CreateMap<RespostaAvaliacaoLog, RespostaAvaliacaoLogViewModel>().ReverseMap();
            CreateMap<Turma, TurmaViewModel>().ReverseMap();
            CreateMap<TurmaProfessor, TurmaProfessorViewModel>().ReverseMap();
            CreateMap<TurmaRespondente, TurmaRespondenteViewModel>().ReverseMap();
        }
    }
}