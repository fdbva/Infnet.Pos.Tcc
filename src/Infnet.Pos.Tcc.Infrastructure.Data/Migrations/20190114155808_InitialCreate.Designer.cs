﻿// <auto-generated />
using System;
using Infnet.Pos.Tcc.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AvaliacaoContext))]
    [Migration("20190114155808_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Avaliacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Abertura");

                    b.Property<string>("Codigo");

                    b.Property<DateTime>("Fechamento");

                    b.HasKey("Id");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.AvaliacaoQuestao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AvaliacaoId");

                    b.Property<string>("GrupoQuestao");

                    b.Property<string>("Questao");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoId");

                    b.ToTable("AvaliacaoQuestoes");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.AvaliacaoRespondente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AvaliacaoId");

                    b.Property<DateTime>("Enviado");

                    b.Property<Guid>("RespondenteId");

                    b.Property<DateTime>("Respondido");

                    b.Property<int>("StatusEmail");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoId");

                    b.HasIndex("RespondenteId");

                    b.ToTable("AvaliacaoRespondentes");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Bloco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CursoId");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Blocos");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.GrupoQuestao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("GrupoQuestoes");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Modulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlocoId");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.HasIndex("BlocoId");

                    b.ToTable("Modulos");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Professor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cpf");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Questao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativa");

                    b.Property<string>("Codigo");

                    b.Property<string>("Descricao");

                    b.Property<Guid>("GrupoQuestaoId");

                    b.HasKey("Id");

                    b.HasIndex("GrupoQuestaoId");

                    b.ToTable("Questoes");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Respondente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("Nascimento");

                    b.HasKey("Id");

                    b.ToTable("Respondentes");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.RespostaAvaliacaoLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlunoCpf");

                    b.Property<string>("AlunoNome");

                    b.Property<string>("AvaliacaoCodigo");

                    b.Property<string>("BlocoDescricao");

                    b.Property<string>("CursoDescricao");

                    b.Property<string>("ModuloDescricao");

                    b.Property<string>("ProfessorCpf");

                    b.Property<string>("ProfessorNome");

                    b.Property<string>("Questao");

                    b.Property<int>("Resposta");

                    b.Property<string>("TurmaDescricao");

                    b.Property<DateTime>("TurmaInicio");

                    b.Property<DateTime>("TurmaTermino");

                    b.HasKey("Id");

                    b.ToTable("RespostasAvaliacoesLog");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Turma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("Inicio");

                    b.Property<Guid>("ModuloId");

                    b.Property<DateTime>("Termino");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.TurmaProfessor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ProfessorId");

                    b.Property<Guid>("TurmaId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.HasIndex("TurmaId");

                    b.ToTable("TurmasProfessores");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.TurmaRespondente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("RespondenteId");

                    b.Property<Guid>("TurmaId");

                    b.HasKey("Id");

                    b.HasIndex("RespondenteId");

                    b.HasIndex("TurmaId");

                    b.ToTable("TurmasRespondentes");
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.AvaliacaoQuestao", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Avaliacao", "Avaliacao")
                        .WithMany("AvaliacaoQuestoes")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.AvaliacaoRespondente", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Avaliacao", "Avaliacao")
                        .WithMany("AvaliacaoRespondentes")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Respondente", "Respondente")
                        .WithMany("AvaliacoesRespondente")
                        .HasForeignKey("RespondenteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Bloco", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Curso", "Curso")
                        .WithMany("Blocos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Modulo", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Bloco", "Bloco")
                        .WithMany("Modulos")
                        .HasForeignKey("BlocoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Questao", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.GrupoQuestao", "GrupoQuestao")
                        .WithMany("Questoes")
                        .HasForeignKey("GrupoQuestaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.Turma", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Modulo", "Modulo")
                        .WithMany("Turmas")
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.TurmaProfessor", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Professor", "Professor")
                        .WithMany("TurmasProfessor")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Turma", "Turma")
                        .WithMany("TurmaProfessores")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infnet.Pos.Tcc.Domain.Model.Entities.TurmaRespondente", b =>
                {
                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Respondente", "Respondente")
                        .WithMany("TurmasRespondente")
                        .HasForeignKey("RespondenteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infnet.Pos.Tcc.Domain.Model.Entities.Turma", "Turma")
                        .WithMany("TurmaRespondentes")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
