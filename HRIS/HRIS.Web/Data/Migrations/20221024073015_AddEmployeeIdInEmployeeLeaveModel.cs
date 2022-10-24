using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Web.Data.Migrations
{
    public partial class AddEmployeeIdInEmployeeLeaveModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "EmployeeLeaves",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeLeaves");
        }
    }
}
