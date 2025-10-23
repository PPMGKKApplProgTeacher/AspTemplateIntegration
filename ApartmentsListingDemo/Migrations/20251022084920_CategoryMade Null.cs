using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentsListingDemo.Migrations
{
    /// <inheritdoc />
    public partial class CategoryMadeNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_Category_Categoryid",
                table: "Listing");

            migrationBuilder.AlterColumn<int>(
                name: "Categoryid",
                table: "Listing",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_Category_Categoryid",
                table: "Listing",
                column: "Categoryid",
                principalTable: "Category",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_Category_Categoryid",
                table: "Listing");

            migrationBuilder.AlterColumn<int>(
                name: "Categoryid",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_Category_Categoryid",
                table: "Listing",
                column: "Categoryid",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
