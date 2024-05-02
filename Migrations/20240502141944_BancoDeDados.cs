using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeValidades.Migrations
{
    /// <inheritdoc />
    public partial class BancoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    PRONID_PRO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRODDATVAL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROCREF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROCDESCR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRONQUANT = table.Column<int>(type: "int", nullable: false),
                    PROCFOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROCSTAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRODDATCAD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRODDATALT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PROCUSRCAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROCUSRALT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.PRONID_PRO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");
        }
    }
}
