using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeSystemSystem.Migrations
{
    public partial class ChangeGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wage",
                table: "Grade");

            migrationBuilder.AddColumn<double>(
                name: "GradeNumber",
                table: "Grade",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeNumber",
                table: "Grade");

            migrationBuilder.AddColumn<double>(
                name: "Wage",
                table: "Grade",
                type: "float",
                nullable: true);
        }
    }
}
