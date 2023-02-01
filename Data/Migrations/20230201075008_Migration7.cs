using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Minerals_Users_OwnerUserId",
                table: "Minerals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Minerals",
                table: "Minerals");

            migrationBuilder.DropIndex(
                name: "IX_Minerals_OwnerUserId",
                table: "Minerals");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Minerals");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Minerals");

            migrationBuilder.RenameTable(
                name: "Minerals",
                newName: "Mineral");

            migrationBuilder.RenameColumn(
                name: "OwnerUserId",
                table: "Mineral",
                newName: "MineralSize");

            migrationBuilder.AddColumn<string>(
                name: "MagicProperties",
                table: "Mineral",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MineralType",
                table: "Mineral",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mineral",
                table: "Mineral",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdWeb = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberItems = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mineral",
                table: "Mineral");

            migrationBuilder.DropColumn(
                name: "MagicProperties",
                table: "Mineral");

            migrationBuilder.DropColumn(
                name: "MineralType",
                table: "Mineral");

            migrationBuilder.RenameTable(
                name: "Mineral",
                newName: "Minerals");

            migrationBuilder.RenameColumn(
                name: "MineralSize",
                table: "Minerals",
                newName: "OwnerUserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Minerals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Minerals",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Minerals",
                table: "Minerals",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExampleGitSasasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdWeb = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Minerals_OwnerUserId",
                table: "Minerals",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Minerals_Users_OwnerUserId",
                table: "Minerals",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
