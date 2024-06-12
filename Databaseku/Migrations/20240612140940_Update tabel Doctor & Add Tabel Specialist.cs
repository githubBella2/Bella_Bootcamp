using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Databaseku.Migrations
{
    /// <inheritdoc />
    public partial class UpdatetabelDoctorAddTabelSpecialist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialist",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "SpecialistID",
                table: "Doctors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    SpecialistID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.SpecialistID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecialistID",
                table: "Doctors",
                column: "SpecialistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specialists_SpecialistID",
                table: "Doctors",
                column: "SpecialistID",
                principalTable: "Specialists",
                principalColumn: "SpecialistID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specialists_SpecialistID",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_SpecialistID",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "SpecialistID",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "Specialist",
                table: "Doctors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
