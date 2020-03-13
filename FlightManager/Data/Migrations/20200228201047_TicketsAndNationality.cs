using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightManager.Data.Migrations
{
    public partial class TicketsAndNationality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Reservations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TicketType",
                table: "Reservations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TicketType",
                table: "Reservations");
        }
    }
}
