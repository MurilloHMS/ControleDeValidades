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
                    PRODDATCAD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROCCODINT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROCDESCR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROCREF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROCFOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRONQUANT = table.Column<int>(type: "int", nullable: false),
                    PRODDATVAL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROCSTAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROCNNUMNF = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
