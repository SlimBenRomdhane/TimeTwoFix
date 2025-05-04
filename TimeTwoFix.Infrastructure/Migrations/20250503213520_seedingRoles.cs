using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeTwoFix.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedingRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "Mechanic role with access to work orders and interventions.", true, "Mechanic", "MECHANIC" },
                    { 2, "Front Desk Assistant role with access to client management and appointments.", true, "FrontDeskAssistant", "FRONTDESKASSISTANT" },
                    { 3, "Warehouse Manager role with access to spare parts and inventory management.", true, "WareHouseManager", "WAREHOUSEMANAGER" },
                    { 4, "Workshop Manager role with access to workshop operations and team management.", true, "WorkshopManager", "WORKSHOPMANAGER" },
                    { 5, "General Manager role with access to all operations and management.", false, "GeneralManager", "GENERALMANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
