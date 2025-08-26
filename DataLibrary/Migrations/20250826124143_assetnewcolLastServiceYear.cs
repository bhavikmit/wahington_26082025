using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    /// <inheritdoc />
    public partial class assetnewcolLastServiceYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastServiceDate",
                table: "Assets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastServiceYear",
                table: "Assets",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastServiceDate",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "LastServiceYear",
                table: "Assets");
        }
    }
}
