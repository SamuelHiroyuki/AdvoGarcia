using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace AdvoGarcia.Migrations
{
    public partial class tbAdvCasoCli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advogado",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Endedreco = table.Column<string>(nullable: true),
                    Especializacao = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true),
                    LastLog = table.Column<DateTime>(nullable: false),
                    Nascimento = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    PrecoPorHR = table.Column<int>(nullable: false),
                    QtdCasos = table.Column<int>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advogado", x => x.ID);
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
                    Foto = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });
            migrationBuilder.CreateTable(
                name: "Caso",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvogadoID = table.Column<int>(nullable: false),
                    ClienteID = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caso", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Caso_Advogado_AdvogadoID",
                        column: x => x.AdvogadoID,
                        principalTable: "Advogado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Caso_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Caso");
            migrationBuilder.DropTable("Advogado");
            migrationBuilder.DropTable("Cliente");
        }
    }
}
