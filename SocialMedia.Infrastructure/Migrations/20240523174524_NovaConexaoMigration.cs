using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMedia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NovaConexaoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Conexoes",
                table: "Conexoes");

            migrationBuilder.RenameTable(
                name: "Conexoes",
                newName: "Conexao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataConexao",
                table: "Conexao",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conexao",
                table: "Conexao",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Conexao",
                table: "Conexao");

            migrationBuilder.RenameTable(
                name: "Conexao",
                newName: "Conexoes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataConexao",
                table: "Conexoes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conexoes",
                table: "Conexoes",
                column: "Id");
        }
    }
}
