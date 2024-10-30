using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_api_test.Migrations
{
    /// <inheritdoc />
    public partial class UserApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vf_location",
                table: "viajefoto");

            migrationBuilder.RenameColumn(
                name: "fv_fechaini",
                table: "viajefoto",
                newName: "vf_fechaini");

            migrationBuilder.AlterColumn<byte>(
                name: "to_id",
                table: "viajefoto",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "accessUserApplications",
                columns: table => new
                {
                    aua_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ua_id = table.Column<int>(type: "int", nullable: false),
                    ap_id = table.Column<int>(type: "int", nullable: false),
                    ac_fechafin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    aua_perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accessUserApplications", x => x.aua_id);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    co_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    co_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    co_apellido = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.co_id);
                });

            migrationBuilder.CreateTable(
                name: "installers",
                columns: table => new
                {
                    in_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    co_id = table.Column<int>(type: "int", nullable: false),
                    in_fechafin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_installers", x => x.in_id);
                });

            migrationBuilder.CreateTable(
                name: "userApplications",
                columns: table => new
                {
                    ua_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    co_id = table.Column<int>(type: "int", nullable: false),
                    ua_usr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ua_con = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ua_fechafin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userApplications", x => x.ua_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accessUserApplications");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "installers");

            migrationBuilder.DropTable(
                name: "userApplications");

            migrationBuilder.RenameColumn(
                name: "vf_fechaini",
                table: "viajefoto",
                newName: "fv_fechaini");

            migrationBuilder.AlterColumn<int>(
                name: "to_id",
                table: "viajefoto",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<string>(
                name: "vf_location",
                table: "viajefoto",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
