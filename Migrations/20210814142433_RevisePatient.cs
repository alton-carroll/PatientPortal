using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientPortal.Migrations
{
    public partial class RevisePatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Patient",
                newName: "Prefix");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "Patient",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Patient",
                newName: "ActivePatient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prefix",
                table: "Patient",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Patient",
                newName: "Dob");

            migrationBuilder.RenameColumn(
                name: "ActivePatient",
                table: "Patient",
                newName: "Active");
        }
    }
}
