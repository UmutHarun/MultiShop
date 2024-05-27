using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShop.Discount.Migrations
{
    /// <inheritdoc />
    public partial class fix6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "validDate",
                table: "Coupons",
                newName: "ValidDate");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Coupons",
                newName: "IsActive");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValidDate",
                table: "Coupons",
                newName: "validDate");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Coupons",
                newName: "isActive");
        }
    }
}
