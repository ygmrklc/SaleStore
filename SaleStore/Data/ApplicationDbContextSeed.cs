﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SaleStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleStore.Data
{
    public static class ApplicationDbContextSeed
    {
        public static void Seed(this ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<Role> roleManager)
        {
            // migration'ları veritabanına uygula
            context.Database.Migrate();

            // Perform seed operations
            AddCompanies(context);
            AddCategories(context);
            AddCampaigns(context);
            AddProducts(context);
            AddSettings(context);
            AddUsers(userManager);
            AddRoles(roleManager);
            AddRoleToUser(userManager);
        }
        public static void AddProducts(ApplicationDbContext context)
        {
            context.AddRange(
                
                new Product
                {
                    Name = "iPhone 7",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId =1,
                    CategoryId = 1,
                    Details= "iPhone 7, inovasyon ve işçiliği yepyeni bir boyuta taşıyor. Yeni simsiyah gövdesi şimdiye dek tasarladığımız her şeyden çok daha farklı. Kasası suya ve sıçramalara dayanıklı. Ana Ekran düğmesi tamamen yeni. Ve kusursuz hatlara sahip yeni unibody tasarımı sadece mükemmel görünmekle kalmıyor, aynı zamanda mükemmel bir his veriyor.",
                    ProductImage= "http://s2.turkcell.com.tr/SiteAssets/Cihaz/cep-telefonu/apple/7/cg/1/1_600x450.png",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice= 3509,
                    UnitPrice=4000,
                    IsPublish = true
                },
                new Product
                {
                    Name = "Emporio Armani",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 2,
                    Details = "Kadın Kol Saati AR1925",
                    ProductImage = "https://img-trendyol.mncdn.com/mnresize/415/622//Assets/ProductImages/59934/4053858564015_1_org_zoom.jpg",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 1099,
                    UnitPrice = 1999,
                    IsPublish = true
                },
                new Product
                {
                    Name = "Versatil Kalem",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 3,
                    Details = "Rotring 600 0.5 mm ",
                    ProductImage = "http://akakce.cubecdn.net/rotring/rotring-600-0-5-mm-versatil-kalem-x.jpg",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 76,
                    UnitPrice = 90,
                    IsPublish = true
                },
                new Product
                {
                    Name = "KAMP ÇADIR",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 4,
                    Details = "4 MEVSİM ÜÇ KİŞİLİK KAMP ÇADIR TENTE SİNEKLİK",
                    ProductImage = "http://cdn3.n11.com.tr/a1/450/16/05/10/77/52/79/80/75/10/06/59/77/48792277696570833434.jpg",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 59,
                    UnitPrice = 89,
                    IsPublish = true
                },
                new Product
                {
                    Name = "Calvin Klein",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 5,
                    Details = "In2U Edt 50 ml Erkek Parfümü 088300196920",
                    ProductImage = "https://img-trendyol.mncdn.com/mnresize/415/622//Assets/ProductImages/58466-4/088300196920_1_org_zoom.jpg",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 49,
                    UnitPrice = 150,
                    IsPublish = true
                },
                new Product
                {
                    Name = "Nutuk",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 6,
                    Details = "Kurtuluş savaşının öyküsü.",
                    ProductImage = "http://i.dr.com.tr/cache/600x600-0/originals/0000000176499-1.jpg",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 5,
                    UnitPrice = 10,
                    IsPublish = true
                },
                new Product
                {
                    Name = "Cioccolata",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 7,
                    Details = "Beyaz Erkek Çocuk T-shirt 3232CIC1538",
                    ProductImage = "https://img-trendyol.mncdn.com/mnresize/1200/1800//Assets/ProductImages/159966-1/5679074244983_1_org_zoom.jpg",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 11,
                    UnitPrice = 29,
                    IsPublish = true
                },
                new Product
                {
                    Name = "COLUMBIA",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 8,
                    Details = "Şok Emici Eva Taban",
                    ProductImage = "https://1v1y3.cubecdn.net/1280/1680/Product/17799481-e463-4078-af67-e13c4680787f.jpg",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 259,
                    UnitPrice = 399,
                    IsPublish = true
                },

                new Product
                {
                    Name = "ANTEP FISTIKLI BALLI SARMA",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 9,
                    Details = "1 KG - ANTEP FISTIKLI BALLI SARMA - ÇEREZCİ İBRAHİM",
                    ProductImage = "https://mcdn01.gittigidiyor.net/28570/tn50/285702059_tn50_0.jpg?1496935751",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 32,
                    UnitPrice = 49,
                    IsPublish = true
                },
                new Product
                {
                    Name = "İncili Çatal İğne Sallantılı Küpe",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CompanyId = 1,
                    CategoryId = 10,
                    Details = "SS 17 % 45 BAKIR % 35 CAM % 15 KRİSTAL % 5 DEMİR",
                    ProductImage = "https://st-twist.cdnrnd.com/twist/mnresize/2048/2048/Content/media/ProductImg/original/636262035668920111.JPG",
                    SaleStarthDate = DateTime.Now,
                    SaleEndDate = DateTime.Now,
                    SalePrice = 15,
                    UnitPrice = 29,
                    IsPublish = true
                }



                   );

            context.SaveChanges();
        }
        public static void AddCampaigns(ApplicationDbContext context)
        {
            context.AddRange(

                new Campaign
                {
                    Name = "TEKNOSACELL ESKİ TELEFONUNU GETİR YENİSİNİ İNDİRİMLE GÖTÜR",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CampaignStartDate = DateTime.Now,
                    CampaignEndDate = DateTime.Now,
                    CategoryId = 1,
                    Slogan = "Telefonları yenileme zamanı",
                    Image = "uploads/6-2017-CampaignImages/m1.png",
                    Description = "İkinci el ürünler TECHPOİNT SERVİS HİZMETLERİ A.Ş. adına Teknosa tarafından teslim alınmakta olup, ikinci el cihaz bedeli karşılığında verilen hediye çeki ilgili firma tarafından karşılanmaktadır.",
                    IsPublish = true
                },
                new Campaign
                {
                    Name = "RENGARENK BAY VE BAYAN JEAN SAAT KOT SAAT",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CampaignStartDate = DateTime.Now,
                    CampaignEndDate = DateTime.Now,
                    CategoryId = 2,
                    Slogan = "AYNI GÜN ÜCRETSİZ KARGO + HEDİYE PAKETİ",
                    Image = "uploads/6-2017-CampaignImages/m1.png",
                    Description = "AYNI GÜN İÇERİSİNDE DÜKKANIMIZDAN VERMİŞ OLDUĞUNUZ TÜM SİPARİŞLER TEK BİR KARGO İLE GÖNDERİLMEKTEDİR.",
                    IsPublish = true
                },
                new Campaign
                {
                    Name = "Seçili projeksiyon aletlerinde",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CampaignStartDate = DateTime.Now,
                    CampaignEndDate = DateTime.Now,
                    CategoryId = 3,
                    Slogan = "Sepete %15 indirim",
                    Image = "https://images.hepsiburada.net/assets/storefront/banners/02-06-2017_1496402190703_1.png",
                    Description = "Satıcı hepsiburada olan ürünlerde geçerlidir.",
                    IsPublish = true
                },
                new Campaign
                {
                    Name = "Holiday Inn Istanbul Airport Mandala'da Fitness Üyeliklerini Kaçırmayın!",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CampaignStartDate = DateTime.Now,
                    CampaignEndDate = DateTime.Now,
                    CategoryId = 4,
                    Slogan = "Spor ve dinginliğe dair her şey!",
                    Image = "http://www.firsat10.com/photos/v2/53/05/285305_400.jpg",
                    Description = "1 Aylık Fitness + 600 TL Yerine 150 TL 3 Aylık Fitness + 1 Seans Kese - Köpük Masaj 1320 TL Yerine 300 TL 6 Aylık Fitness + 2 Seans Kese - Köpük Masaj 2200 TL Yerine 500 TL",
                    IsPublish = true
                },
                new Campaign
                {
                    Name = "Parfümde yaz fırsatı",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CampaignStartDate = DateTime.Now,
                    CampaignEndDate = DateTime.Now,
                    CategoryId = 5,
                    Slogan = "%80'e varan indirimler",
                    Image = "https://img-trendyol.mncdn.com//Assets/ProductImages/050617/parfum_080617_new.jpg",
                    Description = "En iyi kadın ve erkek parfümlerinin yer aldığı dünyaca ünlü, Burberry, Chanel, Tom Ford, Bvlgari, Estee Lauder, Calvin Klein ve diğer markaların en çok satan ürünlerinden oluşan bu kampanya, aradığınız tüm parfümleri özel indirimlerle size sunuyor. Bu orijinal parfümlere, size özel indirim fırsatları ile sahip olma fırsatını kaçırmayın!",
                    IsPublish = true
                },
                new Campaign
                {
                    Name = "Herkes okusun diye",
                    CreatedBy = "username",
                    CreateDate = DateTime.Now,
                    UpdatedBy = "username",
                    UpdateDate = DateTime.Now,
                    CampaignStartDate = DateTime.Now,
                    CampaignEndDate = DateTime.Now,
                    CategoryId = 6,
                    Slogan = "Bu Kitaplar 9,90 TL",
                    Image = "http://i.dr.com.tr/pimages/Content/Uploads/CampaignBanners/dr/herkesokusundiyeyeniolcu.jpg",
                    Description = "Kampanya 1-30 Haziran arasında www.dr.com.tr'de ve Mağazalarımızda (D&R  kart ile alışverişlerinizde) geçerlidir. ",
                    IsPublish = true
                },
                 new Campaign
                 {
                     Name = "Philips Avent Ürünlerinde Özel Fiyatlar",
                     CreatedBy = "username",
                     CreateDate = DateTime.Now,
                     UpdatedBy = "username",
                     UpdateDate = DateTime.Now,
                     CampaignStartDate = DateTime.Now,
                     CampaignEndDate = DateTime.Now,
                     CategoryId = 7,
                     Slogan = "Philips Avent Ürünlerinde Özel Fiyatlar 1- 29 Haziran Arası",
                     Image = "https://static.joker.com.tr/images/campaign_banner/2016-12-05_avent_322x190_kutu.jpg",
                     Description = "1- 29 Haziran Arası",
                     IsPublish = true
                 },
                  new Campaign
                  {
                      Name = "D's Damat - TWN Babalar Gününe Özel",
                      CreatedBy = "username",
                      CreateDate = DateTime.Now,
                      UpdatedBy = "username",
                      UpdateDate = DateTime.Now,
                      CampaignStartDate = DateTime.Now,
                      CampaignEndDate = DateTime.Now,
                      CategoryId = 8,
                      Slogan = "3 Gömlek 89 TL - Ücretsiz Kargo",
                      Image = "http://cdn1.n11.com.tr/a1/1188_250/17/06/08/84/26/14/36/38/89/56/17/31/03108210849822783252.jpg",
                      Description = "D's Damat - TWN Babalar Gününe Özel 3 Gömlek 89 TL - Ücretsiz Kargo",
                      IsPublish = true
                  },
                   new Campaign
                   {
                       Name = "A101 15 Haziran 2017 Aldın Aldın Kampanyası",
                       CreatedBy = "username",
                       CreateDate = DateTime.Now,
                       UpdatedBy = "username",
                       UpdateDate = DateTime.Now,
                       CampaignStartDate = DateTime.Now,
                       CampaignEndDate = DateTime.Now,
                       CategoryId = 9,
                       Slogan = "Stoklarla sınırlı Aldın Aldın ürünlerinde uygun fiyatlarla A101'de...",
                       Image = "http://www.alisverisrehberi.com/haber/upload/buyuk/45169_201_a101_15_haziran_aldin_aldin_201.jpg",
                       Description = "Bu hafta 15 Haziran tarihinden itibaren Televizyon, Ev Tekstil Ürünleri, Mutfak Gereçleri ve Elektrikli El Aletlerinden oluşan onlarca üründen oluşan Aldın Aldın kampanyası bizi bekliyor.",
                       IsPublish = true
                   },
                   new Campaign
                   {
                       Name = "Olağanüstü Ses Kalitesi Sağlayan Teknoloji!",
                       CreatedBy = "username",
                       CreateDate = DateTime.Now,
                       UpdatedBy = "username",
                       UpdateDate = DateTime.Now,
                       CampaignStartDate = DateTime.Now,
                       CampaignEndDate = DateTime.Now,
                       CategoryId = 10,
                       Slogan = "Kablosuz bağlantı teknolojisiyle üstün bir ses kalitesi sunan Apple AirPods kulaklık Türk Telekom’da!",
                       Image = "https://bireysel.turktelekom.com.tr/cihazlar/PublishingImages/Aksesuar/apple-kulaklik.jpg",
                       Description = "Üstelik 3 ay boyunca Türk Telekom Müzik hediye!",
                       IsPublish = true
                   }
                   );
            context.SaveChanges();
        }


        private static ApplicationUser user;

        private static void AddUsers(UserManager<ApplicationUser> _userManager)
        {
            user = new ApplicationUser { Id = Guid.NewGuid().ToString(), UserName = "salestoredeneme@gmail.com", Email = "salestoredeneme@gmail.com", EmailConfirmed = true, NormalizedEmail = "SALESTOREDENEME@GMAİL.COM", NormalizedUserName = "SALESTOREDENEME@GMAİL.COM", CompanyId = 1 };
            var task1 = Task.Run(() => _userManager.CreateAsync(user, "123:Asdf"));
            task1.Wait();

        }

        private static void AddRoles(RoleManager<Role> _roleManager)
        {
            string[] roles = { "ADMIN" };
            string[] stamp = { "Yönetici" };

            for (int i = 0; i < roles.Count(); i++)
            {
                var role = new Role { Id = Guid.NewGuid().ToString(), Name = roles[i], NormalizedName = roles[i], ConcurrencyStamp = stamp[i] };
                var task1 = Task.Run(() => _roleManager.CreateAsync(role));
                task1.Wait();
            }
        }
        private static void AddRoleToUser(UserManager<ApplicationUser> _userManager)
        {
            var task1 = Task.Run(() => _userManager.AddToRoleAsync(user, "ADMIN"));
            task1.Wait();
        }

        public static void AddCategories(ApplicationDbContext context)
        {
            context.AddRange(
                new Category { Name = "Elektronik", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Moda-Takı", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Ev,Yaşam,Kırtasiye,Ofis", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Spor-Outdoor", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Kozmetik", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Kitap,Müzik,Film,Hobi", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Bebek Ürünleri,Oyuncaklar", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Ayakkabı-Çanta", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Gıda,Market", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now },
                new Category { Name = "Aksesuar", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now });
            context.SaveChanges();
        }
        private static void AddSettings(ApplicationDbContext context)
        {
            var s = new Setting();
            s.Logo = "";
            s.Phone = "444 55 55";
            s.Address = "Bahariye Caddesi Süleymanpaşa Sokak No:2";
            s.Mail = "salestore@gmail.com";
            s.SiteSlogan = "Herşeyi indirdik sizi bekliyoruz";
            s.About = "EN kaliteli ürünleri EN uygun fiyatlarla bulmanın en kolay yolu";
            s.Title = "EN kaliteli ürünleri EN uygun fiyatlarla bulmanın en kolay yolu";
            s.SeoTitle = "EN kaliteli ürünleri EN uygun fiyatlarla bulmanın en kolay yolu";
            s.SeoDescription = "EN kaliteli ürünleri EN uygun fiyatlarla bulmanın en kolay yolu";
            s.SeoKeywords = "shop,alışveriş,ucuzu,indirim,en uygun fiyat,ürün,eşya,beyaz eşya,elektronik,ev aletleri,bebek ürünleri";
            s.Facebook = "";
            s.Twitter = "";
            s.LinkedIn = "";
            s.CreateDate = DateTime.Now;
            s.CreatedBy = "username";
            s.UpdateDate = DateTime.Now;
            s.UpdatedBy = "username";
            context.Setting.Add(s);
            context.SaveChanges();
        }

        public static void AddCompanies(ApplicationDbContext context)
        {
            context.AddRange(
                new Company { Name = "OnKa Yazılım", Address = "Kadıköy", Phone = "01234567899", Logo = "/images/logo.png", CreatedBy = "username", CreateDate = DateTime.Now, UpdatedBy = "username", UpdateDate = DateTime.Now });
                
            context.SaveChanges();
        }
    }
}
