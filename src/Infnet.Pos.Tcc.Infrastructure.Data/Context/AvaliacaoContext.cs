using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Infrastructure.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Context
{
    public class AvaliacaoContext : DbContext
    {
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<AvaliacaoQuestao> AvaliacaoQuestoes { get; set; }
        public DbSet<AvaliacaoRespondente> AvaliacaoRespondentes { get; set; }
        public DbSet<Bloco> Blocos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<GrupoQuestao> GrupoQuestoes { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Questao> Questoes { get; set; }
        public DbSet<Respondente> Respondentes { get; set; }
        public DbSet<RespostaAvaliacaoLog> RespostasAvaliacoesLog { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<TurmaProfessor> TurmasProfessores { get; set; }
        public DbSet<TurmaRespondente> TurmasRespondentes { get; set; }

        public AvaliacaoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: resolver acesso a banco e connection strings
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //optionsBuilder.UseSqlServer(config.GetConnectionString("EvaluationLocalMsSql"));
            optionsBuilder.UseSqlServer(
                @"Server=06-21738\DEVDRE;Database=tccAvaliacao;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AvaliacaoConfig());
            modelBuilder.ApplyConfiguration(new AvaliacaoQuestaoConfig());
            modelBuilder.ApplyConfiguration(new AvaliacaoRespondenteConfig());
            modelBuilder.ApplyConfiguration(new BlocoConfig());
            modelBuilder.ApplyConfiguration(new CursoConfig());
            modelBuilder.ApplyConfiguration(new GrupoQuestaoConfig());
            modelBuilder.ApplyConfiguration(new ModuloConfig());
            modelBuilder.ApplyConfiguration(new ProfessorConfig());
            modelBuilder.ApplyConfiguration(new QuestaoConfig());
            modelBuilder.ApplyConfiguration(new RespondenteConfig());
            modelBuilder.ApplyConfiguration(new RespostaAvaliacaoLogConfig());
            modelBuilder.ApplyConfiguration(new TurmaConfig());
            modelBuilder.ApplyConfiguration(new TurmaProfessorConfig());
            modelBuilder.ApplyConfiguration(new TurmaRespondenteConfig());
        }
    }
}