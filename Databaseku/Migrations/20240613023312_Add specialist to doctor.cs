using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Databaseku.Migrations
{
    /// <inheritdoc />
    public partial class Addspecialisttodoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecialistID",
                table: "Doctors",
                type: "INTEGER",
                nullable: true);

           
            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecialistID",
                table: "Doctors",
                column: "SpecialistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specialist_SpecialistID",
                table: "Doctors",
                column: "SpecialistID",
                principalTable: "Specialist",
                principalColumn: "SpecialistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specialist_SpecialistID",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "Specialist");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_SpecialistID",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "SpecialistID",
                table: "Doctors");
        }
    }
}
