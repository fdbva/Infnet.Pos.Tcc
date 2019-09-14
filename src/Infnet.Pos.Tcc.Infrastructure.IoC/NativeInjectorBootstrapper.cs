using AutoMapper;
using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.AppServices.Implementations;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UoW;
using Infnet.Pos.Tcc.Domain.Service.Services;
using Infnet.Pos.Tcc.Infrastructure.Data.Context;
using Infnet.Pos.Tcc.Infrastructure.Data.Repositories;
using Infnet.Pos.Tcc.Infrastructure.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace Infnet.Pos.Tcc.Infrastructure.IoC
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddAutoMapper();
            services.AddScoped<IAvaliacaoAppService, AvaliacaoAppService>();
            services.AddScoped<IAvaliacaoQuestaoAppService, AvaliacaoQuestaoAppService>();
            services.AddScoped<IAvaliacaoRespondenteAppService, AvaliacaoRespondenteAppService>();
            services.AddScoped<IBlocoAppService, BlocoAppService>();
            services.AddScoped<ICursoAppService, CursoAppService>();
            services.AddScoped<IGrupoQuestaoAppService, GrupoQuestaoAppService>();
            services.AddScoped<IModuloAppService, ModuloAppService>();
            services.AddScoped<IProfessorAppService, ProfessorAppService>();
            services.AddScoped<IQuestaoAppService, QuestaoAppService>();
            services.AddScoped<IRespondenteAppService, RespondenteAppService>();
            services.AddScoped<IRespostaAvaliacaoLogAppService, RespostaAvaliacaoLogAppService>();
            services.AddScoped<ITurmaAppService, TurmaAppService>();
            services.AddScoped<ITurmaProfessorAppService, TurmaProfessorAppService>();
            services.AddScoped<ITurmaRespondenteAppService, TurmaRespondenteAppService>();

            // Domain.Services
            services.AddScoped<IAvaliacaoService, AvaliacaoService>();
            services.AddScoped<IAvaliacaoQuestaoService, AvaliacaoQuestaoService>();
            services.AddScoped<IAvaliacaoRespondenteService, AvaliacaoRespondenteService>();
            services.AddScoped<IBlocoService, BlocoService>();
            services.AddScoped<ICursoService, CursoService>();
            services.AddScoped<IGrupoQuestaoService, GrupoQuestaoService>();
            services.AddScoped<IModuloService, ModuloService>();
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddScoped<IQuestaoService, QuestaoService>();
            services.AddScoped<IRespondenteService, RespondenteService>();
            services.AddScoped<IRespostaAvaliacaoLogService, RespostaAvaliacaoLogService>();
            services.AddScoped<ITurmaService, TurmaService>();
            services.AddScoped<ITurmaProfessorService, TurmaProfessorService>();
            services.AddScoped<ITurmaRespondenteService, TurmaRespondenteService>();

            // Infrastructure.Data
            services.AddDbContext<AvaliacaoContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<IAvaliacaoQuestaoRepository, AvaliacaoQuestaoRepository>();
            services.AddScoped<IAvaliacaoRespondenteRepository, AvaliacaoRespondenteRepository>();
            services.AddScoped<IBlocoRepository, BlocoRepository>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IGrupoQuestaoRepository, GrupoQuestaoRepository>();
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();
            services.AddScoped<IQuestaoRepository, QuestaoRepository>();
            services.AddScoped<IRespondenteRepository, RespondenteRepository>();
            services.AddScoped<IRespostaAvaliacaoLogRepository, RespostaAvaliacaoLogRepository>();
            services.AddScoped<ITurmaRepository, TurmaRepository>();
            services.AddScoped<ITurmaProfessorRepository, TurmaProfessorRepository>();
            services.AddScoped<ITurmaRespondenteRepository, TurmaRespondenteRepository>();
        }
    }
}