using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.Bar
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> lemonade = new List<Product>();
            lemonade.Add(new Product { Name = "Mint, lime, cucumber", NameArm = "Նանա, լայմ և վարունգ", NameRus = "Мята, лайм, огурец", Price = "390", PicPath = "/Resources/Bar/mint lime cucumber lemonade.jpg" });
            lemonade.Add(new Product { Name = "Melissa, lime, raspberries", NameArm = "Մելիսա, լայմ և ազնվամորի", NameRus = "Мелисса, лайм, малина", Price = "450", PicPath = "/Resources/Bar/melissa, lime, raspberry lemonade.jpg" });
            lemonade.Add(new Product { Name = "Tarragon and lime", NameArm = "Թարխուն և լայմ", NameRus = "Эстрагон и лайм", Price = "350", PicPath = "/Resources/Bar/Tarragon and lime lemonade.jpg" });
            lemonade.Add(new Product { Name = "Basil, lime, berries", NameArm = "Ռեհան, լայմ և հատապտուղներ", NameRus = "Базилик, лайм, ягоды", Price = "450", PicPath = "/Resources/Bar/basil, lime, berries lemonade.jpg" });
            lemonade.Add(new Product { Name = "Basil and lime", NameArm = "Ռեհան և լայմ", NameRus = "Базилик и лайм", Price = "350", PicPath = "/Resources/Bar/basil and lime lemonade.jpg" });
            lemonade.Add(new Product { Name = "Melissa and lime", NameArm = "Մելիսա և լայմ", NameRus = "Мелисса и лайм", Price = "390", PicPath = "/Resources/Bar/melissa and lime lemonade.jpg" });
            lemonade.Add(new Product { Name = "Mint, lime, berries", NameArm = "Նանա, լայմ և հատապտուղներ", NameRus = "Мята, лайм, ягоды", Price = "450", PicPath = "/Resources/Bar/mint lime berrries lemonadejpg.jpg" });
            lemonade.Add(new Product { Name = "Lemon, strawberry, ginger", NameArm = "Կիտրոն, ելակ և կոճապղպեղ", NameRus = "Лимон, клубника, имбирь", Price = "450", PicPath = "/Resources/Bar/lemon, strawberry, ginger lemonade.jpg" });
            lemonade.Add(new Product { Name = "Karkade", NameArm = "Կարկադե", NameRus = "Каркаде", Price = "350", PicPath = "/Resources/Bar/karkade lemonade.jpg" });
            lemonade.Add(new Product { Name = "Mojito", NameArm = "Մոխիտո", NameRus = "Мохито", Price = "550", PicPath = "/Resources/Bar/mojito.jpg" });
            lemonade.Add(new Product { Name = "Mandarin", NameArm = "Մանդարին", NameRus = "Мандарин", Price = "450", PicPath = "/Resources/Bar/mandarin lemonade.jpg" });
            lemonade.Add(new Product { Name = "Orange", NameArm = "Նարինջ", NameRus = "Апельсин", Price = "450", PicPath = "/Resources/Bar/orange lemonade.jpg" });
            lemonade.Add(new Product { Name = "Kiwi", NameArm = "Կիվի", NameRus = "Киви", Price = "350", PicPath = "/Resources/Bar/kiwi lemonade.jpg" });
            lemonade.Add(new Product { Name = "Pomegranate", NameArm = "Նուռ", NameRus = "Гранат", Price = "450", PicPath = "/Resources/Bar/pomegranate lemonadejpg.jpg" });
            lemonade.Add(new Product { Name = "Grapefruit", NameArm = "Թուրինջ", NameRus = "Грейпфрут", Price = "390", PicPath = "/Resources/Bar/grapefurit lemonade.jpg" });
            lemonade.Add(new Product { Name = "Citrus", NameArm = "Ցիտրուսային", NameRus = "Цитрусовый", Price = "350", PicPath = "/Resources/Bar/citrus lemonade.jpg" });


            categories.Add(new Categorie { Name = "Lemonade", NameArm = "Լիմոնադներ", NameRus = "Лимонады", Products = lemonade });


            List<Product> Cocktailandmilkshake = new List<Product>();
            Cocktailandmilkshake.Add(new Product { Name = "Avocado and pistachio", NameArm = "Ավոկադո և պիստակ", NameRus = "Авокадо и фисташки", Price = "1450", PicPath = "/Resources/Bar/avocado and pistachio.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Avocado, ginger and orange", NameArm = "Ավոկադո, կոճապղպեղ և նարինջ", NameRus = "Авокадо, имбирь и апельсин", Price = "1200", PicPath = "/Resources/Bar/avocado, ginger, orance.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Avocado, flax and yogurt", NameArm = "Ավոկադո, կտավատ և յոգուրտ", NameRus = "Авокадо, лен и йогурт", Price = "900", PicPath = "/Resources/Bar/avcado, flax, yogurt.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Banana and coffee", NameArm = "Բանան և սուրճ", NameRus = "Банан и кофе", Price = "750", PicPath = "/Resources/Bar/banana and coffee.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Banana and nutella", NameArm = "Բանան և նուտելլա", NameRus = "Банан и нутелла", Price = "1150", PicPath = "/Resources/Bar/banana and nutella.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Strawberry and ice-cream", NameArm = "Ելակ և պաղպաղակ", NameRus = "Клубника и мороженое", Price = "1150", PicPath = "/Resources/Bar/strawberry and ice cream milkshake.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Strawberry, banana and ice-cream", NameArm = "Ելակ, բանան և պաղպաղակ", NameRus = "Клубника, банан и мороженое", Price = "1200", PicPath = "/Resources/Bar/strawberry, banana, ice cream.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Berries", NameArm = "Հատապտղային", NameRus = "Ягодный", Price = "1200", PicPath = "/Resources/Bar/berries milkshake.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Banana and condensed milk", NameArm = "Բանան և խտացրած կաթ", NameRus = "Банан и сгущенное молоко", Price = "1200", PicPath = "/Resources/Bar/banana and condensed milk milkshake.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Banana and baunti", NameArm = "Բանան և բաունտի", NameRus = "Банан и баунти", Price = "1200", PicPath = "/Resources/Bar/banana and baunti milkshake.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Cocktail Freshness", NameArm = "Կոկտեյլ «Թարմություն»", NameRus = "Коктейль Свежесть", Price = "850", PicPath = "/Resources/Bar/cocktail freshness.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Banana, ice-cream and milk", NameArm = "Բանան, պաղպաղակ և կաթ", NameRus = "Банан, мороженое и молоко", Price = "700", PicPath = "/Resources/Bar/banana, ice cream and milk.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Chocolate milkshake", NameArm = "Շոկոլադե միլքշեյք", NameRus = "Шоколадный милкшейк", Price = "800", PicPath = "/Resources/Bar/chocolate milkshake.jpg" });


            categories.Add(new Categorie { Name = "Cocktail and milkshake", NameArm = "Կոկտեյլ և միլք շեյք", NameRus = "Коктейль и милкшейк", Products = Cocktailandmilkshake });


            List<Product> Smoothies = new List<Product>();
            Smoothies.Add(new Product { Name = "Strawberry", NameArm = "Ելակի ֆրեշ", NameRus = "Клубничный фреш", Price = "1500", PicPath = "/Resources/Bar/strawberry smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Orange", NameArm = "Նարնջի ֆրեշ", NameRus = "Апельсиновый фреш", Price = "650", PicPath = "/Resources/Bar/orange smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Pineapple", NameArm = "Արքայախնձորի ֆրեշ", NameRus = "Ананасовый фреш", Price = "1300", PicPath = "/Resources/Bar/pineapple smothie.jpg" });
            Smoothies.Add(new Product { Name = "Lime", NameArm = "Լայմի ֆրեշ ", NameRus = "Лаймовый фреш", Price = "1500", PicPath = "/Resources/Bar/lime smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Kiwi", NameArm = "Կիվիի ֆրեշ", NameRus = "Фреш из киви", Price = "650", PicPath = "/Resources/Bar/kiwi smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Lemon", NameArm = "Կիտրոնի ֆրեշ", NameRus = "Лимонный фреш", Price = "750", PicPath = "/Resources/Bar/lemon smoothiejpg.jpg" });
            Smoothies.Add(new Product { Name = "Apple", NameArm = "Խնձորի ֆրեշ", NameRus = "Яблочный фреш", Price = "450", PicPath = "/Resources/Bar/apple smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Banana", NameArm = "Բանանի ֆրեշ", NameRus = "Банановый фреш", Price = "550", PicPath = "/Resources/Bar/banana smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Grapefruit", NameArm = "Թուրինջի ֆրեշ", NameRus = "Грейпфрутовый фреш", Price = "700", PicPath = "/Resources/Bar/grapefruit smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Strawberry and orange", NameArm = "Ելակ, նարինջ ֆրեշ", NameRus = "Фреш из клубники и апельсина", Price = "1100", PicPath = "/Resources/Bar/strawberry and orange.jpg" });
            Smoothies.Add(new Product { Name = "Strawberry and lime", NameArm = "Ելակ, լայմ ֆրեշ", NameRus = "Фреш из клубники и лайма", Price = "1850", PicPath = "/Resources/Bar/strawberry and lime smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Mint and lime smoothie", NameArm = "Նանա, լայմ սմուզի", NameRus = "Смузи с мятой и лаймом", Price = "1400", PicPath = "/Resources/Bar/mint and lime smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Strawberry and banana", NameArm = "Ելակի և բանանի ֆրեշ", NameRus = "Фреш с клубникой и бананом", Price = "1100", PicPath = "/Resources/Bar/strawberry banana smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Raspberry and banana", NameArm = "Ազնվամորի, բանան ֆրեշ", NameRus = "Фреш с малиной и бананом", Price = "950", PicPath = "/Resources/Bar/raspberry and banana smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Grapefruit and strawberry", NameArm = "Թուրինջ, ելակ ֆրեշ", NameRus = "Фреш с грейпфрутом и клубникой", Price = "950", PicPath = "/Resources/Bar/strawbbery grapefruit smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Berries", NameArm = "Հատապտղային ֆրեշ", NameRus = "Ягодный фреш", Price = "950", PicPath = "/Resources/Bar/berries smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Orange and grapefruit smoothie", NameArm = "Նարինջ, թուրինջ սմուզի", NameRus = "Смузи из апельсина и грейпфрута", Price = "650", PicPath = "/Resources/Bar/orange and grapefruit smothie.jpg" });
            Smoothies.Add(new Product { Name = "Banana and orange smoothie", NameArm = "Բանան, նարինջ սմուզի", NameRus = "Смузи с банана и апельсина", Price = "650", PicPath = "/Resources/Bar/banana and orange smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Pineapple, orange, strawberry", NameArm = "Անանաս, նարինջ, ելակ", NameRus = "Ананас, апельсин, клубника", Price = "1150", PicPath = "/Resources/Bar/pineapple, orange, strawberry smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Pineapple, lemon, ginger", NameArm = "Անանաս, կիտրոն, կոճապղպեղ", NameRus = "Ананас, лимон, имбирь", Price = "1150", PicPath = "/Resources/Bar/pineapple, lemon, ginger moothie.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed pomegranate juice", NameArm = "Թարմ քամած նռան հյութ", NameRus = "Свежевыжатый гранатовый сок", Price = "1600", PicPath = "/Resources/Bar/freshly squeezed pomegranate juice.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed orange juice", NameArm = "Թարմ քամած նարնջի հյութ", NameRus = "Свежевыжатый апельсиновый сок", Price = "850", PicPath = "/Resources/Bar/freshly squeezed orange juice.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed grapefruit juice", NameArm = "Թարմ քամած թուրինջի հյութ", NameRus = "Свежевыжатый грейпфрутовый сок", Price = "1200", PicPath = "/Resources/Bar/freshly squeezed grapefruit.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed apple juice", NameArm = "Թարմ քամած խնձոր", NameRus = "Свежевыжатый яблочный сок", Price = "700", PicPath = "/Resources/Bar/freshly squeezed apple.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed lemon juice", NameArm = "Թարմ քամած կիտրոն", NameRus = "Свежевыжатый лимонный сок", Price = "950", PicPath = "/Resources/Bar/freshy squeezed lemon juice.jpg" });


            categories.Add(new Categorie { Name = "Smoothies", NameArm = "Ֆրեշ և սմուզի", NameRus = "Фреш и смузи", Products = Smoothies });


            List<Product> Coffee = new List<Product>();
            Coffee.Add(new Product { Name = "Frappe", NameArm = "Սուրճ ֆրապպե", NameRus = "Кофе-фраппе", Price = "550", PicPath = "/Resources/Bar/frappe.jpg" });
            Coffee.Add(new Product { Name = "Glacé", NameArm = "Սուրճ գլյասե", NameRus = "Глясе", Price = "650", PicPath = "/Resources/Bar/glace.jpg" });
            Coffee.Add(new Product { Name = "Hot chocolate", NameArm = "Սուրճ տաք շոկոլադ", NameRus = "Горячий шоколад", Price = "250", PicPath = "/Resources/Bar/hot chocolate.jpg" });
            Coffee.Add(new Product { Name = "Espresso", NameArm = "Էսպրեսսո", NameRus = "Эспрессо", Price = "550", PicPath = "/Resources/Bar/espresso.jpg" });
            Coffee.Add(new Product { Name = "Americano", NameArm = "Ամերիկանո", NameRus = "Американо", Price = "550", PicPath = "/Resources/Bar/Americano.jpg" });
            Coffee.Add(new Product { Name = "Capuccino", NameArm = "Կապուչինո", NameRus = "Капучино", Price = "550", PicPath = "/Resources/Bar/capuccino.jpg" });
            Coffee.Add(new Product { Name = "Double espresso", NameArm = "Կրկնակի էսպրեսսո", NameRus = "Двойной Эспрессо", Price = "750", PicPath = "/Resources/Bar/double espresso.jpg" });
            Coffee.Add(new Product { Name = "Double Americano", NameArm = "Կրկնակի Ամերիկանո", NameRus = "Двойной Американо", Price = "750", PicPath = "/Resources/Bar/no_image.jpg" });
            Coffee.Add(new Product { Name = "Americano with milk", NameArm = "Ամերիկանո կաթով", NameRus = "Американо с молоком", Price = "650", PicPath = "/Resources/Bar/Americano with milk.jpg" });


            categories.Add(new Categorie { Name = "Coffee", NameArm = "Սուրճ", NameRus = "Кофе", Products = Coffee });

        }
    }
}
