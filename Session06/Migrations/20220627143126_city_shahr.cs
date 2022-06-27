using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session06.Migrations
{
    public partial class city_shahr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provinces_ProvinceId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.EnsureSchema(
                name: "xyz");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "Shahr",
                newSchema: "xyz");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "xyz",
                table: "Shahr",
                newName: "myName");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_ProvinceId",
                schema: "xyz",
                table: "Shahr",
                newName: "IX_Shahr_ProvinceId");

            migrationBuilder.AlterColumn<string>(
                name: "myName",
                schema: "xyz",
                table: "Shahr",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shahr",
                schema: "xyz",
                table: "Shahr",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shahr_Provinces_ProvinceId",
                schema: "xyz",
                table: "Shahr",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shahr_Provinces_ProvinceId",
                schema: "xyz",
                table: "Shahr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shahr",
                schema: "xyz",
                table: "Shahr");

            migrationBuilder.RenameTable(
                name: "Shahr",
                schema: "xyz",
                newName: "Cities");

            migrationBuilder.RenameColumn(
                name: "myName",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Shahr_ProvinceId",
                table: "Cities",
                newName: "IX_Cities_ProvinceId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provinces_ProvinceId",
                table: "Cities",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
