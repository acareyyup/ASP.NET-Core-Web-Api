using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c9e91e5-dd0f-4bd1-a715-17168ac76e1f", null, "Editor", "EDITOR" },
                    { "780eb65d-1e08-4a93-94e6-c4db861c9eb9", null, "User", "USER" },
                    { "9525d210-dedf-4171-9acd-ae6bbbdb98bb", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c9e91e5-dd0f-4bd1-a715-17168ac76e1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "780eb65d-1e08-4a93-94e6-c4db861c9eb9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9525d210-dedf-4171-9acd-ae6bbbdb98bb");
        }
    }
}
