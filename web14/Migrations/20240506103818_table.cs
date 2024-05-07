using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web14.Migrations
{
    /// <inheritdoc />
    public partial class table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uyetipi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uyetipi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyetipi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<double>(type: "float", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ÜyetipiId = table.Column<int>(type: "int", nullable: false),
                    Uyetipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeTipiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registers_Uyetipi_UyeTipiId",
                        column: x => x.UyeTipiId,
                        principalTable: "Uyetipi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registers_UyeTipiId",
                table: "Registers",
                column: "UyeTipiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registers");

            migrationBuilder.DropTable(
                name: "Uyetipi");
        }
    }
}
