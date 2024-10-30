using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_api_test.Migrations
{
    /// <inheritdoc />
    public partial class Viajefoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "viajefoto",
                columns: table => new
                {
                    vf_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vi_id = table.Column<int>(type: "int", nullable: false),
                    vf_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to_id = table.Column<int>(type: "int", nullable: false),
                    fv_fechaini = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ua_idcrea = table.Column<int>(type: "int", nullable: false),
                    vf_location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viajefoto", x => x.vf_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "viajefoto");
        }
    }
}
