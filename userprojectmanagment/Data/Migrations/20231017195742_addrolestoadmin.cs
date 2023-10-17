using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace userprojectmanagment.Data.Migrations
{
    public partial class addrolestoadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [AspNetUserRoles](UserId,RoleId) SELECT '10b0ddaa-bb1c-461c-a6b3-94454d3d9ead', Id FROM [AspNetRoles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetUserRoles] WHERE UserId='10b0ddaa-bb1c-461c-a6b3-94454d3d9ead' ");
        }
    }
}
