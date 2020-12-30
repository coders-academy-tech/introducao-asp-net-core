using Microsoft.EntityFrameworkCore.Migrations;

namespace CarGallery.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Porsche", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Ferrari", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Ford", null });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "/assets/porsche/porsche_911_Turbo_small.jpg", "/assets/porsche/porsche_911_Turbo.jpg", "Sempre que um carro apresenta um comportamento irrepreensível, é difícil não nos perguntarmos como será possível fazer algo melhor em uma futura geração. Desde a primeira edição do 911 Turbo, em 1975, porém, os engenheiros da Porsche vêm conseguindo essa insuspeita superação e desta vez não foi diferente.", "Porsche 911 Turbo", "Porsche 911 Turbo S" },
                    { 2, 1, "/assets/porsche/porsche-cayenne-coupe_small.jpg", "/assets/porsche/porsche-cayenne-coupe.jpg", "Cayenne é um case de sucesso na indústria automobilística. Graças a ele, a Porsche se reinventou, passou a ganhar dinheiro como nunca e hoje é ainda mais forte do que era quando se fala em automóveis esportivos. Com mais de 800 mil unidades vendidas no mundo e 5,2 mil no Brasil, o Cayenne se dá ao luxo de cobrar a mais pelo logotipo que carrega", "Porsche Cayenne", "O equilibrio entre desempenho e conforto" },
                    { 3, 2, "/assets/ferrari/ferrari-F8_small.jpg", "/assets/ferrari/ferrari-F8.jpg", "F8 Tributo é uma homenagem ao premiado motor V8 da marca italiana. Trata-se de um 3.9 biturbo, que entrega 720 cavalos e 78,5 kgfm de torque", "Ferrari F8 Tributo", "F8 Tributo - A lenda" },
                    { 4, 2, "/assets/ferrari/ferrarri_spider_small.jpg", "/assets/ferrari/ferrarri_spider.jpg", "O coração do novo 458 Spider é o vencedor do Prêmio Motor Internacional do Ano de 2018, um V8 twin-turbo de 3,9 litros com 720 cavalos de potência e 78,52 kgfm de torque", "Ferrari 458 Spider", "O V8 mais poderoso já feito pela marca" },
                    { 5, 3, "/assets/ford/ford_mustang_small.jpg", "/assets/ford/ford_mustang.jpg", "O Mustang GT é absolutamente a melhor forma de começar o dia, já que seu motor é uma joia. O V8 ainda mantém o nome de Coyote, mas não é quieto como o anterior. O motor esbraveja como o melhor muscle car de todos os tempos.", "Ford Mustang", "O melhor pony car" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
