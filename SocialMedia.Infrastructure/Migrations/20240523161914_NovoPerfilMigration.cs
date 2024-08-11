using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMedia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NovoPerfilMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfis_Conta_IdConta",
                table: "Perfis");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacoes_Perfis_IdPerfil",
                table: "Publicacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfis",
                table: "Perfis");

            migrationBuilder.RenameTable(
                name: "Perfis",
                newName: "Perfil");

            migrationBuilder.RenameIndex(
                name: "IX_Perfis_IdConta",
                table: "Perfil",
                newName: "IX_Perfil_IdConta");

            migrationBuilder.AlterColumn<string>(
                name: "Sobre",
                table: "Perfil",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Profissao",
                table: "Perfil",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NomeExibicao",
                table: "Perfil",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Localidade",
                table: "Perfil",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Perfil",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Conta_IdConta",
                table: "Perfil",
                column: "IdConta",
                principalTable: "Conta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacoes_Perfil_IdPerfil",
                table: "Publicacoes",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Conta_IdConta",
                table: "Perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacoes_Perfil_IdPerfil",
                table: "Publicacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil");

            migrationBuilder.RenameTable(
                name: "Perfil",
                newName: "Perfis");

            migrationBuilder.RenameIndex(
                name: "IX_Perfil_IdConta",
                table: "Perfis",
                newName: "IX_Perfis_IdConta");

            migrationBuilder.AlterColumn<string>(
                name: "Sobre",
                table: "Perfis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Profissao",
                table: "Perfis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "NomeExibicao",
                table: "Perfis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Localidade",
                table: "Perfis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Perfis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfis",
                table: "Perfis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfis_Conta_IdConta",
                table: "Perfis",
                column: "IdConta",
                principalTable: "Conta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacoes_Perfis_IdPerfil",
                table: "Publicacoes",
                column: "IdPerfil",
                principalTable: "Perfis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
