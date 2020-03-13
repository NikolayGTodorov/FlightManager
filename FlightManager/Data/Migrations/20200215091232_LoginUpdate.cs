using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightManager.Data.Migrations
{
    public partial class LoginUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    PlaneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationFrom = table.Column<string>(nullable: true),
                    LocationTo = table.Column<string>(nullable: true),
                    DepartTime = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    PlaneType = table.Column<string>(nullable: true),
                    PilotName = table.Column<string>(nullable: true),
                    PlaneCapacityNormal = table.Column<int>(nullable: false),
                    PlaneCapacityBusiness = table.Column<int>(nullable: false),
                    AlreadyReserved = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    IdentifiactionalNumber = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
