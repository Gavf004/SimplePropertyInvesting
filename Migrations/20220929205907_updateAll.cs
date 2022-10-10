using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplePropertyInvesting.Migrations
{
    public partial class updateAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tenants_units_UnitId",
                table: "tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_units_properties_Property_Id",
                table: "units");

            migrationBuilder.DropIndex(
                name: "IX_units_Property_Id",
                table: "units");

            migrationBuilder.AlterColumn<int>(
                name: "Property_Id",
                table: "units",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Property_Id1",
                table: "units",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "tenants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_units_Property_Id1",
                table: "units",
                column: "Property_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_tenants_units_UnitId",
                table: "tenants",
                column: "UnitId",
                principalTable: "units",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_units_properties_Property_Id1",
                table: "units",
                column: "Property_Id1",
                principalTable: "properties",
                principalColumn: "Property_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tenants_units_UnitId",
                table: "tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_units_properties_Property_Id1",
                table: "units");

            migrationBuilder.DropIndex(
                name: "IX_units_Property_Id1",
                table: "units");

            migrationBuilder.DropColumn(
                name: "Property_Id1",
                table: "units");

            migrationBuilder.AlterColumn<int>(
                name: "Property_Id",
                table: "units",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "tenants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_units_Property_Id",
                table: "units",
                column: "Property_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tenants_units_UnitId",
                table: "tenants",
                column: "UnitId",
                principalTable: "units",
                principalColumn: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_units_properties_Property_Id",
                table: "units",
                column: "Property_Id",
                principalTable: "properties",
                principalColumn: "Property_Id");
        }
    }
}
