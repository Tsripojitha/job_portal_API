using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recruiterlogin",
                table: "Recruiterlogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emplogin",
                table: "Emplogin");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Recruiterlogin");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Emplogin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recruiterlogin",
                table: "Recruiterlogin",
                column: "companyname");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emplogin",
                table: "Emplogin",
                column: "username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recruiterlogin",
                table: "Recruiterlogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emplogin",
                table: "Emplogin");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Recruiterlogin",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Emplogin",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recruiterlogin",
                table: "Recruiterlogin",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emplogin",
                table: "Emplogin",
                column: "Id");
        }
    }
}
