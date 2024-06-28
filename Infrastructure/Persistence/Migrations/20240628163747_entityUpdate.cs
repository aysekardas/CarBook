using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class entityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "FooterAdresses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "FooterAdressID",
                table: "FooterAdresses",
                newName: "FooterAddressID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "FooterAdresses",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "FooterAddressID",
                table: "FooterAdresses",
                newName: "FooterAdressID");
        }
    }
}
