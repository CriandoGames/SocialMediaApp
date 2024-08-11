using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMedia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NovaPublicacaoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publicacoes_Perfil_IdPerfil",
                table: "Publicacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publicacoes",
                table: "Publicacoes");

            migrationBuilder.RenameTable(
                name: "Publicacoes",
                newName: "Publicacao");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacoes_IdPerfil",
                table: "Publicacao",
                newName: "IX_Publicacao_IdPerfil");

            migrationBuilder.AlterColumn<string>(
                name: "Localidade",
                table: "Publicacao",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPublicacao",
                table: "Publicacao",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Conteudo",
                table: "Publicacao",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publicacao",
                table: "Publicacao",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacao_Perfil_IdPerfil",
                table: "Publicacao",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publicacao_Perfil_IdPerfil",
                table: "Publicacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publicacao",
                table: "Publicacao");

            migrationBuilder.RenameTable(
                name: "Publicacao",
                newName: "Publicacoes");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacao_IdPerfil",
                table: "Publicacoes",
                newName: "IX_Publicacoes_IdPerfil");

            migrationBuilder.AlterColumn<string>(
                name: "Localidade",
                table: "Publicacoes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPublicacao",
                table: "Publicacoes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "Conteudo",
                table: "Publicacoes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publicacoes",
                table: "Publicacoes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacoes_Perfil_IdPerfil",
                table: "Publicacoes",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
