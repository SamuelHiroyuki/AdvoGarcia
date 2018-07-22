using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace AdvoGarcia.Migrations
{
    public partial class AttTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Caso_Advogado_AdvogadoID", table: "Caso");
            migrationBuilder.DropForeignKey(name: "FK_Caso_Cliente_ClienteID", table: "Caso");
            migrationBuilder.DropColumn(name: "Endedreco", table: "Cliente");
            migrationBuilder.DropColumn(name: "Endedreco", table: "Advogado");
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Cliente",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Advogado",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Caso_Advogado_AdvogadoID",
                table: "Caso",
                column: "AdvogadoID",
                principalTable: "Advogado",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Caso_Cliente_ClienteID",
                table: "Caso",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Caso_Advogado_AdvogadoID", table: "Caso");
            migrationBuilder.DropForeignKey(name: "FK_Caso_Cliente_ClienteID", table: "Caso");
            migrationBuilder.DropColumn(name: "Endereco", table: "Cliente");
            migrationBuilder.DropColumn(name: "Endereco", table: "Advogado");
            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Cliente",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "CPF",
                table: "Cliente",
                nullable: false);
            migrationBuilder.AddColumn<string>(
                name: "Endedreco",
                table: "Cliente",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Endedreco",
                table: "Advogado",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Caso_Advogado_AdvogadoID",
                table: "Caso",
                column: "AdvogadoID",
                principalTable: "Advogado",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Caso_Cliente_ClienteID",
                table: "Caso",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
