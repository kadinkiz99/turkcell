using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace turkcell.Migrations
{
    public partial class AddPublishDateforProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Products",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Products");
        }
    }
}
