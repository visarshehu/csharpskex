using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamSK.Migrations
{
    public partial class chagedid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rented",
                table: "Rented");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Rented");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "Rented",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rented",
                table: "Rented",
                column: "CarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rented",
                table: "Rented");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "Rented",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Rented",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rented",
                table: "Rented",
                column: "UserID");
        }
    }
}
