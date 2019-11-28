using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamSK.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CyberTrucks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    EstimatedDelivery = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CyberTrucks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Uname = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Uname);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfOrder = table.Column<DateTime>(nullable: false),
                    Bid = table.Column<int>(nullable: false),
                    CyberTrucksId = table.Column<int>(nullable: true),
                    UsersUname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_CyberTrucks_CyberTrucksId",
                        column: x => x.CyberTrucksId,
                        principalTable: "CyberTrucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UsersUname",
                        column: x => x.UsersUname,
                        principalTable: "Users",
                        principalColumn: "Uname",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CyberTrucksId",
                table: "Orders",
                column: "CyberTrucksId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsersUname",
                table: "Orders",
                column: "UsersUname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "CyberTrucks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
