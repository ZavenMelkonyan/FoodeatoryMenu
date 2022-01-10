using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.SushiUA
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> maki = new List<Product>();

            maki.Add(new Product { Name = "Рол Філадельфія 275г", NameEng = "Philadelphia Salmon 275g", PicPath = "/Resources/SushiUA/1 whole.jpg", Description = "Рис, сир, огірок, лосось, норі", DescriptionEng = "Rice, cheese, cucumber, salmon, nori " });
            maki.Add(new Product { Name = "Рол Філадельфія Вугор 275г", NameEng = "Philadelphia Eel 275g", PicPath = "/Resources/SushiUA/2 whole.jpg", Description = "Рис, сир, огірок, вугор, норі", DescriptionEng = "Rice, cheese, cucumber, eel, nori " });
            maki.Add(new Product { Name = "Рол Філадельфія Тунець 275г", NameEng = "Philadelphia Tuna 275g", PicPath = "/Resources/SushiUA/3 whole.jpg", Description = "Рис, сир, огірок, тунець, норі", DescriptionEng = "Rice, cheese, cucumber, tuna, nori " });
            maki.Add(new Product { Name = "Рол Каліфорнія Лосось 230г", NameEng = "California Salmon 230g", PicPath = "/Resources/SushiUA/4 whole.jpg", Description = "Рис, авокадо, огірок, лосось, норі, кунжут", DescriptionEng = "Rice, avocado, cucumber, salmon, nori, sesame" });
            maki.Add(new Product { Name = "Рол Каліфорнія Краб 230г", NameEng = "California Crab 230g", PicPath = "/Resources/SushiUA/5 whole.jpg", Description = "Рис, авокадо, огірок, краб-мікс, норі, Тобіко", DescriptionEng = "Rice, avocado, cucumber, crab mix, nori, tobiko" });
            maki.Add(new Product { Name = "Рол Каліфорнія Тунець 230г", NameEng = "California Tuna 230g", PicPath = "/Resources/SushiUA/6 2 wholce.jpg", Description = "Рис, авокадо, огірок, тунець, норі, Тобіко", DescriptionEng = "Rice, avocado, cucumber, tuna, nori, tobiko" });
            maki.Add(new Product { Name = "Макі Огірок 120г", NameEng = "Maki cucumber 120g", PicPath = "/Resources/SushiUA/7 whole.jpg", Description = "Рис, норі, огірок", DescriptionEng = "Rice, nori, cucucmber" });
            maki.Add(new Product { Name = "Макі Авокадо 120г", NameEng = "Maki Avocado 120g", PicPath = "/Resources/SushiUA/8 whole.jpg", Description = "Рис, норі, авокадо", DescriptionEng = "Rice, nori, avocado" });
            maki.Add(new Product { Name = "Макі Креветка 120г", NameEng = "Maki Shrimp 120g", PicPath = "/Resources/SushiUA/9 whole.jpg", Description = "Рис, норі, креветка", DescriptionEng = "Rice, nori, shrimp" });
            maki.Add(new Product { Name = "Макі Лосось 120г", NameEng = "Maki Salmon 120g", PicPath = "/Resources/SushiUA/10 whole.jpg", Description = "Рис, норі, лосось", DescriptionEng = "Rice, nori, salmon" });
            maki.Add(new Product { Name = "Макі Тунець 120г", NameEng = "Maki Tuna 120g", PicPath = "/Resources/SushiUA/11 whole .jpg", Description = "Рис, норі, тунець", DescriptionEng = "Rice, nori, tuna" });
            maki.Add(new Product { Name = "Макі Вугор 120г", NameEng = "Maki Eel 120g", PicPath = "/Resources/SushiUA/12 whole.jpg", Description = "Рис, норі, вугор", DescriptionEng = "Rice, nori, eel" });
            maki.Add(new Product { Name = "Нігірі Лосось 40г", NameEng = "Salmon nigiri 40g", PicPath = "/Resources/SushiUA/13.jpg", Description = "Рис, лосось", DescriptionEng = "Rice, salmon" });
            maki.Add(new Product { Name = "Нігірі Тунець 40г", NameEng = "Tuna nigiri 40g", PicPath = "/Resources/SushiUA/14.jpg", Description = "Рис, тунець", DescriptionEng = "Rice, tuna" });
            maki.Add(new Product { Name = "Нігірі Вугор 40г", NameEng = "Eel nigiri 40g", PicPath = "/Resources/SushiUA/15.jpg", Description = "Рис, вугор, унаг, кунжут", DescriptionEng = "Rice, eel" });
            maki.Add(new Product { Name = "Нігірі Креветка 40г", NameEng = "Shrimp nigiri 40g", PicPath = "/Resources/SushiUA/16.jpg", Description = "Рис, креветка", DescriptionEng = "Rice, shrimp" });
            maki.Add(new Product { Name = "Гункан Лосось 40г", NameEng = "Salmon gunkan 40g", PicPath = "/Resources/SushiUA/17.jpg", Description = "Рис, заміс лосося", DescriptionEng = "Rice, salmon mix" });
            maki.Add(new Product { Name = "Гункан Тунець 40г", NameEng = "Tuna gunkan 40g", PicPath = "/Resources/SushiUA/18.jpg", Description = "Рис, заміс тунець", DescriptionEng = "Rice, tuna mix" });
            maki.Add(new Product { Name = "Гункан Вугор 40г", NameEng = "Eel gunkan 40g", PicPath = "/Resources/SushiUA/19.jpg", Description = "Рис, заміс вугор", DescriptionEng = "Rice, eel mix" });
            maki.Add(new Product { Name = "Гункан Креветка 40г", NameEng = "Shrimp gunkan 40g", PicPath = "/Resources/SushiUA/20.jpg", Description = "Рис, заміс креветка", DescriptionEng = "Rice, shrimp mix" });
            maki.Add(new Product { Name = "Зелений Дракон 275г", NameEng = "Green Dragon 275g", PicPath = "/Resources/SushiUA/22 whole.jpg", Description = "Рис, вугор, тобі, Авокадо, Норі, Унагі, кунжут, омлет Томага", DescriptionEng = "Rice, eel, tobi, avocado, nori, unagi sesame, omelet tomago" });
            maki.Add(new Product { Name = "Рол Дракон 255г", NameEng = "Dragon 255g", PicPath = "/Resources/SushiUA/23 whole .jpg", Description = "Рис, вугор, Томаго, авокадо, манго+ унагі, кунжут", DescriptionEng = "Rice, avocado, tomago, eel, mango, unagi, sesame" });
            maki.Add(new Product { Name = "Рол Червоний Дракон 250г", NameEng = "Red Dragon 250g", PicPath = "/Resources/SushiUA/24 whole.jpg", Description = "Рис, авокадо, огірок, тунець, лосось, японський майонез", DescriptionEng = "Rice, avocado, cucumber, tuna, salmon, japanese mayonnaise" });
            maki.Add(new Product { Name = "Рол Рейнбол 235г", NameEng = "Rainbow 235g", PicPath = "/Resources/SushiUA/25 whole.jpg", Description = "Рис, огірок, краб мікс, лосось, тунець, вугор, авокадо", DescriptionEng = "Rice, cucumber, crab mix, salmon, tuna, eel, avicado" });
            maki.Add(new Product { Name = "Рол Футомак 200г", NameEng = "Futomak 200g", PicPath = "/Resources/SushiUA/26 whole.jpg", Description = "Рис, яблуко, манго, авокадо, лоло, світ - чілі ", DescriptionEng = "Rice, apple, mango, avocado, lolo, sweet chili" });
            maki.Add(new Product { Name = "Рол Темпура Лосось-Базилік 200г", NameEng = "Tempura Salmon Basil 200g", PicPath = "/Resources/SushiUA/27 whole.jpg", Description = "Рис, лосось, сир, базилік, унагі, кунжут", DescriptionEng = "Rice, salmon, cheese, basil, unagi, sesame" });
            maki.Add(new Product { Name = "Рол Абурі 265г", NameEng = "Aburi 265g", PicPath = "/Resources/SushiUA/28 whole.jpg", Description = "Рис, сир, лосось, лимонна цедра, унагі, огірок, авокадо", DescriptionEng = "Rice, cheese, salmon, zest, unagi, cucumber, avocado" });
            maki.Add(new Product { Name = "Рол Боніто 225г", NameEng = "Bonito 225g", PicPath = "/Resources/SushiUA/29 whole.jpg", Description = "Рис, огірок, авокадо, лосось, стружка тунця, соус спайсі", DescriptionEng = "Rice, cucumber, avocado, salmon, tuna shavings, Spicy sauce" });
            maki.Add(new Product { Name = "Рол Чеддер 200г", NameEng = "Cheddar 200g", PicPath = "/Resources/SushiUA/30 whole.jpg", Description = "Рис, темпурна креветка, огірок, соус спайсі, чеддер", DescriptionEng = "Rice, shrimp, cucumber, spicy sauce, cheddar" });
            maki.Add(new Product { Name = "Рол Філадельфія Лосось-Вугор 275г", NameEng = "Philadelphia Salmon-Eel 275g", PicPath = "/Resources/SushiUA/31 whole.jpg", Description = "Рис, сир, огірок, лосось, вугор, унагі, кунжут", DescriptionEng = "Rice, cucumber, cheese, salmon, eel, unagi, sesame" });
            maki.Add(new Product { Name = "Рол Каліфорнія Темпура 235г", NameEng = "California Tempura 235g", PicPath = "/Resources/SushiUA/32 whole.jpg", Description = "Рис, огірок, авокадо, лосось, кляр,сухарі панко, унагі, спайсі", DescriptionEng = "Rice, cucumber, avocado, salmon,breadcrumbs,unagi, spicy " });
            maki.Add(new Product { Name = "Рол Філадельфія Креветка 275г", NameEng = "Philadelphia Shrimp 275g", PicPath = "/Resources/SushiUA/34 whole.jpg", Description = "Рис, сир, огірок, креветка, унагі, світ чілі", DescriptionEng = "Rice, cheese, cucumber, shrimp, unagi, sweet chili" });
            maki.Add(new Product { Name = "Рол Вугор Темпура 205г", NameEng = "Tempura Eel 205g", PicPath = "/Resources/SushiUA/36 whole.jpg", Description = "Рис, Тобіко, вугор, огірок,соус сир", DescriptionEng = "Rice, tobiko, eel, cucumber, cheese sauce" });
            maki.Add(new Product { Name = "Рол Темпура Класік 125г", NameEng = "Tempura Classic 125g", PicPath = "/Resources/SushiUA/37 whole.jpg", Description = "Рис, сир, авокадо, лосось", DescriptionEng = "Rice, cheese, avocado, salmon" });
            maki.Add(new Product { Name = "Рол Запечений Лосось 235г", NameEng = "Baked Salmon 235g", PicPath = "/Resources/SushiUA/38 whole.jpg", Description = "Рис, огірок, айсберг, Смажений лосось, заміс", DescriptionEng = "Rice, cucumber, iceberg, fried salmon, mix" });
            maki.Add(new Product { Name = "Сет  Філадельфія 1100г", NameEng = "Phila Set 1100g", PicPath = "/Resources/SushiUA/40.jpg", Description = "Філадельфія Лосось,Філадельфія Тунець, Філадельфія вугор, Філадельфія Креветка", DescriptionEng = "Philadelphia Salmon, Philadelphia Tuna, Philadelphia Eel, Philadelphia Shrimp" });
            maki.Add(new Product { Name = "Сет Каліфорнія 690г", NameEng = "California Set 690g", PicPath = "/Resources/SushiUA/41.jpg", Description = "Каліфорнія Лосось, Каліфорнія Тунець, Каліфорнія Краб", DescriptionEng = "California Salmon, California Tuna, California Crab" });
            maki.Add(new Product { Name = "Сет Мікс 1675г", NameEng = "Set Mix 1675g", PicPath = "/Resources/SushiUA/42.jpg", Description = "Темпура Лосось-Базилік, Боніто, Чеддер, Абурі, Зелений Дракон, Каліфорнія Темпура Лосось, Філадельфія Лосось-Вугор", DescriptionEng = "Tempura Salmon Basil, Bonito, Cheddar, Aburi, Green Dragon, California Tempura Salmon, Philadelphia Salmon-Eel" });


            categories.Add(new Categorie { Name = "Макі", NameEng = "Maki", Products = maki, CategoriePic = "/Resources/Steak/Cover/սթեյք.jpg" });


        }
    }
}
