using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplePropertyInvesting.Migrations
{
    public partial class UpdateTenantMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenant_units_UnitId",
                table: "Tenant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenant",
                table: "Tenant");

            migrationBuilder.RenameTable(
                name: "Tenant",
                newName: "tenants");

            migrationBuilder.RenameIndex(
                name: "IX_Tenant_UnitId",
                table: "tenants",
                newName: "IX_tenants_UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tenants",
                table: "tenants",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_tenants_units_UnitId",
                table: "tenants",
                column: "UnitId",
                principalTable: "units",
                principalColumn: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tenants_units_UnitId",
                table: "tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tenants",
                table: "tenants");

            migrationBuilder.RenameTable(
                name: "tenants",
                newName: "Tenant");

            migrationBuilder.RenameIndex(
                name: "IX_tenants_UnitId",
                table: "Tenant",
                newName: "IX_Tenant_UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenant",
                table: "Tenant",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenant_units_UnitId",
                table: "Tenant",
                column: "UnitId",
                principalTable: "units",
                principalColumn: "UnitId");
        }
    }
}
