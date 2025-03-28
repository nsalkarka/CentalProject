using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cental.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class sitesettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    SiteSettingsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekendHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MidweekHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vacationours = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.SiteSettingsId);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettingsAdresses",
                columns: table => new
                {
                    SiteSettingsAdressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteSettingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettingsAdresses", x => x.SiteSettingsAdressId);
                    table.ForeignKey(
                        name: "FK_SiteSettingsAdresses_SiteSettings_SiteSettingsId",
                        column: x => x.SiteSettingsId,
                        principalTable: "SiteSettings",
                        principalColumn: "SiteSettingsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettingsQuickLinks",
                columns: table => new
                {
                    SiteSettingsQuickLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteSettingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettingsQuickLinks", x => x.SiteSettingsQuickLinkId);
                    table.ForeignKey(
                        name: "FK_SiteSettingsQuickLinks_SiteSettings_SiteSettingsId",
                        column: x => x.SiteSettingsId,
                        principalTable: "SiteSettings",
                        principalColumn: "SiteSettingsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettingsSocialMedias",
                columns: table => new
                {
                    SiteSettingsSocialMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteSettingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettingsSocialMedias", x => x.SiteSettingsSocialMediaId);
                    table.ForeignKey(
                        name: "FK_SiteSettingsSocialMedias_SiteSettings_SiteSettingsId",
                        column: x => x.SiteSettingsId,
                        principalTable: "SiteSettings",
                        principalColumn: "SiteSettingsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettingsTopMenus",
                columns: table => new
                {
                    SiteSettingsTopMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteSettingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettingsTopMenus", x => x.SiteSettingsTopMenuId);
                    table.ForeignKey(
                        name: "FK_SiteSettingsTopMenus_SiteSettings_SiteSettingsId",
                        column: x => x.SiteSettingsId,
                        principalTable: "SiteSettings",
                        principalColumn: "SiteSettingsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsAdresses_SiteSettingsId",
                table: "SiteSettingsAdresses",
                column: "SiteSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsQuickLinks_SiteSettingsId",
                table: "SiteSettingsQuickLinks",
                column: "SiteSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsSocialMedias_SiteSettingsId",
                table: "SiteSettingsSocialMedias",
                column: "SiteSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsTopMenus_SiteSettingsId",
                table: "SiteSettingsTopMenus",
                column: "SiteSettingsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteSettingsAdresses");

            migrationBuilder.DropTable(
                name: "SiteSettingsQuickLinks");

            migrationBuilder.DropTable(
                name: "SiteSettingsSocialMedias");

            migrationBuilder.DropTable(
                name: "SiteSettingsTopMenus");

            migrationBuilder.DropTable(
                name: "SiteSettings");
        }
    }
}
