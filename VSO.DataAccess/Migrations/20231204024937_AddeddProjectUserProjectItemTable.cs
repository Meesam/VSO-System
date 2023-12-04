using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSO.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddeddProjectUserProjectItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Customers_CustomerId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectItem_Project_ProjectId",
                table: "ProjectItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectItem",
                table: "ProjectItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.RenameTable(
                name: "ProjectItem",
                newName: "ProjectItems");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectItem_ProjectId",
                table: "ProjectItems",
                newName: "IX_ProjectItems_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_CustomerId",
                table: "Projects",
                newName: "IX_Projects_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EmailAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ProjectItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectItems",
                table: "ProjectItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddresses_UserId",
                table: "EmailAddresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItems_UserId",
                table: "ProjectItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_Users_UserId",
                table: "EmailAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItems_Projects_ProjectId",
                table: "ProjectItems",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItems_Users_UserId",
                table: "ProjectItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_Users_UserId",
                table: "EmailAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectItems_Projects_ProjectId",
                table: "ProjectItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectItems_Users_UserId",
                table: "ProjectItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_EmailAddresses_UserId",
                table: "EmailAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectItems",
                table: "ProjectItems");

            migrationBuilder.DropIndex(
                name: "IX_ProjectItems_UserId",
                table: "ProjectItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EmailAddresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProjectItems");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "ProjectItems",
                newName: "ProjectItem");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CustomerId",
                table: "Project",
                newName: "IX_Project_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectItems_ProjectId",
                table: "ProjectItem",
                newName: "IX_ProjectItem_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectItem",
                table: "ProjectItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Customers_CustomerId",
                table: "Project",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItem_Project_ProjectId",
                table: "ProjectItem",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");
        }
    }
}
