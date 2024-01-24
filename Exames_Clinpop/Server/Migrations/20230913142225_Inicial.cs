using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exames_Clinpop.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exames",
                columns: table => new
                {
                    ExameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeExame = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescricaoExame = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exames", x => x.ExameId);
                });

            migrationBuilder.InsertData(
                table: "Exames",
                columns: new[] { "ExameId", "DescricaoExame", "NomeExame", "Preco" },
                values: new object[] { 1, "Exame de Sangue", "V.D.R.L", 6.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exames");
        }
    }
}
