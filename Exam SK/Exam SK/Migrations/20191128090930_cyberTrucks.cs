using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamSK.Migrations
{
    public partial class cyberTrucks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cyberTrucks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    EstimatedDelivery = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cyberTrucks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    UName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 8, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UName);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateofOrder = table.Column<DateTime>(nullable: false),
                    Bid = table.Column<int>(nullable: false),
                    UserUName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    cyberTruckId = table.Column<int>(nullable: true),
                    CyberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_Users_UserUName",
                        column: x => x.UserUName,
                        principalTable: "Users",
                        principalColumn: "UName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_cyberTrucks_cyberTruckId",
                        column: x => x.cyberTruckId,
                        principalTable: "cyberTrucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserUName",
                table: "orders",
                column: "UserUName");

            migrationBuilder.CreateIndex(
                name: "IX_orders_cyberTruckId",
                table: "orders",
                column: "cyberTruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "cyberTrucks");
        }
    }
}
