using Bogus;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Threading;
using UltraWebsite.Models.Entity;

namespace UltraWebsite.Models.Configurations
{
    public class CatagoryConfigration : IEntityTypeConfiguration<Catagory>
    {
        public int index { get; set; }




        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            index = 1;
            builder.HasData(new Catagory { Id = index++, Name = "Kitab" });
            builder.HasData(new Catagory { Id = index++, Name = "  Süpürge                                " });
            builder.HasData(new Catagory { Id = index++, Name = "Ütü                                      " });
            builder.HasData(new Catagory { Id = index++, Name = "Robot Süpürge                            " });
            builder.HasData(new Catagory { Id = index++, Name = "Kahve Makinesi                           " });
            builder.HasData(new Catagory { Id = index++, Name = "Blender                                  " });
            builder.HasData(new Catagory { Id = index++, Name = "Çay Makinesi                             " });
            builder.HasData(new Catagory { Id = index++, Name = "Tost Makinesi                            " });
            builder.HasData(new Catagory { Id = index++, Name = "Waffle Makinesi                          " });
            builder.HasData(new Catagory { Id = index++, Name = "Tartı                                    " });
            builder.HasData(new Catagory { Id = index++, Name = "Giyilebilir Teknoloji                    " });
            builder.HasData(new Catagory { Id = index++, Name = "Akıllı Saat                              " });
            builder.HasData(new Catagory { Id = index++, Name = "Akıllı Bileklik                          " });
            builder.HasData(new Catagory { Id = index++, Name = "Telefon                                  " });
            builder.HasData(new Catagory { Id = index++, Name = "Cep Telefonu                             " });
            builder.HasData(new Catagory { Id = index++, Name = "Kapak & Kılıf                            " });
            builder.HasData(new Catagory { Id = index++, Name = "Şarj Cihazları                           " });
            builder.HasData(new Catagory { Id = index++, Name = "Powerbank                                " });
            builder.HasData(new Catagory { Id = index++, Name = "Bilgisayar & Tablet                      " });
            builder.HasData(new Catagory { Id = index++, Name = "Laptop                                   " });
            builder.HasData(new Catagory { Id = index++, Name = "Tablet                                   " });
            builder.HasData(new Catagory { Id = index++, Name = "Bilgisayar Bileşenleri                   " });
            builder.HasData(new Catagory { Id = index++, Name = "Monitör                                  " });
            builder.HasData(new Catagory { Id = index++, Name = "Yazıcı & Tarayıcı                        " });
            builder.HasData(new Catagory { Id = index++, Name = "Çevre Birimleri                          " });
            builder.HasData(new Catagory { Id = index++, Name = "Ağ & Modem                               " });
            builder.HasData(new Catagory { Id = index++, Name = "TV & Görüntü & Ses                       " });
            builder.HasData(new Catagory { Id = index++, Name = "Televizyon                               " });
            builder.HasData(new Catagory { Id = index++, Name = "Soundbar                                 " });
            builder.HasData(new Catagory { Id = index++, Name = "Projeksiyon Cihazı                       " });
            builder.HasData(new Catagory { Id = index++, Name = "Media Player                             " });
            builder.HasData(new Catagory { Id = index++, Name = "Hoparlör                                 " });
            builder.HasData(new Catagory { Id = index++, Name = "Kulaklık                                 " });
            builder.HasData(new Catagory { Id = index++, Name = "Kişisel Bakım Aletleri                   " });
            builder.HasData(new Catagory { Id = index++, Name = "Saç Düzleştirici                         " });
            builder.HasData(new Catagory { Id = index++, Name = "Tıraş Makinesi                           " });
            builder.HasData(new Catagory { Id = index++, Name = "Saç Maşası                               " });
            builder.HasData(new Catagory { Id = index++, Name = "Saç Kurutma Makinesi                     " });
            builder.HasData(new Catagory { Id = index++, Name = "Epilasyon Aleti                          " });
            builder.HasData(new Catagory { Id = index++, Name = "Beyaz Eşya                               " });
            builder.HasData(new Catagory { Id = index++, Name = "Buzdolabı                                " });
            builder.HasData(new Catagory { Id = index++, Name = "Çamaşır Makinesi                         " });
            builder.HasData(new Catagory { Id = index++, Name = "Bulaşık Makinesi                         " });
            builder.HasData(new Catagory { Id = index++, Name = "Ankastre                                 " });
            builder.HasData(new Catagory { Id = index++, Name = "Derin Dondurucu                          " });
            builder.HasData(new Catagory { Id = index++, Name = "Klima                                    " });
            builder.HasData(new Catagory { Id = index++, Name = "Kombi                                    " });
            builder.HasData(new Catagory { Id = index++, Name = "Elektronik Aksesuarlar                   " });
            builder.HasData(new Catagory { Id = index++, Name = "Bilgisayar Aksesuar                      " });
            builder.HasData(new Catagory { Id = index++, Name = "Telefon Aksesuarları                     " });
            builder.HasData(new Catagory { Id = index++, Name = "TV Aksesuarları                          " });
            builder.HasData(new Catagory { Id = index++, Name = "Veri Depolama                            " });
            builder.HasData(new Catagory { Id = index++, Name = "Oyunculara Özel                          " });
            builder.HasData(new Catagory { Id = index++, Name = "Playstation                              " });
            builder.HasData(new Catagory { Id = index++, Name = "Xbox                                     " });
            builder.HasData(new Catagory { Id = index++, Name = "Nintendo                                 " });
            builder.HasData(new Catagory { Id = index++, Name = "Playstation Oyunları                     " });
            builder.HasData(new Catagory { Id = index++, Name = "Konsol Aksesuarları                      " });
            builder.HasData(new Catagory { Id = index++, Name = "Oyuncu Bilgisayarı                       " });
            builder.HasData(new Catagory { Id = index++, Name = "Oyuncu Donanımları                       " });
            builder.HasData(new Catagory { Id = index++, Name = "Oyuncu Monitörleri                       " });
            builder.HasData(new Catagory { Id = index++, Name = "Foto & Kamera                            " });
            builder.HasData(new Catagory { Id = index++, Name = "Aksiyon Kamera                           " });
        }
        public List<Product> list { get; set; }
       
    }
}
