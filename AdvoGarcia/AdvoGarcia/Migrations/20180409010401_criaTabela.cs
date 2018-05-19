using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace AdvoGarcia.Migrations
{
    public partial class criaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caso",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TempoTotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caso", x => x.ID);
                });
            migrationBuilder.CreateTable(
                name: "Advogado",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Endedreco = table.Column<string>(nullable: true),
                    Especializacao = table.Column<string>(nullable: true),
                    IDCasoID = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    PrecoPorHR = table.Column<int>(nullable: false),
                    QtdCasos = table.Column<int>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advogado", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Advogado_Caso_IDCasoID",
                        column: x => x.IDCasoID,
                        principalTable: "Caso",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Endedreco = table.Column<string>(nullable: true),
                    FormaPagamento = table.Column<string>(nullable: true),
                    IDCasoID = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cliente_Caso_IDCasoID",
                        column: x => x.IDCasoID,
                        principalTable: "Caso",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Advogado");
            migrationBuilder.DropTable("Cliente");
            migrationBuilder.DropTable("Caso");
        }
    }
}
