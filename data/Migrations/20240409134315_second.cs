using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "department",
                table: "Emplogin",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Emplogin",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "experience",
                table: "Emplogin",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Emplogin",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "interests",
                table: "Emplogin",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phonenumber",
                table: "Emplogin",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "department",
                table: "Emplogin");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Emplogin");

            migrationBuilder.DropColumn(
                name: "experience",
                table: "Emplogin");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Emplogin");

            migrationBuilder.DropColumn(
                name: "interests",
                table: "Emplogin");

            migrationBuilder.DropColumn(
                name: "phonenumber",
                table: "Emplogin");
        }
    }
}
