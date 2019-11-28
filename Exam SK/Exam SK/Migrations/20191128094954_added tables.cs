using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamSK.Migrations
{
    public partial class addedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    YearOfProduction = table.Column<DateTime>(nullable: false),
                    FuelType = table.Column<string>(nullable: true),
                    LicencePlate = table.Column<string>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.LicencePlate);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    UName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(type: "date", nullable: false),
                    HasDriverLicence = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UName);
                });

            migrationBuilder.CreateTable(
                name: "Rented",
                columns: table => new
                {
                    DateOfRent = table.Column<DateTime>(nullable: false),
                    DateOfReturn = table.Column<DateTime>(nullable: true),
                    KilometersOnRent = table.Column<int>(nullable: false),
                    KilometresOnReturn = table.Column<int>(nullable: true),
                    CarID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsersUName = table.Column<string>(nullable: true),
                    CarsLicencePlate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rented", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Rented_Cars_CarsLicencePlate",
                        column: x => x.CarsLicencePlate,
                        principalTable: "Cars",
                        principalColumn: "LicencePlate",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rented_Users_UsersUName",
                        column: x => x.UsersUName,
                        principalTable: "Users",
                        principalColumn: "UName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rented_CarsLicencePlate",
                table: "Rented",
                column: "CarsLicencePlate");

            migrationBuilder.CreateIndex(
                name: "IX_Rented_UsersUName",
                table: "Rented",
                column: "UsersUName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rented");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
