using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmsEvaluationV2.Data.Migrations
{
    public partial class removeRoleFromModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AppUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
