using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamSK.Migrations
{
    public partial class next1 : Migration
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
                    DataRegistered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.LicencePlate);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Uname = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    HasDriverLicence = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Uname);
                });

            migrationBuilder.CreateTable(
                name: "Renteds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfRent = table.Column<DateTime>(nullable: false),
                    DateofReturn = table.Column<DateTime>(nullable: false),
                    KilometersOnRent = table.Column<int>(nullable: false),
                    KilometersOnReturn = table.Column<int>(nullable: false),
                    UserUname = table.Column<string>(nullable: true),
                    carLicencePlate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Renteds_Users_UserUname",
                        column: x => x.UserUname,
                        principalTable: "Users",
                        principalColumn: "Uname",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Renteds_Cars_carLicencePlate",
                        column: x => x.carLicencePlate,
                        principalTable: "Cars",
                        principalColumn: "LicencePlate",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Renteds_UserUname",
                table: "Renteds",
                column: "UserUname");

            migrationBuilder.CreateIndex(
                name: "IX_Renteds_carLicencePlate",
                table: "Renteds",
                column: "carLicencePlate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Renteds");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
