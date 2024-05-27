using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShop.Discount.Migrations
{
    /// <inheritdoc />
    public partial class fix5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "validData",
                table: "Coupons",
                newName: "validDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "validDate",
                table: "Coupons",
                newName: "validData");
        }
    }
}
