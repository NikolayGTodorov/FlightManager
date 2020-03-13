using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightManager.Data.Migrations
{
    public partial class ReservationsValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentifiactionalNumber",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Reservations",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationalNumber",
                table: "Reservations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentificationalNumber",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdentifiactionalNumber",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
