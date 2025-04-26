using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cental.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ilsikikaldir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettingsAdresses_SiteSettings_SiteSettingsId",
                table: "SiteSettingsAdresses");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettingsQuickLinks_SiteSettings_SiteSettingsId",
                table: "SiteSettingsQuickLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettingsSocialMedias_SiteSettings_SiteSettingsId",
                table: "SiteSettingsSocialMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettingsTopMenus_SiteSettings_SiteSettingsId",
                table: "SiteSettingsTopMenus");

            migrationBuilder.DropIndex(
                name: "IX_SiteSettingsTopMenus_SiteSettingsId",
                table: "SiteSettingsTopMenus");

            migrationBuilder.DropIndex(
                name: "IX_SiteSettingsSocialMedias_SiteSettingsId",
                table: "SiteSettingsSocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SiteSettingsQuickLinks_SiteSettingsId",
                table: "SiteSettingsQuickLinks");

            migrationBuilder.DropIndex(
                name: "IX_SiteSettingsAdresses_SiteSettingsId",
                table: "SiteSettingsAdresses");

            migrationBuilder.DropColumn(
                name: "SiteSettingsId",
                table: "SiteSettingsTopMenus");

            migrationBuilder.DropColumn(
                name: "SiteSettingsId",
                table: "SiteSettingsSocialMedias");

            migrationBuilder.DropColumn(
                name: "SiteSettingsId",
                table: "SiteSettingsQuickLinks");

            migrationBuilder.DropColumn(
                name: "SiteSettingsId",
                table: "SiteSettingsAdresses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteSettingsId",
                table: "SiteSettingsTopMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteSettingsId",
                table: "SiteSettingsSocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteSettingsId",
                table: "SiteSettingsQuickLinks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteSettingsId",
                table: "SiteSettingsAdresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsTopMenus_SiteSettingsId",
                table: "SiteSettingsTopMenus",
                column: "SiteSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsSocialMedias_SiteSettingsId",
                table: "SiteSettingsSocialMedias",
                column: "SiteSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsQuickLinks_SiteSettingsId",
                table: "SiteSettingsQuickLinks",
                column: "SiteSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsAdresses_SiteSettingsId",
                table: "SiteSettingsAdresses",
                column: "SiteSettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettingsAdresses_SiteSettings_SiteSettingsId",
                table: "SiteSettingsAdresses",
                column: "SiteSettingsId",
                principalTable: "SiteSettings",
                principalColumn: "SiteSettingsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettingsQuickLinks_SiteSettings_SiteSettingsId",
                table: "SiteSettingsQuickLinks",
                column: "SiteSettingsId",
                principalTable: "SiteSettings",
                principalColumn: "SiteSettingsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettingsSocialMedias_SiteSettings_SiteSettingsId",
                table: "SiteSettingsSocialMedias",
                column: "SiteSettingsId",
                principalTable: "SiteSettings",
                principalColumn: "SiteSettingsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettingsTopMenus_SiteSettings_SiteSettingsId",
                table: "SiteSettingsTopMenus",
                column: "SiteSettingsId",
                principalTable: "SiteSettings",
                principalColumn: "SiteSettingsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
