using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservationApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class DestinationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DetailUp",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DetailsDown",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DetailUp",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DetailsDown",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "SecondImage",
                table: "Destinations");
        }
    }
}
