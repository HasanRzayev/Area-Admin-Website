using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UltraWebsite.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<int>(name: "product_id", type: "int", nullable: true),
                    userid = table.Column<string>(name: "user_id", type: "nvarchar(450)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_user_id",
                        column: x => x.userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_product_id",
                        column: x => x.productid,
                        principalTable: "Products",
                        principalColumn: "Id");
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
                    { 2, null, "            Kadin                    " },
                    { 3, null, "            Giyim                    " },
                    { 4, null, "Elbise                               " },
                    { 5, null, "Tisört                               " },
                    { 6, null, "Gömlek                               " },
                    { 7, null, "Kot Pantolon                         " },
                    { 8, null, "Kot Ceket                            " },
                    { 9, null, "Pantolon                             " },
                    { 10, null, "Mont                                 " },
                    { 11, null, "Bluz                                 " },
                    { 12, null, "Ceket                                " },
                    { 13, null, "Etek                                 " },
                    { 14, null, "Kazak                                " },
                    { 15, null, "Tesettür                             " },
                    { 16, null, "Büyük Beden                          " },
                    { 17, null, "Ayakkabi                             " },
                    { 18, null, "Topuklu Ayakkabi                     " },
                    { 19, null, "Sneaker                              " },
                    { 20, null, "Günlük Ayakkabi                      " },
                    { 21, null, "Babet                                " },
                    { 22, null, "Sandalet                             " },
                    { 23, null, "Bot                                  " },
                    { 24, null, "Aksesuar & amp; Çanta                " },
                    { 25, null, "Çanta                                " },
                    { 26, null, "Saat                                 " },
                    { 27, null, "Taki                                 " },
                    { 28, null, "Sapka                                " },
                    { 29, null, "Cüzdan                               " },
                    { 30, null, "Iç Giyim                             " },
                    { 31, null, "Pijama Takimi                        " },
                    { 32, null, "Gecelik                              " },
                    { 33, null, "Sütyen                               " },
                    { 34, null, "Iç Çamasiri Takimlari                " },
                    { 35, null, "Fantezi Giyim                        " },
                    { 36, null, "Çorap                                " },
                    { 37, null, "Lüks & amp; Designer                 " },
                    { 38, null, "Lüks Çanta                           " },
                    { 39, null, "Lüks Giyim                           " },
                    { 40, null, "Lüks Ayakkabi                        " },
                    { 41, null, "Tasarim Giyim                        " },
                    { 42, null, "Tasarim Ayakkabi                     " },
                    { 43, null, "Kozmetik                             " },
                    { 44, null, "Parfüm                               " },
                    { 45, null, "Göz Makyaji                          " },
                    { 46, null, "Cilt Bakim                           " },
                    { 47, null, "Saç Bakimi                           " },
                    { 48, null, "Makyaj                               " },
                    { 49, null, "Agiz Bakim                           " },
                    { 50, null, "Cinsel Saglik                        " },
                    { 51, null, "Vücut Bakim                          " },
                    { 52, null, "Hijyenik Ped                         " },
                    { 53, null, "Dus Jeli &amp; Kremleri              " },
                    { 54, null, "Epilasyon Ürünleri                   " },
                    { 55, null, "Ruj                                  " },
                    { 56, null, "Günes Kremi                          " },
                    { 57, null, "Spor & amp; Outdoor                  " },
                    { 58, null, "Sweatshirt                           " },
                    { 59, null, "Tisört                               " },
                    { 60, null, "Spor Sütyeni                         " },
                    { 61, null, "Tayt                                 " },
                    { 62, null, "Esofman                              " },
                    { 63, null, "Kosu Ayakkabisi                      " },
                    { 64, null, "Spor Çantasi                         " },
                    { 65, null, "Spor Ekipmanlari                     " },
                    { 66, null, "Outdoor Ayakkabi                     " },
                    { 67, null, "Kar Botu                             " },
                    { 68, null, "Outdoor Ekipmanlari                  " },
                    { 69, null, "Sporcu Besinleri                     " },
                    { 70, null, "Sporcu Aksesuarlari                  " },
                    { 71, null, "Erkek                                " },
                    { 72, null, "Giyim                                " },
                    { 73, null, "Tisört                               " },
                    { 74, null, "Sort                                 " },
                    { 75, null, "Gömlek                               " },
                    { 76, null, "Esofman                              " },
                    { 77, null, "Pantolon                             " },
                    { 78, null, "Ceket                                " },
                    { 79, null, "Kot Pantolon                         " },
                    { 80, null, "Yelek                                " },
                    { 81, null, "Kazak                                " },
                    { 82, null, "Mont                                 " },
                    { 83, null, "Takim Elbise                         " },
                    { 84, null, "Sweatshirt                           " },
                    { 85, null, "Forma                                " },
                    { 86, null, "Ayakkabi                             " },
                    { 87, null, "Spor Ayakkabi                        " },
                    { 88, null, "Günlük Ayakkabi                      " },
                    { 89, null, "Yürüyüs Ayakkabisi                   " },
                    { 90, null, "Krampon                              " },
                    { 91, null, "Sneaker                              " },
                    { 92, null, "Klasik                               " },
                    { 93, null, "Bot                                  " },
                    { 94, null, "Kisisel Bakim                        " },
                    { 95, null, "Parfüm                               " },
                    { 96, null, "Cinsel Saglik                        " },
                    { 97, null, "Tiras Sonrasi Ürünler                " },
                    { 98, null, "Tiras Biçagi                         " },
                    { 99, null, "Saat & amp; Aksesuar                 " },
                    { 100, null, "Saat                                 " },
                    { 101, null, "Günes Gözlügü                        " },
                    { 102, null, "Cüzdan                               " },
                    { 103, null, "Kemer                                " },
                    { 104, null, "Çanta                                " },
                    { 105, null, "Sapka                                " },
                    { 106, null, "Bileklik                             " },
                    { 107, null, "Iç Giyim                             " },
                    { 108, null, "Boxer                                " },
                    { 109, null, "Çorap                                " },
                    { 110, null, "Pijama                               " },
                    { 111, null, "Atlet                                " },
                    { 112, null, "Spor & amp; Outdoor                  " },
                    { 113, null, "Esofman                              " },
                    { 114, null, "Spor Ayakkabi                        " },
                    { 115, null, "T - shirt                            " },
                    { 116, null, "Sweatshirt                           " },
                    { 117, null, "Forma                                " },
                    { 118, null, "Spor Çorap                           " },
                    { 119, null, "Spor Giyim                           " },
                    { 120, null, "Outdoor Ayakkabi                     " },
                    { 121, null, "Outdoor Bot                          " },
                    { 122, null, "Spor Ekipmanlari                     " },
                    { 123, null, "Outdoor Ekipmanlari                  " },
                    { 124, null, "Sporcu Besinleri                     " },
                    { 125, null, "Sporcu Aksesuarlari                  " },
                    { 126, null, "Elektronik                           " },
                    { 127, null, "Tiras Makinesi                       " },
                    { 128, null, "Cep Telefonu                         " },
                    { 129, null, "Akilli Saat                          " },
                    { 130, null, "Akilli Bileklik                      " },
                    { 131, null, "Laptop                               " },
                    { 132, null, "Oyun & amp; Konsollar                " },
                    { 133, null, "Elektrikli Bisiklet                  " },
                    { 134, null, "E - pin ve Cüzdan Kodu               " },
                    { 135, null, "Lüks & amp; Designer                 " },
                    { 136, null, "Lüks Giyim                           " },
                    { 137, null, "Lüks Ayakkabi                        " },
                    { 138, null, "Lüks Çanta                           " },
                    { 139, null, "Anne & amp; Çocuk                    " },
                    { 140, null, "Bebek                                " },
                    { 141, null, "Bebek Takimlari                      " },
                    { 142, null, "Ayakkabi                             " },
                    { 143, null, "Hastane Çikisi                       " },
                    { 144, null, "Yenidogan Kiyafetleri                " },
                    { 145, null, "Tulum & amp; Salopet                 " },
                    { 146, null, "Body & amp; Zibin                    " },
                    { 147, null, "Tisört & amp; Atlet                  " },
                    { 148, null, "Elbise                               " },
                    { 149, null, "Sort                                 " },
                    { 150, null, "Bebek Patigi                         " },
                    { 151, null, "Bebek Bezi                           " },
                    { 152, null, "Bebek Mamasi                         " },
                    { 153, null, "Islak Mendil                         " },
                    { 154, null, "Kiz Çocuk                            " },
                    { 155, null, "Elbise                               " },
                    { 156, null, "Sweatshirt                           " },
                    { 157, null, "Spor Ayakkabi                        " },
                    { 158, null, "Esofman                              " },
                    { 159, null, "Iç Giyim &amp; Pijama                " },
                    { 160, null, "Tisört & amp; Atlet                  " },
                    { 161, null, "Tayt                                 " },
                    { 162, null, "Günlük Ayakkabi                      " },
                    { 163, null, "Sort                                 " },
                    { 164, null, "Mont                                 " },
                    { 165, null, "Çocuk Oyun Evi                       " },
                    { 166, null, "Oyuncak Bebek                        " },
                    { 167, null, "Oyuncak Mutfak                       " },
                    { 168, null, "Erkek Çocuk                          " },
                    { 169, null, "Sweatshirt                           " },
                    { 170, null, "Spor Ayakkabi                        " },
                    { 171, null, "Esofman                              " },
                    { 172, null, "Iç Giyim & amp; Pijama               " },
                    { 173, null, "Tisört & amp; Atlet                  " },
                    { 174, null, "Günlük Ayakkabi                      " },
                    { 175, null, "Okul Çantasi                         " },
                    { 176, null, "Sort                                 " },
                    { 177, null, "Gömlek                               " },
                    { 178, null, "Mont                                 " },
                    { 179, null, "Oyuncak Traktör                      " },
                    { 180, null, "Akülü Araba                          " },
                    { 181, null, "Kumandali Araba                      " },
                    { 182, null, "Bebek Bakim                          " },
                    { 183, null, "Banyo & amp; Tuvalet                 " },
                    { 184, null, "Bebek Sampuani                       " },
                    { 185, null, "Krem & amp; Yaglar                   " },
                    { 186, null, "Bebek Çantasi                        " },
                    { 187, null, "Oyuncak                              " },
                    { 188, null, "Egitici Oyuncaklar                   " },
                    { 189, null, "Oyuncak Araba                        " },
                    { 190, null, "Oyuncak Bebek                        " },
                    { 191, null, "Bebek & amp; Okul Öncesi             " },
                    { 192, null, "Kumandali Oyuncak                    " },
                    { 193, null, "Robot Oyuncak                        " },
                    { 194, null, "Oyun Hamuru                          " },
                    { 195, null, "Tasima & amp; Güvenlik               " },
                    { 196, null, "Bebek Arabasi & amp; Puset           " },
                    { 197, null, "            Park Yatak               " },
                    { 198, null, "Ana Kucagi                           " },
                    { 199, null, "Portbebe & amp; Kanguru              " },
                    { 200, null, "Yürüteç                              " },
                    { 201, null, "Oto Koltugu                          " },
                    { 202, null, "Beslenme Emzirme                     " },
                    { 203, null, "Biberon & amp; Emzik                 " },
                    { 204, null, "Gögüs Pompasi                        " },
                    { 205, null, "Mama Sandalyesi                      " },
                    { 206, null, "Mama Önlügü                          " },
                    { 207, null, "Alistirma Bardagi                    " },
                    { 208, null, "Ev & amp; Mobilya                    " },
                    { 209, null, "Sofra & amp; Mutfak                  " },
                    { 210, null, "Yemek Takimi                         " },
                    { 211, null, "Çatal Kasik Biçak Seti               " },
                    { 212, null, "Baharat Takimi                       " },
                    { 213, null, "Bardak                               " },
                    { 214, null, "Firin & amp; Kek Kalibi              " },
                    { 215, null, "Çaydanlik                            " },
                    { 216, null, "Tencere Seti                         " },
                    { 217, null, "Banyo                                " },
                    { 218, null, "Havlu & amp; Havlu Seti              " },
                    { 219, null, "Bornoz                               " },
                    { 220, null, "Banyo Seti                           " },
                    { 221, null, "            Banyo Paspasi            " },
                    { 222, null, "Ev Tekstili                          " },
                    { 223, null, "Yatak Odasi                          " },
                    { 224, null, "Hali & amp; Kilim & amp; Paspas      " },
                    { 225, null, "Perde                                " },
                    { 226, null, "Nevresim Takimi                      " },
                    { 227, null, "Yastik                               " },
                    { 228, null, "Kirlent ve Kilifi                    " },
                    { 229, null, "Ev Dekorasyon                        " },
                    { 230, null, "Dekoratif Aksesuar                   " },
                    { 231, null, "Tablo                                " },
                    { 232, null, "Duvar Saati                          " },
                    { 233, null, "Ayna                                 " },
                    { 234, null, "Trendyol Sanat                       " },
                    { 235, null, "Aydinlatma                           " },
                    { 236, null, "Avize                                " },
                    { 237, null, "Lambader                             " },
                    { 238, null, "Abajur                               " },
                    { 239, null, "Mobilya                              " },
                    { 240, null, "Salon & amp; Oturma Odasi            " },
                    { 241, null, "Yatak Odasi                          " },
                    { 242, null, "Bahçe Mobilyasi                      " },
                    { 243, null, "Çalisma Odasi                        " },
                    { 244, null, "Ev Gereçleri                         " },
                    { 245, null, "Düzenleyici                          " },
                    { 246, null, "Çamasirlik                           " },
                    { 247, null, "Sepet & amp; Saklama Kutusu          " },
                    { 248, null, "Hobi                                 " },
                    { 249, null, "Kitap                                " },
                    { 250, null, "Puzzle                               " },
                    { 251, null, "Boya & amp; Resim                    " },
                    { 252, null, "Kutu Oyunlari                        " },
                    { 253, null, "Kirtasiye & amp; Ofis                " },
                    { 254, null, "Defter                               " },
                    { 255, null, "Kalem                                " },
                    { 256, null, "Spor & amp; Outdoor                  " },
                    { 257, null, "Kosu Bandi                           " },
                    { 258, null, "Dumbell & amp; Agirlik               " },
                    { 259, null, "Pilates & amp; Yoga                  " },
                    { 260, null, "Eliptik Bisiklet                     " },
                    { 261, null, "Otomobil & amp; Motosiklet           " },
                    { 262, null, "Oto Aksesuar                         " },
                    { 263, null, "Oto Paspasi                          " },
                    { 264, null, "Oto Lastik                           " },
                    { 265, null, "Kask                                 " },
                    { 266, null, "Yapi Market                          " },
                    { 267, null, "Banyo Yapi Malzemeleri               " },
                    { 268, null, "Elektrikli El Aleti                  " },
                    { 269, null, "Hirdavat Ürünleri                    " },
                    { 270, null, "Boya                                 " },
                    { 271, null, "Matkap                               " },
                    { 272, null, "Ampul                                " },
                    { 273, null, "Süpermarket                          " },
                    { 274, null, "Ev & amp; Temizlik                   " },
                    { 275, null, "Çamasir Yikama                       " },
                    { 276, null, "Bulasik Yikama                       " },
                    { 277, null, "Ev Temizlik                          " },
                    { 278, null, "Paspas & amp; Mop                    " },
                    { 279, null, "Kagit Ürünleri                       " },
                    { 280, null, "Gida                                 " },
                    { 281, null, "Çay                                  " },
                    { 282, null, "Kahve                                " },
                    { 283, null, "Kuruyemis                            " },
                    { 284, null, "Kahvaltilik                          " },
                    { 285, null, "Organik Ürünler                      " },
                    { 286, null, "Diyabetik Ürünler                    " },
                    { 287, null, "Kisisel Bakim                        " },
                    { 288, null, "Saç Bakimi                           " },
                    { 289, null, "Agda & amp; Epilasyon                " },
                    { 290, null, "Banyo & amp; Dus                     " },
                    { 291, null, "Agiz Bakim                           " },
                    { 292, null, "Cilt Bakimi                          " },
                    { 293, null, "Vücut Bakimi                         " },
                    { 294, null, "Saglik & amp; Spor                   " },
                    { 295, null, "Cinsel Saglik                        " },
                    { 296, null, "Hijyenik Ped                         " },
                    { 297, null, "Sporcu Besinleri                     " },
                    { 298, null, "Vitamin & amp; Ek Gida               " },
                    { 299, null, "Hasta Bezi &amp; Temizlik            " },
                    { 300, null, "Petshop                              " },
                    { 301, null, "Kedi Mamasi                          " },
                    { 302, null, "Kedi Kumu                            " },
                    { 303, null, "Köpek Mamasi                         " },
                    { 304, null, "Köpek Tasmasi                        " },
                    { 305, null, "Kus Ürünleri                         " },
                    { 306, null, "Akvaryum Ürünleri                    " },
                    { 307, null, "Bebek Bakim                          " },
                    { 308, null, "Süt Arttirici Içecekler              " },
                    { 309, null, "Bebek Ek Besin                       " },
                    { 310, null, "Bebek Bezi                           " },
                    { 311, null, "Islak Mendil &amp; Havlu             " },
                    { 312, null, "Bebek Kozmetik                       " },
                    { 313, null, "Kozmetik                             " },
                    { 314, null, "Makyaj                               " },
                    { 315, null, "Göz Makyaji                          " },
                    { 316, null, "Ten Makyaji                          " },
                    { 317, null, "Dudak Makyaji                        " },
                    { 318, null, "Makyaj Seti                          " },
                    { 319, null, "Oje & amp; Aseton                    " },
                    { 320, null, "Fondöten                             " },
                    { 321, null, "Parfüm & amp; Deodorant              " },
                    { 322, null, "Parfüm                               " },
                    { 323, null, "Parfüm Setleri                       " },
                    { 324, null, "Deodorant & amp; Roll - on           " },
                    { 325, null, "Vücut Spreyi                         " },
                    { 326, null, "Cilt Bakimi                          " },
                    { 327, null, "Yüz Kremi                            " },
                    { 328, null, "Yüz Temizleme                        " },
                    { 329, null, "Yüz Maskesi                          " },
                    { 330, null, "Göz Bakimi                           " },
                    { 331, null, "Günes Koruyucu                       " },
                    { 332, null, "Cilt Serumu                          " },
                    { 333, null, "El & amp; Ayak Bakimi                " },
                    { 334, null, "Saç Bakimi                           " },
                    { 335, null, "Sampuan                              " },
                    { 336, null, "Saç Sekillendirici                   " },
                    { 337, null, "Saç Serumu & amp; Maskesi            " },
                    { 338, null, "Saç Boyasi                           " },
                    { 339, null, "Epilasyon & amp; Tiras               " },
                    { 340, null, "Tüy Dökücü                           " },
                    { 341, null, "Agda                                 " },
                    { 342, null, "Tiras Biçagi                         " },
                    { 343, null, "Epilatör                             " },
                    { 344, null, "Tiras Köpügü                         " },
                    { 345, null, "Genel Bakim                          " },
                    { 346, null, "Cinsel Saglik                        " },
                    { 347, null, "Hijyenik Ped                         " },
                    { 348, null, "Vücut Bakimi                         " },
                    { 349, null, "El ve Ayak Bakimi                    " },
                    { 350, null, "Dus Jeli ve Kremi                    " },
                    { 351, null, "Bakim Yaglari                        " },
                    { 352, null, "Ayakkabi & amp; Çanta                " },
                    { 353, null, "Kadin Ayakkabi                       " },
                    { 354, null, "Spor Ayakkabi                        " },
                    { 355, null, "Topuklu Ayakkabi                     " },
                    { 356, null, "Günlük Ayakkabi                      " },
                    { 357, null, "Bot & amp; Bootie                    " },
                    { 358, null, "            Sandalet                 " },
                    { 359, null, "Terlik                               " },
                    { 360, null, "Kadin Çanta                          " },
                    { 361, null, "Omuz Çantasi                         " },
                    { 362, null, "Sirt Çantasi                         " },
                    { 363, null, "Cüzdan                               " },
                    { 364, null, "Spor Çantasi                         " },
                    { 365, null, "Bel Çantasi                          " },
                    { 366, null, "Erkek Ayakkabi                       " },
                    { 367, null, "Spor Ayakkabi                        " },
                    { 368, null, "Günlük Ayakkabi                      " },
                    { 369, null, "Klasik Ayakkabi                      " },
                    { 370, null, "Bot                                  " },
                    { 371, null, "Sneaker                              " },
                    { 372, null, "Kosu Ayakkabisi                      " },
                    { 373, null, "Krampon                              " },
                    { 374, null, "Erkek Çanta                          " },
                    { 375, null, "Sirt Çantasi                         " },
                    { 376, null, "Postaci Çantasi                      " },
                    { 377, null, "Cüzdan & amp; Kartlik                " },
                    { 378, null, "Spor Çantasi                         " },
                    { 379, null, "Çocuk Ayakkabi                       " },
                    { 380, null, "Spor Ayakkabi                        " },
                    { 381, null, "Günlük Ayakkabi                      " },
                    { 382, null, "Babet                                " },
                    { 383, null, "Çocuk Çanta                          " },
                    { 384, null, "Sirt Çantasi                         " },
                    { 385, null, "Okul Çantasi                         " },
                    { 386, null, "Lüks & amp; Designer                 " },
                    { 387, null, "Lüks Çanta                           " },
                    { 388, null, "Lüks Ayakkabi                        " },
                    { 389, null, "Tasarim Çanta                        " },
                    { 390, null, "Tasarim Ayakkabi                     " },
                    { 391, null, "Saat & amp; Aksesuar                 " },
                    { 392, null, "Kadin                                " },
                    { 393, null, "Saat                                 " },
                    { 394, null, "Günes Gözlügü                        " },
                    { 395, null, "Taki                                 " },
                    { 396, null, "Cüzdan                               " },
                    { 397, null, "Kemer                                " },
                    { 398, null, "Sapka                                " },
                    { 399, null, "Atki Bere Eldiven                    " },
                    { 400, null, "Sal & amp; Fular                     " },
                    { 401, null, "Semsiye                              " },
                    { 402, null, "Gözlük Kabi                          " },
                    { 403, null, "Saç Aksesuari                        " },
                    { 404, null, "Hasir Bilezik                        " },
                    { 405, null, "Burma Bilezik                        " },
                    { 406, null, "22 Ayar Bilezik                      " },
                    { 407, null, "Taki & amp; Mücevher                 " },
                    { 408, null, "Kolye                                " },
                    { 409, null, "Küpe                                 " },
                    { 410, null, "Bileklik                             " },
                    { 411, null, "Halhal                               " },
                    { 412, null, "Yüzük                                " },
                    { 413, null, "Altin                                " },
                    { 414, null, "Piercing                             " },
                    { 415, null, "Elektronik Aksesuarlar               " },
                    { 416, null, "Telefon Kilifi                       " },
                    { 417, null, "Akilli Saat                          " },
                    { 418, null, "Akilli Bileklik                      " },
                    { 419, null, "Erkek                                " },
                    { 420, null, "Saat                                 " },
                    { 421, null, "Günes Gözlügü                        " },
                    { 422, null, "Cüzdan & amp; Kartlik                " },
                    { 423, null, "Kemer                                " },
                    { 424, null, "Bileklik                             " },
                    { 425, null, "Sapka Bere Eldiven                   " },
                    { 426, null, "Kravat                               " },
                    { 427, null, "Valiz                                " },
                    { 428, null, "Çocuk Aksesuar                       " },
                    { 429, null, "Saat                                 " },
                    { 430, null, "Günes Gözlügü                        " },
                    { 431, null, "Sapka                                " },
                    { 432, null, "Elektronik                           " },
                    { 433, null, "Küçük Ev Aletleri                    " },
                    { 434, null, "Süpürge                              " },
                    { 435, null, "Ütü                                  " },
                    { 436, null, "Robot Süpürge                        " },
                    { 437, null, "Kahve Makinesi                       " },
                    { 438, null, "Blender                              " },
                    { 439, null, "Çay Makinesi                         " },
                    { 440, null, "Tost Makinesi                        " },
                    { 441, null, "Waffle Makinesi                      " },
                    { 442, null, "Tarti                                " },
                    { 443, null, "Giyilebilir Teknoloji                " },
                    { 444, null, "Akilli Saat                          " },
                    { 445, null, "Akilli Bileklik                      " },
                    { 446, null, "Telefon                              " },
                    { 447, null, "Cep Telefonu                         " },
                    { 448, null, "Kapak & amp; Kilif                   " },
                    { 449, null, "Sarj Cihazlari                       " },
                    { 450, null, "Powerbank                            " },
                    { 451, null, "Bilgisayar & amp; Tablet             " },
                    { 452, null, "Laptop                               " },
                    { 453, null, "Tablet                               " },
                    { 454, null, "Bilgisayar Bilesenleri               " },
                    { 455, null, "Monitör                              " },
                    { 456, null, "Yazici & amp; Tarayici               " },
                    { 457, null, "Çevre Birimleri                      " },
                    { 458, null, "Ag & amp; Modem                      " },
                    { 459, null, "TV & amp; Görüntü & amp; Ses         " },
                    { 460, null, "Televizyon                           " },
                    { 461, null, "Soundbar                             " },
                    { 462, null, "Projeksiyon Cihazi                   " },
                    { 463, null, "Media Player                         " },
                    { 464, null, "Hoparlör                             " },
                    { 465, null, "Kulaklik                             " },
                    { 466, null, "Kisisel Bakim Aletleri               " },
                    { 467, null, "Saç Düzlestirici                     " },
                    { 468, null, "Tiras Makinesi                       " },
                    { 469, null, "Saç Masasi                           " },
                    { 470, null, "Saç Kurutma Makinesi                 " },
                    { 471, null, "Epilasyon Aleti                      " },
                    { 472, null, "Beyaz Esya                           " },
                    { 473, null, "Buzdolabi                            " },
                    { 474, null, "Çamasir Makinesi                     " },
                    { 475, null, "Bulasik Makinesi                     " },
                    { 476, null, "Ankastre                             " },
                    { 477, null, "Derin Dondurucu                      " },
                    { 478, null, "Klima                                " },
                    { 479, null, "Kombi                                " },
                    { 480, null, "Elektronik Aksesuarlar               " },
                    { 481, null, "Bilgisayar Aksesuar                  " },
                    { 482, null, "Telefon Aksesuarlari                 " },
                    { 483, null, "TV Aksesuarlari                      " },
                    { 484, null, "Veri Depolama                        " },
                    { 485, null, "Oyunculara Özel                      " },
                    { 486, null, "Playstation                          " },
                    { 487, null, "Xbox                                 " },
                    { 488, null, "Nintendo                             " },
                    { 489, null, "Playstation Oyunlari                 " },
                    { 490, null, "Konsol Aksesuarlari                  " },
                    { 491, null, "Oyuncu Bilgisayari                   " },
                    { 492, null, "Oyuncu Donanimlari                   " },
                    { 493, null, "Oyuncu Monitörleri                   " },
                    { 494, null, "Foto & amp; Kamera                   " },
                    { 495, null, "Aksiyon Kamera                       " },
                    { 496, null, "Fotograf Makinesi                    " },
                    { 497, null, "Dijital Kod & amp; Ürünler           " },
                    { 498, null, "Spor & amp; Outdoor                  " },
                    { 499, null, "Spor Giyim                           " },
                    { 500, null, "Spor Tisört                          " },
                    { 501, null, "Spor Sort                            " },
                    { 502, null, "Spor Tayt                            " },
                    { 503, null, "Sporcu Sütyeni                       " },
                    { 504, null, "Esofman                              " },
                    { 505, null, "Spor Sweatshirt                      " },
                    { 506, null, "Yagmurluk                            " },
                    { 507, null, "Spor Yelek                           " },
                    { 508, null, "Spor Atlet                           " },
                    { 509, null, "Forma                                " },
                    { 510, null, "Spor Mont                            " },
                    { 511, null, "Spor Sapka                           " },
                    { 512, null, "Çorap                                " },
                    { 513, null, "Spor Ayakkabi                        " },
                    { 514, null, "Sneaker                              " },
                    { 515, null, "Kosu Ayakkabisi                      " },
                    { 516, null, "Hali Saha Ayakkabisi                 " },
                    { 517, null, "Basketbol Ayakkabisi                 " },
                    { 518, null, "Yürüyüs Ayakkabisi                   " },
                    { 519, null, "Outdoor Ayakkabi                     " },
                    { 520, null, "Tenis Ayakkabisi                     " },
                    { 521, null, "Voleybol Ayakkabisi                  " },
                    { 522, null, "Fitness Ayakkabisi                   " },
                    { 523, null, "Deniz Ayakkabisi                     " },
                    { 524, null, "Kaykay Ayakkabisi                    " },
                    { 525, null, "Outdoor Bot                          " },
                    { 526, null, "Terlik                               " },
                    { 527, null, "Spor Malzemeleri                     " },
                    { 528, null, "Deniz & amp; Plaj                    " },
                    { 529, null, "Kaykay                               " },
                    { 530, null, "Paten                                " },
                    { 531, null, "Kamp Malzemeleri                     " },
                    { 532, null, "Dagcilik & amp; Tirmanis             " },
                    { 533, null, "Aksiyon Kamera                       " },
                    { 534, null, "Çadir Uyku Tulumu                    " },
                    { 535, null, "Su Sporu Malzemeleri                 " },
                    { 536, null, "Dalis Malzemeleri                    " },
                    { 537, null, "Balikçilik Malzemeleri               " },
                    { 538, null, "Tenis Malzemeleri                    " },
                    { 539, null, "Kayak ve Snowboard                   " },
                    { 540, null, "Okçuluk                              " },
                    { 541, null, "Bisiklet                             " },
                    { 542, null, "Sehir Bisikleti                      " },
                    { 543, null, "Dag Bisikleti                        " },
                    { 544, null, "Fitness Kondisyon                    " },
                    { 545, null, "Pilates Malzemeleri                  " },
                    { 546, null, "Fitness Aletleri                     " },
                    { 547, null, "Kondisyon Bisikleti                  " },
                    { 548, null, "Kosu Bandi                           " },
                    { 549, null, "Yoga Malzemeleri                     " },
                    { 550, null, "Dambil Seti                          " },
                    { 551, null, "Agirlik Plakalari                    " },
                    { 552, null, "Barfiks                              " },
                    { 553, null, "Sporcu Besinleri                     " },
                    { 554, null, "Protein Tozu                         " },
                    { 555, null, "Amino Asit                           " },
                    { 556, null, "Karbonhidrat                         " },
                    { 557, null, "L - Karnitin(CLA)                    " },
                    { 558, null, "Güç ve Performans                    " },
                    { 559, null, "Gida Takviyesi & amp; Vitaminler     " },
                    { 560, null, "Kreatin                              " },
                    { 561, null, "Protein Bar                          " },
                    { 562, null, "Shaker                               " },
                    { 563, null, "Top                                  " },
                    { 564, null, "Basketbol Topu                       " },
                    { 565, null, "Futbol Topu                          " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_product_id",
                table: "Orders",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_user_id",
                table: "Orders",
                column: "user_id");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Catalogues");
        }
    }
}
