using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace AdvoGarcia.Migrations
{
    public partial class AttTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Caso_Cliente_ClienteID", table: "Caso");
            migrationBuilder.AlterColumn<int>(
                name: "AdvogadoID",
                table: "Caso",
                nullable: true);
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
            migrationBuilder.DropForeignKey(name: "FK_Caso_Cliente_ClienteID", table: "Caso");
            migrationBuilder.AlterColumn<int>(
                name: "AdvogadoID",
                table: "Caso",
                nullable: false);
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
