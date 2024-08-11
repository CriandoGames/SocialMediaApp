using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMedia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoConexaoNovamenteMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Conexao_IdPerfilSeguido",
                table: "Conexao",
                column: "IdPerfilSeguido");

            migrationBuilder.AddForeignKey(
                name: "FK_Conexao_Perfil_IdPerfilSeguido",
                table: "Conexao",
                column: "IdPerfilSeguido",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conexao_Perfil_IdPerfilSeguido",
                table: "Conexao");

            migrationBuilder.DropIndex(
                name: "IX_Conexao_IdPerfilSeguido",
                table: "Conexao");
        }
    }
}
