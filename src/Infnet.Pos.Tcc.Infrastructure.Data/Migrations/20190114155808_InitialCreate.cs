using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    Abertura = table.Column<DateTime>(nullable: false),
                    Fechamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoQuestoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoQuestoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cpf = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Respondentes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respondentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RespostasAvaliacoesLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AvaliacaoCodigo = table.Column<string>(nullable: true),
                    Questao = table.Column<string>(nullable: true),
                    Resposta = table.Column<int>(nullable: false),
                    ProfessorCpf = table.Column<string>(nullable: true),
                    ProfessorNome = table.Column<string>(nullable: true),
                    AlunoCpf = table.Column<string>(nullable: true),
                    AlunoNome = table.Column<string>(nullable: true),
                    TurmaDescricao = table.Column<string>(nullable: true),
                    TurmaInicio = table.Column<DateTime>(nullable: false),
                    TurmaTermino = table.Column<DateTime>(nullable: false),
                    ModuloDescricao = table.Column<string>(nullable: true),
                    BlocoDescricao = table.Column<string>(nullable: true),
                    CursoDescricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespostasAvaliacoesLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacaoQuestoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Questao = table.Column<string>(nullable: true),
                    GrupoQuestao = table.Column<string>(nullable: true),
                    AvaliacaoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoQuestoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacaoQuestoes_Avaliacoes_AvaliacaoId",
                        column: x => x.AvaliacaoId,
                        principalTable: "Avaliacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blocos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    CursoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blocos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Ativa = table.Column<bool>(nullable: false),
                    GrupoQuestaoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questoes_GrupoQuestoes_GrupoQuestaoId",
                        column: x => x.GrupoQuestaoId,
                        principalTable: "GrupoQuestoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacaoRespondentes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AvaliacaoId = table.Column<Guid>(nullable: false),
                    RespondenteId = table.Column<Guid>(nullable: false),
                    Respondido = table.Column<DateTime>(nullable: false),
                    Enviado = table.Column<DateTime>(nullable: false),
                    StatusEmail = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoRespondentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacaoRespondentes_Avaliacoes_AvaliacaoId",
                        column: x => x.AvaliacaoId,
                        principalTable: "Avaliacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvaliacaoRespondentes_Respondentes_RespondenteId",
                        column: x => x.RespondenteId,
                        principalTable: "Respondentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    BlocoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modulos_Blocos_BlocoId",
                        column: x => x.BlocoId,
                        principalTable: "Blocos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Termino = table.Column<DateTime>(nullable: false),
                    ModuloId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turmas_Modulos_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurmasProfessores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TurmaId = table.Column<Guid>(nullable: false),
                    ProfessorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurmasProfessores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurmasProfessores_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmasProfessores_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurmasRespondentes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TurmaId = table.Column<Guid>(nullable: false),
                    RespondenteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurmasRespondentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurmasRespondentes_Respondentes_RespondenteId",
                        column: x => x.RespondenteId,
                        principalTable: "Respondentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurmasRespondentes_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoQuestoes_AvaliacaoId",
                table: "AvaliacaoQuestoes",
                column: "AvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoRespondentes_AvaliacaoId",
                table: "AvaliacaoRespondentes",
                column: "AvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoRespondentes_RespondenteId",
                table: "AvaliacaoRespondentes",
                column: "RespondenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Blocos_CursoId",
                table: "Blocos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_BlocoId",
                table: "Modulos",
                column: "BlocoId");

            migrationBuilder.CreateIndex(
                name: "IX_Questoes_GrupoQuestaoId",
                table: "Questoes",
                column: "GrupoQuestaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_ModuloId",
                table: "Turmas",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmasProfessores_ProfessorId",
                table: "TurmasProfessores",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmasProfessores_TurmaId",
                table: "TurmasProfessores",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmasRespondentes_RespondenteId",
                table: "TurmasRespondentes",
                column: "RespondenteId");

            migrationBuilder.CreateIndex(
                name: "IX_TurmasRespondentes_TurmaId",
                table: "TurmasRespondentes",
                column: "TurmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliacaoQuestoes");

            migrationBuilder.DropTable(
                name: "AvaliacaoRespondentes");

            migrationBuilder.DropTable(
                name: "Questoes");

            migrationBuilder.DropTable(
                name: "RespostasAvaliacoesLog");

            migrationBuilder.DropTable(
                name: "TurmasProfessores");

            migrationBuilder.DropTable(
                name: "TurmasRespondentes");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "GrupoQuestoes");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Respondentes");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Blocos");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
