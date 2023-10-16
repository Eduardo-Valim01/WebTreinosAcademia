using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTreinosAcademia.Migrations
{
    /// <inheritdoc />
    public partial class inicial_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treinos_Professores_professorRespid",
                table: "Treinos");

            migrationBuilder.RenameColumn(
                name: "professorRespid",
                table: "Treinos",
                newName: "professorResp");

            migrationBuilder.RenameIndex(
                name: "IX_Treinos_professorRespid",
                table: "Treinos",
                newName: "IX_Treinos_professorResp");

            migrationBuilder.AddForeignKey(
                name: "FK_Treinos_Professores_professorResp",
                table: "Treinos",
                column: "professorResp",
                principalTable: "Professores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treinos_Professores_professorResp",
                table: "Treinos");

            migrationBuilder.RenameColumn(
                name: "professorResp",
                table: "Treinos",
                newName: "professorRespid");

            migrationBuilder.RenameIndex(
                name: "IX_Treinos_professorResp",
                table: "Treinos",
                newName: "IX_Treinos_professorRespid");

            migrationBuilder.AddForeignKey(
                name: "FK_Treinos_Professores_professorRespid",
                table: "Treinos",
                column: "professorRespid",
                principalTable: "Professores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
