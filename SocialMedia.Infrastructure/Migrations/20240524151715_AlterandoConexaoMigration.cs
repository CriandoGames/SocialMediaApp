using Microsoft.EntityFrameworkCore.Migrations;
using SocialMedia.Core.Entities;

#nullable disable

namespace SocialMedia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoConexaoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdSeguidor",
                table: "Conexao",
                newName: "IdPerfil"); 

            migrationBuilder.RenameColumn(
                name: "IdSeguido",
                table: "Conexao",
                newName: "IdPerfilSeguido");

            migrationBuilder.CreateIndex(
                name: "IX_Conexao_IdPerfil",
                table: "Conexao",
                column: "IdPerfil");

            migrationBuilder.AddForeignKey(
                name: "FK_Conexao_Perfil_IdPerfil",
                table: "Conexao",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Conexao_Perfil_IdPerfil",
                table: "Conexao");

            migrationBuilder.DropIndex(
                name: "IX_Conexao_IdPerfil",
                table: "Conexao");

            migrationBuilder.RenameColumn(
                name: "IdPerfilSeguido",
                table: "Conexao",
                newName: "IdSeguidor");

            migrationBuilder.RenameColumn(
                name: "IdPerfil",
                table: "Conexao",
                newName: "IdSeguido");
        }
    }
}
