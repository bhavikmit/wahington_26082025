using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddDispatchAndSafetyFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedCrew",
                table: "StreetServiceRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedTechnicians",
                table: "StreetServiceRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DispatchStatusId",
                table: "StreetServiceRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EvacuationNeeded",
                table: "StreetServiceRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GasOdorDetected",
                table: "StreetServiceRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RegulatoryStepCode",
                table: "StreetServiceRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RespondersNotified",
                table: "StreetServiceRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisorName",
                table: "StreetServiceRequests",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedCrew",
                table: "StreetServiceRequests");

            migrationBuilder.DropColumn(
                name: "AssignedTechnicians",
                table: "StreetServiceRequests");

            migrationBuilder.DropColumn(
                name: "DispatchStatusId",
                table: "StreetServiceRequests");

            migrationBuilder.DropColumn(
                name: "EvacuationNeeded",
                table: "StreetServiceRequests");

            migrationBuilder.DropColumn(
                name: "GasOdorDetected",
                table: "StreetServiceRequests");

            migrationBuilder.DropColumn(
                name: "RegulatoryStepCode",
                table: "StreetServiceRequests");

            migrationBuilder.DropColumn(
                name: "RespondersNotified",
                table: "StreetServiceRequests");

            migrationBuilder.DropColumn(
                name: "SupervisorName",
                table: "StreetServiceRequests");
        }
    }
}
