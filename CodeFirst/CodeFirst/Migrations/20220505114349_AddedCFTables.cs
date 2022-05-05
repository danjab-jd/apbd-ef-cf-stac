using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class AddedCFTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    IdGroup = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Group_pk", x => x.IdGroup);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndexNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Student_pk", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "Student_Group",
                columns: table => new
                {
                    IdGroup = table.Column<int>(type: "int", nullable: false),
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 5, 13, 43, 49, 171, DateTimeKind.Local).AddTicks(2105))
                },
                constraints: table =>
                {
                    table.PrimaryKey("StudentGroup_pk", x => new { x.IdGroup, x.IdStudent });
                    table.ForeignKey(
                        name: "StudentGroup_Group",
                        column: x => x.IdGroup,
                        principalTable: "Group",
                        principalColumn: "IdGroup",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "StudentGroup_Student",
                        column: x => x.IdStudent,
                        principalTable: "Student",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Group_IdStudent",
                table: "Student_Group",
                column: "IdStudent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_Group");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
