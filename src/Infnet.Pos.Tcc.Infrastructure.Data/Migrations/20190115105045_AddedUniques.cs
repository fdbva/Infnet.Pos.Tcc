using Microsoft.EntityFrameworkCore.Migrations;

namespace Infnet.Pos.Tcc.Infrastructure.Data.Migrations
{
    public partial class AddedUniques : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Respondentes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Questoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "GrupoQuestoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Avaliacoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Respondentes_Cpf",
                table: "Respondentes",
                column: "Cpf",
                unique: true,
                filter: "[Cpf] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Questoes_Codigo",
                table: "Questoes",
                column: "Codigo",
                unique: true,
                filter: "[Codigo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_Cpf",
                table: "Professores",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GrupoQuestoes_Codigo",
                table: "GrupoQuestoes",
                column: "Codigo",
                unique: true,
                filter: "[Codigo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_Codigo",
                table: "Avaliacoes",
                column: "Codigo",
                unique: true,
                filter: "[Codigo] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Respondentes_Cpf",
                table: "Respondentes");

            migrationBuilder.DropIndex(
                name: "IX_Questoes_Codigo",
                table: "Questoes");

            migrationBuilder.DropIndex(
                name: "IX_Professores_Cpf",
                table: "Professores");

            migrationBuilder.DropIndex(
                name: "IX_GrupoQuestoes_Codigo",
                table: "GrupoQuestoes");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacoes_Codigo",
                table: "Avaliacoes");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Respondentes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Questoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "GrupoQuestoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Avaliacoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}