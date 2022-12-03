using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UltraWebsite.Migrations
{
    /// <inheritdoc />
    public partial class aaaaaaaaaaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imageurl = table.Column<string>(name: "Image_url", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imageurl = table.Column<string>(name: "Image_url", type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    catalogueid = table.Column<int>(name: "catalogue_id", type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductAdjective = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Catalogues_catalogue_id",
                        column: x => x.catalogueid,
                        principalTable: "Catalogues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catalogues",
                columns: new[] { "Id", "Image_url", "Name" },
                values: new object[,]
                {
                    { 1, null, "Kitab" },
                    { 2, null, "  Süpürge                                " },
                    { 3, null, "Ütü                                      " },
                    { 4, null, "Robot Süpürge                            " },
                    { 5, null, "Kahve Makinesi                           " },
                    { 6, null, "Blender                                  " },
                    { 7, null, "Çay Makinesi                             " },
                    { 8, null, "Tost Makinesi                            " },
                    { 9, null, "Waffle Makinesi                          " },
                    { 10, null, "Tartı                                    " },
                    { 11, null, "Giyilebilir Teknoloji                    " },
                    { 12, null, "Akıllı Saat                              " },
                    { 13, null, "Akıllı Bileklik                          " },
                    { 14, null, "Telefon                                  " },
                    { 15, null, "Cep Telefonu                             " },
                    { 16, null, "Kapak & Kılıf                            " },
                    { 17, null, "Şarj Cihazları                           " },
                    { 18, null, "Powerbank                                " },
                    { 19, null, "Bilgisayar & Tablet                      " },
                    { 20, null, "Laptop                                   " },
                    { 21, null, "Tablet                                   " },
                    { 22, null, "Bilgisayar Bileşenleri                   " },
                    { 23, null, "Monitör                                  " },
                    { 24, null, "Yazıcı & Tarayıcı                        " },
                    { 25, null, "Çevre Birimleri                          " },
                    { 26, null, "Ağ & Modem                               " },
                    { 27, null, "TV & Görüntü & Ses                       " },
                    { 28, null, "Televizyon                               " },
                    { 29, null, "Soundbar                                 " },
                    { 30, null, "Projeksiyon Cihazı                       " },
                    { 31, null, "Media Player                             " },
                    { 32, null, "Hoparlör                                 " },
                    { 33, null, "Kulaklık                                 " },
                    { 34, null, "Kişisel Bakım Aletleri                   " },
                    { 35, null, "Saç Düzleştirici                         " },
                    { 36, null, "Tıraş Makinesi                           " },
                    { 37, null, "Saç Maşası                               " },
                    { 38, null, "Saç Kurutma Makinesi                     " },
                    { 39, null, "Epilasyon Aleti                          " },
                    { 40, null, "Beyaz Eşya                               " },
                    { 41, null, "Buzdolabı                                " },
                    { 42, null, "Çamaşır Makinesi                         " },
                    { 43, null, "Bulaşık Makinesi                         " },
                    { 44, null, "Ankastre                                 " },
                    { 45, null, "Derin Dondurucu                          " },
                    { 46, null, "Klima                                    " },
                    { 47, null, "Kombi                                    " },
                    { 48, null, "Elektronik Aksesuarlar                   " },
                    { 49, null, "Bilgisayar Aksesuar                      " },
                    { 50, null, "Telefon Aksesuarları                     " },
                    { 51, null, "TV Aksesuarları                          " },
                    { 52, null, "Veri Depolama                            " },
                    { 53, null, "Oyunculara Özel                          " },
                    { 54, null, "Playstation                              " },
                    { 55, null, "Xbox                                     " },
                    { 56, null, "Nintendo                                 " },
                    { 57, null, "Playstation Oyunları                     " },
                    { 58, null, "Konsol Aksesuarları                      " },
                    { 59, null, "Oyuncu Bilgisayarı                       " },
                    { 60, null, "Oyuncu Donanımları                       " },
                    { 61, null, "Oyuncu Monitörleri                       " },
                    { 62, null, "Foto & Kamera                            " },
                    { 63, null, "Aksiyon Kamera                           " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_catalogue_id",
                table: "Products",
                column: "catalogue_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Catalogues");
        }
    }
}
