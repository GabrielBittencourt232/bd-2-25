using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imobiliaria.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    ImovelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.ImovelID);
                });

            migrationBuilder.CreateTable(
                name: "Residente",
                columns: table => new
                {
                    ResidenteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residente", x => x.ResidenteID);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    ResidenteID = table.Column<int>(type: "int", nullable: false),
                    ImovelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.ResidenteID, x.ImovelID });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Imovel_ImovelID",
                        column: x => x.ImovelID,
                        principalTable: "Imovel",
                        principalColumn: "ImovelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Residente_ResidenteID",
                        column: x => x.ResidenteID,
                        principalTable: "Residente",
                        principalColumn: "ResidenteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_ImovelID",
                table: "StudentCourses",
                column: "ImovelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "Residente");
        }
    }
}
