using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolIntraAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "School_Intra_ContactPersons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Firstnames = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Intra_ContactPersons", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "School_Intra_SchoolClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Intra_SchoolClasses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "School_Intra_Pupils",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Firstnames = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ClassId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Intra_Pupils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_School_Intra_Pupils_School_Intra_SchoolClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "School_Intra_SchoolClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "School_Intra_PupilContacts",
                columns: table => new
                {
                    ContactPersonsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PupilsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Intra_PupilContacts", x => new { x.ContactPersonsId, x.PupilsId });
                    table.ForeignKey(
                        name: "FK_School_Intra_PupilContacts_School_Intra_ContactPersons_Conta~",
                        column: x => x.ContactPersonsId,
                        principalTable: "School_Intra_ContactPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_School_Intra_PupilContacts_School_Intra_Pupils_PupilsId",
                        column: x => x.PupilsId,
                        principalTable: "School_Intra_Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_School_Intra_PupilContacts_PupilsId",
                table: "School_Intra_PupilContacts",
                column: "PupilsId");

            migrationBuilder.CreateIndex(
                name: "IX_School_Intra_Pupils_ClassId",
                table: "School_Intra_Pupils",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "School_Intra_PupilContacts");

            migrationBuilder.DropTable(
                name: "School_Intra_ContactPersons");

            migrationBuilder.DropTable(
                name: "School_Intra_Pupils");

            migrationBuilder.DropTable(
                name: "School_Intra_SchoolClasses");
        }
    }
}
