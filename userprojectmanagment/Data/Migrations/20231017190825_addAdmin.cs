using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace userprojectmanagment.Data.Migrations
{
    public partial class addAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Fname], [Lname]) VALUES (N'10b0ddaa-bb1c-461c-a6b3-94454d3d9ead', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEBgll+KK917LXwGfipgS47dFTrPzq98OIgBYDBUxrEL2h3ZNFZfK9S3oaaUwJvH3sg==', N'ZNKHJP4FZSCBIG72XNLPKEUGUUT5MSBL', N'448ed3ce-317b-4b61-830f-60883e08b499', NULL, 0, 0, NULL, 1, 0, N'Admin', N'Admin')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetUsers] WHERE Id='10b0ddaa-bb1c-461c-a6b3-94454d3d9ead' ");
        }
    }
}
