using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Sales");
        }
    }
}
