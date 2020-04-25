using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assign_4_MVC_Active_Cloud_Site.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name_brand = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    industry_name = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    industry_code = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
