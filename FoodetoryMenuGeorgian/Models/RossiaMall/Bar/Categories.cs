using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.RossiaMall.Bar
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> lemonade = new List<Product>();
            lemonade.Add(new Product { Name = "Karkade", NameArm = "Կարկադե", NameRus = "Каркаде", Price = "350", PicPath = "/Resources/Bar/karkade lemonade.jpg" });
            lemonade.Add(new Product { Name = "Mojito", NameArm = "Մոխիտո", NameRus = "Мохито", Price = "550", PicPath = "/Resources/Bar/mojito.jpg" });
            lemonade.Add(new Product { Name = "Mandarin", NameArm = "Մանդարին", NameRus = "Мандарин", Price = "450", PicPath = "/Resources/Bar/mandarin lemonade.jpg" });
            lemonade.Add(new Product { Name = "Orange", NameArm = "Նարինջ", NameRus = "Апельсин", Price = "450", PicPath = "/Resources/Bar/orange lemonade.jpg" });
            lemonade.Add(new Product { Name = "Kiwi", NameArm = "Կիվի", NameRus = "Киви", Price = "350", PicPath = "/Resources/Bar/kiwi lemonade.jpg" });
            lemonade.Add(new Product { Name = "Pomegranate", NameArm = "Նուռ", NameRus = "Гранат", Price = "450", PicPath = "/Resources/Bar/pomegranate lemonadejpg.jpg" });
            lemonade.Add(new Product { Name = "Grapefruit", NameArm = "Թուրինջ", NameRus = "Грейпфрут", Price = "390", PicPath = "/Resources/Bar/grapefurit lemonade.jpg" });
            lemonade.Add(new Product { Name = "Citrus", NameArm = "Ցիտրուսային", NameRus = "Цитрусовый", Price = "350", PicPath = "/Resources/Bar/citrus lemonade.jpg" });
            lemonade.Add(new Product { Name = "Lime", NameArm = "Լայմ", NameRus = "Лайм", Price = "390", PicPath = "/Resources/Bar/lime lemonade.jpg" });
            lemonade.Add(new Product { Name = "Lemon", NameArm = "Կիտրոն", NameRus = "Лимон", Price = "350", PicPath = "/Resources/Bar/lemon lemonade.jpg" });



            categories.Add(new Categorie { Name = "Lemonade", NameArm = "Լիմոնադներ", NameRus = "Лимонады", Products = lemonade, CategoriePic = "/Resources/Bar/Cover/lemonade.jpg" });


            List<Product> Cocktailandmilkshake = new List<Product>();
            Cocktailandmilkshake.Add(new Product { Name = "Banana and nutella", NameArm = "Բանան և նուտելլա", NameRus = "Банан и нутелла", Price = "1150", PicPath = "/Resources/Bar/banana and nutella.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Strawberry and ice-cream", NameArm = "Ելակ և պաղպաղակ", NameRus = "Клубника и мороженое", Price = "1150", PicPath = "/Resources/Bar/strawberry and ice cream milkshake.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Strawberry, banana and ice-cream", NameArm = "Ելակ, բանան և պաղպաղակ", NameRus = "Клубника, банан и мороженое", Price = "1200", PicPath = "/Resources/Bar/strawberry, banana, ice cream.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Berries", NameArm = "Հատապտղային", NameRus = "Ягодный", Price = "1200", PicPath = "/Resources/Bar/berries milkshake.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Banana and condensed milk", NameArm = "Բանան և խտացրած կաթ", NameRus = "Банан и сгущенное молоко", Price = "1200", PicPath = "/Resources/Bar/banana and condensed milk milkshake.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Banana, ice-cream and milk", NameArm = "Բանան, պաղպաղակ և կաթ", NameRus = "Банан, мороженое и молоко", Price = "700", PicPath = "/Resources/Bar/banana, ice cream and milk.jpg" });
            Cocktailandmilkshake.Add(new Product { Name = "Chocolate milkshake", NameArm = "Շոկոլադե միլքշեյք", NameRus = "Шоколадный милкшейк", Price = "800", PicPath = "/Resources/Bar/chocolate milkshake.jpg" });


            categories.Add(new Categorie { Name = "Cocktail and milkshake", NameArm = "Կոկտեյլ և միլք շեյք", NameRus = "Коктейль и милкшейк", Products = Cocktailandmilkshake, CategoriePic = "/Resources/Bar/Cover/milkshake.jpg" });


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
            Smoothies.Add(new Product { Name = "Grapefruit and strawberry", NameArm = "Թուրինջ, ելակ ֆրեշ", NameRus = "Фреш с грейпфрутом и клубникой", Price = "950", PicPath = "/Resources/Bar/strawbbery grapefruit smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Berries", NameArm = "Հատապտղային ֆրեշ", NameRus = "Ягодный фреш", Price = "950", PicPath = "/Resources/Bar/berries smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Orange and grapefruit smoothie", NameArm = "Նարինջ, թուրինջ սմուզի", NameRus = "Смузи из апельсина и грейпфрута", Price = "650", PicPath = "/Resources/Bar/orange and grapefruit smothie.jpg" });
            Smoothies.Add(new Product { Name = "Banana and orange smoothie", NameArm = "Բանան, նարինջ սմուզի", NameRus = "Смузи с банана и апельсина", Price = "650", PicPath = "/Resources/Bar/banana and orange smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Pineapple, orange, strawberry", NameArm = "Անանաս, նարինջ, ելակ", NameRus = "Ананас, апельсин, клубника", Price = "1150", PicPath = "/Resources/Bar/pineapple, orange, strawberry smoothie.jpg" });
            Smoothies.Add(new Product { Name = "Pineapple, lemon, ginger", NameArm = "Անանաս, կիտրոն, կոճապղպեղ", NameRus = "Ананас, лимон, имбирь", Price = "1150", PicPath = "/Resources/Bar/pineapple, lemon, ginger moothie.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed pomegranate juice", NameArm = "Թարմ քամած նռան հյութ", NameRus = "Свежевыжатый гранатовый сок", Price = "2500", PicPath = "/Resources/Bar/freshly squeezed pomegranate juice.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed orange juice", NameArm = "Թարմ քամած նարնջի հյութ", NameRus = "Свежевыжатый апельсиновый сок", Price = "850", PicPath = "/Resources/Bar/freshly squeezed orange juice.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed grapefruit juice", NameArm = "Թարմ քամած թուրինջի հյութ", NameRus = "Свежевыжатый грейпфрутовый сок", Price = "1200", PicPath = "/Resources/Bar/freshly squeezed grapefruit.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed apple juice", NameArm = "Թարմ քամած խնձոր", NameRus = "Свежевыжатый яблочный сок", Price = "700", PicPath = "/Resources/Bar/freshly squeezed apple.jpg" });
            Smoothies.Add(new Product { Name = "Freshly squeezed lemon juice", NameArm = "Թարմ քամած կիտրոն", NameRus = "Свежевыжатый лимонный сок", Price = "950", PicPath = "/Resources/Bar/freshy squeezed lemon juice.jpg" });
            Smoothies.Add(new Product { Name = "Nutella, banana", NameArm = "Նուտելլա, բանան", NameRus = "Нутелла, банан", Price = "1100", PicPath = "/Resources/Bar/smoothie nutella banana.jpg" });
            Smoothies.Add(new Product { Name = "Nutella, strawberry", NameArm = "Նուտելլա, ելակ", NameRus = "Нутелла, клубника", Price = "1100", PicPath = "/Resources/Bar/smoothie Nutella, strawberry.jpg" });
            Smoothies.Add(new Product { Name = "Nutella, banana, strawberry", NameArm = "Նուտելլա, բանան, ելակ", NameRus = "Нутелла, банан, клубника", Price = "1200", PicPath = "/Resources/Bar/smoothie banana strawberry nutella.jpg" });


            categories.Add(new Categorie { Name = "Smoothies", NameArm = "Ֆրեշ և սմուզի", NameRus = "Фреш и смузи", Products = Smoothies, CategoriePic = "/Resources/Bar/Cover/smothie.jpg" });


            List<Product> Coffee = new List<Product>();
            Coffee.Add(new Product { Name = "Frappe", NameArm = "Սուրճ ֆրապպե", NameRus = "Кофе-фраппе", Price = "550", PicPath = "/Resources/Bar/frappe.jpg" });
            Coffee.Add(new Product { Name = "Glacé", NameArm = "Սուրճ գլյասե", NameRus = "Глясе", Price = "650", PicPath = "/Resources/Bar/glace.jpg" });
            Coffee.Add(new Product { Name = "Hot chocolate", NameArm = "Սուրճ տաք շոկոլադ", NameRus = "Горячий шоколад", Price = "250", PicPath = "/Resources/Bar/hot chocolate.jpg" });
            Coffee.Add(new Product { Name = "Espresso", NameArm = "Էսպրեսսո", NameRus = "Эспрессо", Price = "550", PicPath = "/Resources/Bar/espresso.jpg" });
            Coffee.Add(new Product { Name = "Americano", NameArm = "Ամերիկանո", NameRus = "Американо", Price = "550", PicPath = "/Resources/Bar/Americano.jpg" });
            Coffee.Add(new Product { Name = "Capuccino", NameArm = "Կապուչինո", NameRus = "Капучино", Price = "550", PicPath = "/Resources/Bar/capuccino.jpg" });
            Coffee.Add(new Product { Name = "Americano with milk", NameArm = "Ամերիկանո կաթով", NameRus = "Американо с молоком", Price = "650", PicPath = "/Resources/Bar/Americano with milk.jpg" });
            Coffee.Add(new Product { Name = "Ice cream", NameArm = "Պաղպաղակ", NameRus = "Мороженое", Price = "550", PicPath = "/Resources/Bar/ice cream.jpg" });
            Coffee.Add(new Product { Name = "Eastern coffee", NameArm = "Սև սուրճ", NameRus = "Восточный кофе", Price = "250", PicPath = "/Resources/Bar/black coffee.jpg" });
            Coffee.Add(new Product { Name = "Coffee nutella", NameArm = "Սուրճ նուտելլա", NameRus = "Кофе нутелла", Price = "590", PicPath = "/Resources/Bar/Coffee nutella.jpg" });
            Coffee.Add(new Product { Name = "Latte", NameArm = "Լատտե", NameRus = "Латте", Price = "750", PicPath = "/Resources/Bar/coffee latte.jpg" });
            Coffee.Add(new Product { Name = "Nescafe", NameArm = "Նեսկաֆե", NameRus = "Нескафе", Price = "250", PicPath = "/Resources/Bar/nescafe.jpg" });
            Coffee.Add(new Product { Name = "Nescafe Gold", NameArm = "Նեսկաֆե գոլդ", NameRus = "Нескафе Голд", Price = "350", PicPath = "/Resources/Bar/nescafe gold.jpg" });
            Coffee.Add(new Product { Name = "Parisian", NameArm = "Փարիզյան", NameRus = "Парижский", Price = "350", PicPath = "/Resources/Bar/Coffee parisian.jpg" });
            Coffee.Add(new Product { Name = "MacCoffee", NameArm = "Մակ", NameRus = "MacCoffee", Price = "250", PicPath = "/Resources/Bar/mac coffee.jpg" });
            Coffee.Add(new Product { Name = "MacCappuccino", NameArm = "Մակ կապուչինո", NameRus = "MacCappuccino", Price = "350", PicPath = "/Resources/Bar/coffee mac cappuccino.jpg" });
            Coffee.Add(new Product { Name = "Gelato", NameArm = "Ժելատո", NameRus = "Джелато", Price = "690", PicPath = "/Resources/Bar/gelato.jpg" });


            categories.Add(new Categorie { Name = "Coffee", NameArm = "Սուրճ", NameRus = "Кофе", Products = Coffee, CategoriePic = "/Resources/Bar/Cover/coffee.jpg" });


            List<Product> Tea = new List<Product>();

            Tea.Add(new Product { Name = "Richard", NameArm = "Richard", NameRus = "Richard", Price = "250", PicPath = "/Resources/Bar/tea richard.jpg" });
            Tea.Add(new Product { Name = "Citrus tea", NameArm = "Ցիտրուսային", NameRus = "Цитрусовый чай", Price = "390", PicPath = "/Resources/Bar/tea citrus.jpg" });
            Tea.Add(new Product { Name = "Ginger, lemon", NameArm = "Իմբիր, կիտրոն", NameRus = "Имбирь,лимон", Price = "350", PicPath = "/Resources/Bar/tea ginger lemon.jpg" });
            Tea.Add(new Product { Name = "Pomegranate", NameArm = "Նուռ", NameRus = "Гранат", Price = "350", PicPath = "/Resources/Bar/tea pomegranate.jpg" });
            Tea.Add(new Product { Name = "Herbal", NameArm = "Խոտաբույսեր", NameRus = "Травяной", Price = "350", PicPath = "/Resources/Bar/tea herbal.jpg" });
            Tea.Add(new Product { Name = "Karkade, orange", NameArm = "Կարկադե, նարինջ", NameRus = "Каркаде, апельсин", Price = "350", PicPath = "/Resources/Bar/karkade orange tea.jpg" });

            categories.Add(new Categorie { Name = "Tea", NameArm = "Թեյ", NameRus = "Чай", Products = Tea, CategoriePic = "/Resources/Bar/Cover/tea.jpg" });
        }
    }
}
