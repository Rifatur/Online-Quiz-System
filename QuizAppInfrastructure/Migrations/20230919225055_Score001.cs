using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppDataAccess.Migrations
{
    public partial class Score001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "QuizOptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "QuizOptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "QuizOptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "QuizOptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "QuizOptions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "QuizOptions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "QuizOptions");

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "QuizOptions");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "QuizOptions");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "QuizOptions");
        }
    }
}
