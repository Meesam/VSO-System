using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AlterAddressAndEmailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailType",
                table: "EmailAddresses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressType",
                table: "Address",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailType",
                table: "EmailAddresses");

            migrationBuilder.DropColumn(
                name: "AddressType",
                table: "Address");
        }
    }
}
