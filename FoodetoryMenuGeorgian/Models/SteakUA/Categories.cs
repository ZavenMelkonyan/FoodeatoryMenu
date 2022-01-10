using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.SteakUA
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> steak = new List<Product>();

            steak.Add(new Product { Name = "Рібай", NameEng = "Ribeye steak /250-350 g/", PicPath = "/Resources/SteakUA/Ռիբայ սթեյք.jpg", Description = "Телятина", DescriptionEng = "beef" });
            steak.Add(new Product { Name = "Лосось", NameEng = "Salmon steak /200-280 g/ ", PicPath = "/Resources/SteakUA/Սաղմոնի սթեյք.jpg", Description = "Риба, наршараб, лимон", DescriptionEng = "fish, narsharab, lemon" });
            steak.Add(new Product { Name = "Свинина", NameEng = "Pork loin steak /250-350 g/", PicPath = "/Resources/SteakUA/Pork loin steak.jpg", Description = "Ошийок свинячий", DescriptionEng = "pork neck" });
            steak.Add(new Product { Name = "Курка", NameEng = "Chicken steak /250 g/", PicPath = "/Resources/SteakUA/Chicken steak.jpg", Description = "Куряча грудка", DescriptionEng = "pork" });
            steak.Add(new Product { Name = "Індичка", NameEng = "Turkey steak /250 g/", PicPath = "/Resources/SteakUA/Հնդկահավի սթեյք.jpg", Description = "Індичка", DescriptionEng = "turkey" });
            steak.Add(new Product { Name = "Свинні ребра", NameEng = "Pork Ribs BBQ /300-350 g/", PicPath = "/Resources/SteakUA/Ռիբս.jpg", Description = "Ребра свинні", DescriptionEng = "pork" });


            categories.Add(new Categorie { Name = "Стейк", NameEng = "Steak", Products = steak, CategoriePic = "/Resources/Steak/Cover/սթեյք.jpg" });


            List<Product> burger = new List<Product>();

            burger.Add(new Product { Name = "Класичний", NameEng = "Classic beef burger", PicPath = "/Resources/SteakUA/Classic beef burger.jpg", Description = "Телятина, томати, солоний огірок, гірчиця", DescriptionEng = "beef, tomatoes, pickles, mustard  " });
            burger.Add(new Product { Name = "Класичний з куркою", NameEng = "Classic chicken burger", PicPath = "/Resources/SteakUA/Classic chicken burger.jpg", Description = "Курка, томати, солоний огірок, гірчиця", DescriptionEng = "chicken, tomatoes, pickled cucumbers, mustard" });
            burger.Add(new Product { Name = "Чізбургер", NameEng = "Cheeseburger", PicPath = "/Resources/SteakUA/Cheeseburger.jpg", Description = "Телятина, сир,томати, огірок, майонез, вершки", DescriptionEng = "beef, cheese, tomatoes, cucumbers, mayonnaise, cream" });
            burger.Add(new Product { Name = "Чізбургер Курка", NameEng = "Chicken cheese burger", PicPath = "/Resources/SteakUA/chicken cheeseburger.jpg", Description = "Курка, сир, томати, огірок, майонез, вершки", DescriptionEng = "chicken, cheese, tomatoes, cucumbers, mayonnaise, cream" });
            burger.Add(new Product { Name = "Даблчізбургер", NameEng = "Double cheeseburger", PicPath = "/Resources/SteakUA/Double cheese burger.jpg", Description = "Телятина, сир, томати, огірок, майонез, вершки", DescriptionEng = "beef, cheese, tomatoes, cucumbers, mayonnaise, cream" });
            burger.Add(new Product { Name = "Даблчізбургер Курка", NameEng = "Double cheeseburger, chicken", PicPath = "/Resources/SteakUA/Double chicken cheese burger.jpg", Description = "Курка, сир, томати, огірок, майонез, вершки", DescriptionEng = "chicken, cheese, tomatoes, cucumbers, mayonnaise, cream" });
            burger.Add(new Product { Name = "Даблчізбургер", NameEng = "Double cheeseburger, beef", PicPath = "/Resources/SteakUA/double cheese burger beef.jpg", Description = "0", DescriptionEng = "beef, cheese, tomatoes, cucumbers, mayonnaise, cream" });
            burger.Add(new Product { Name = "Де Люкс ", NameEng = "Beef Deluxe burger", PicPath = "/Resources/SteakUA/Beef deluxe burger.jpg", Description = "Телятина, картопля фрі,томати,солоний огірок, цибуля", DescriptionEng = "beef, french fries, tomatoes, pickled cucumbers, onions" });
            burger.Add(new Product { Name = "Де Люкс Курка", NameEng = "Chicken Deluxe burger", PicPath = "/Resources/SteakUA/Chicken deluxe burger.jpg", Description = "Курка, картопля фрі, томати, солоний огірок, цибуля", DescriptionEng = "chicken, french fries, tomatoes, pickled cucumbers, onions" });
            burger.Add(new Product { Name = "Веджібургер", NameEng = "Veggie burger", PicPath = "/Resources/SteakUA/Veggie burger.jpg", Description = "Паніровочні сухарі,морква,картопля, горох, томати, листя салату", DescriptionEng = "bread crumbs, carrots, potatoes, peas, tomatoes, lettuce" });
            burger.Add(new Product { Name = "Стейк бургер", NameEng = "Beef steak burger", PicPath = "/Resources/SteakUA/Beef steak burger.jpg", Description = "Телятина, томати, червона цибуля, маринований огірок, кетчуп, майонез", DescriptionEng = "beef, tomatoes, red onion, pickled cucumbers, ketchup, mayonnaise" });
            burger.Add(new Product { Name = "Стейк Бургер Курка", NameEng = "Chicken steak burger", PicPath = "/Resources/SteakUA/Chicken steak burger.jpg", Description = "Курка, томати, червона цибуля, маринований огірок, кетчуп, майонез", DescriptionEng = "chicken, tomatoes, red onion, pickled cucumbers, ketchup, mayonnaise" });
            burger.Add(new Product { Name = "БоксМастер", NameEng = "Boxmaster", PicPath = "/Resources/SteakUA/box master.jpg", Description = "Курка, картопля фрі, томати, солоний огірок, кетчуп, майонез, лошик", DescriptionEng = "chicken, french fries, tomatoes, pickled cucumbers, ketchup, mayonnaise, loshik" });
            burger.Add(new Product { Name = "Рол Цезар", NameEng = "Caesar roll", PicPath = "/Resources/SteakUA/Caesar roll.jpg", Description = "Курка, картопля фрі, томати, солоний огірок, вершки, цибуля, лошик", DescriptionEng = "chicken, french fries, tomatoes, pickled cucumbers, cream, onion, loshik" });
            burger.Add(new Product { Name = "BBQ Дабл Чікенбургер", NameEng = "BBQ chicken double burger", PicPath = "/Resources/SteakUA/BBQ double cheese burger.jpg", Description = "Курка, томати, огірок, майонез,сир,соус BBQ", DescriptionEng = "chicken, tomatoes, cucumbers, mayonnaise, cheese, BBQ sauce" });
            burger.Add(new Product { Name = "BBQ Чікенбургер", NameEng = "BBQ chicken burger", PicPath = "/Resources/SteakUA/BBQ chicken burger.jpg", Description = "Курка,томати,солоний огірок, листя салату, паніровочні сухарі, соус BBQ", DescriptionEng = "chicken, tomatoes, pickled cucumbers, lettuce, bread crumbs, BBQ sauce" });
            burger.Add(new Product { Name = " BBQ Дабл Біфбургер", NameEng = "BBQ beef double burger", PicPath = "/Resources/SteakUA/BBQ Double beef burger.jpg", Description = "Телятина, томати, огірок, майонез, сир, соус  BBQ", DescriptionEng = "beef, tomatoes, cucumbers, mayonnaise, cheese, BBQ sauce" });
            burger.Add(new Product { Name = "Шефбургер", NameEng = "Chef burger, beef", PicPath = "/Resources/SteakUA/chef burger, beed.jpg", Description = "Котлета з телятини, сир, маринований огірок, червона цибуля, бекон, листя салату, майонез", DescriptionEng = "beef cutlet, cheese, pickles, red onions, bacon, lettuce, mayonnaise" });
            burger.Add(new Product { Name = "Шефбургер Курка", NameEng = "Chef burger, chicken", PicPath = "/Resources/SteakUA/chef burger, chicken.jpg", Description = "Котлета з курки, сир, маринований огірок, червона цибуля, бекон, листя салату, майонез", DescriptionEng = "chicken cutlet, cheese, pickles, red onions, bacon, lettuce, mayonnaise" });
            burger.Add(new Product { Name = "Біг Тейсті", NameEng = "Big tasty, beef", PicPath = "/Resources/SteakUA/big tasty, beef.jpg", Description = "Котлета з телятини, томати,гірчичний соус, листя салату, цибуля, маринований огірок, сир", DescriptionEng = "beef cutlet, tomato, mustard sauce, lettuce, onion, pickle, cheese" });
            burger.Add(new Product { Name = "Біг Тейсті Курка", NameEng = "Big tasty, chicken", PicPath = "/Resources/SteakUA/big tasty, chicken.jpg", Description = "Котлета з курки, томати, гірчичний соус, листя салату, цибуля, маринований огірок, сир", DescriptionEng = "chicken cutlet, tomato, mustard sauce, lettuce, onion, pickle, cheese" });
            burger.Add(new Product { Name = "Бургер Форель", NameEng = "Trout burger", PicPath = "/Resources/SteakUA/Իշխանով բուրգեր.jpg", Description = "Філе форелі, червона цибуля, гірчичний соус, томати, сир", DescriptionEng = "trout fillet, red onion, mustard sauce, tomato, cheese" });
            burger.Add(new Product { Name = "Бургер Цезар", NameEng = "Caesar burger", PicPath = "/Resources/SteakUA/caesar burger.jpg", Description = "Куряча грудка, сир, листя салату, томати, майонез, халапеньо", DescriptionEng = "chicken breast, cheese, lettuce, tomato, mayonnaise, jalapeno" });
            burger.Add(new Product { Name = "Веджибургер Гриль", NameEng = "Grill vegie burger", PicPath = "/Resources/SteakUA/gril vegie burger.jpg", Description = "Болгарський перець, буряк, листя салату,броколі, соус кетчуп, солоний огірок", DescriptionEng = "bell pepper, pumpkin, lettuce, broccoli, ketchup sauce, pickles" });


            categories.Add(new Categorie { Name = "Бургери", NameEng = "Burger", Products = burger, CategoriePic = "/Resources/Steak/Cover/burger.jpg" });


            List<Product> sandwich = new List<Product>();

            sandwich.Add(new Product { Name = "Класичний", NameEng = "Classic sandwich", PicPath = "/Resources/SteakUA/Classic sandwich.jpg", Description = "Шинка з індички, томати, хліб, листя салату, сир, кетчуп, майонез", DescriptionEng = "turkey ham, tomatoes, bread, lettuce, cheese, ketchup, mayonnaise" });
            sandwich.Add(new Product { Name = "Клаб сендвіч з куркою", NameEng = "Chicken club sandwich", PicPath = "/Resources/SteakUA/Chicken club sandwich.jpg", Description = "Курка, томати, бекон, майонез, сир, кетчуп", DescriptionEng = "chicken, tomatoes, bacon, mayonnaise, cheese, ketchup" });
            sandwich.Add(new Product { Name = "Сендвіч з шинкою та сиром", NameEng = "Ham and cheese sandwich", PicPath = "/Resources/SteakUA/ham cheese sandwich.jpg", Description = "Шинка зі свинини, томати, огірок, майонез, кетчуп, листя салату", DescriptionEng = "pork ham, tomatoes, cucumbers, mayonnaise, ketchup, lettuce" });



            categories.Add(new Categorie { Name = "Сендвічі", NameEng = "Sandwich", Products = sandwich, CategoriePic = "/Resources/Steak/Cover/sandwich.jpg" });


            List<Product> mainDishes = new List<Product>();

            mainDishes.Add(new Product { Name = "Курячі стегенця 2", NameEng = "Chicken drumstick (2 pieces)", PicPath = "/Resources/SteakUA/Chicken drumsticks 2 pieces.jpg", Description = "Курячі окорочка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken legs, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Курячі стегенця 4", NameEng = "Chicken drumstick (4 pieces)", PicPath = "/Resources/SteakUA/Chicken drumsticks 4 pieces.jpg", Description = "Курячі окорочка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken legs, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Курячі стегенця 6", NameEng = "Chicken drumstick (6 pieces)", PicPath = "/Resources/SteakUA/Chicken drumsticks 6 pieces.jpg", Description = "Курячі окорочка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken legs, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Курячі крильця 3", NameEng = "Chicken wings (3 pieces)", PicPath = "/Resources/SteakUA/Chicken wings 3 pieces.jpg", Description = "Курячі крильця, борошно, паніровка, сіль, перець", DescriptionEng = "chicken wings, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Курячі крильця 6", NameEng = "Chicken wings (6 pieces)", PicPath = "/Resources/SteakUA/Chicken wings 6 pieces.jpg", Description = "Курячі крильця, борошно, паніровка, сіль, перець", DescriptionEng = "chicken wings, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Курячі крильця 9", NameEng = "Chicken wings (9 pieces)", PicPath = "/Resources/SteakUA/Chicken wings 9 pieces.jpg", Description = "Курячі крильця, борошно, паніровка, сіль, перець", DescriptionEng = "chicken wings, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Нагетси 4", NameEng = "Chicken nuggets (4 pieces)", PicPath = "/Resources/SteakUA/Chicken nuggets 4 pieces.jpg", Description = "Куряча грудка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken breast, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Нагетси 8", NameEng = "Chicken nuggets (8 pieces)", PicPath = "/Resources/SteakUA/Chicken nuggets 8 pieces.jpg", Description = "Куряча грудка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken breast, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Нагетси 12", NameEng = "Chicken nuggets (12 pieces)", PicPath = "/Resources/SteakUA/Chicken nuggets 12 pieces.jpg", Description = "Куряча грудка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken breast, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Курячі палички (мал порція)", NameEng = "Chicken sticks (small)", PicPath = "/Resources/SteakUA/Chicken sticks small.jpg", Description = "Куряча грудка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken breast, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Курячі палички (вел порція)", NameEng = "Chicken sticks (big)", PicPath = "/Resources/SteakUA/Chicken sticks big.jpg", Description = "Куряча грудка, борошно, паніровка, сіль, перець", DescriptionEng = "chicken breast, flour, breading, salt, pepper" });
            mainDishes.Add(new Product { Name = "Картопля фрі (мал порція)", NameEng = "French fries (small)", PicPath = "/Resources/SteakUA/French fries small.jpg", Description = "Картопля", DescriptionEng = "potatoes" });
            mainDishes.Add(new Product { Name = "Картопля фрі (вел порція)", NameEng = "French fries (big)", PicPath = "/Resources/SteakUA/French fries big.jpg", Description = "Картопля", DescriptionEng = "potatoes" });
            mainDishes.Add(new Product { Name = "Хашбраун", NameEng = "Hash browns", PicPath = "/Resources/SteakUA/Hashbrown potato.jpg", Description = "Картопля, цибуля", DescriptionEng = "potato, onion" });
            mainDishes.Add(new Product { Name = "Картопля по-селянськи (мал порція)", NameEng = "Country Style Fried Potatoes (small)", PicPath = "/Resources/SteakUA/village potatoes small.jpg", Description = "0", DescriptionEng = "0" });
            mainDishes.Add(new Product { Name = "Картопля по-селянськи (вел порція)", NameEng = "Country Style Fried Potatoes (big portion)", PicPath = "/Resources/SteakUA/village potatoes big.jpg", Description = "0", DescriptionEng = "0" });
            mainDishes.Add(new Product { Name = "Картопляні чіпси", NameEng = "Chips", PicPath = "/Resources/SteakUA/potato chips.jpg", Description = "0", DescriptionEng = "0" });
            mainDishes.Add(new Product { Name = "Чіпси бекон", NameEng = "Chips with becon", PicPath = "/Resources/SteakUA/bacon chips.jpg", Description = "0", DescriptionEng = "0" });
            mainDishes.Add(new Product { Name = "Кукурудза", NameEng = "Sweet corn", PicPath = "/Resources/SteakUA/corn bbq.jpg", Description = "0", DescriptionEng = "0" });
            mainDishes.Add(new Product { Name = "Веган роли", NameEng = "Veggie rolls", PicPath = "/Resources/SteakUA/Veggie rolls.jpg", Description = "0", DescriptionEng = "4 pieces" });
            mainDishes.Add(new Product { Name = "Сирні палички", NameEng = "Cheese sticks", PicPath = "/Resources/SteakUA/Cheese sticks.jpg", Description = "0", DescriptionEng = "4 pieces" });



            categories.Add(new Categorie { Name = "Основні страви", NameEng = "Main dishes", Products = mainDishes, CategoriePic = "/Resources/Steak/Cover/main dishes.jpg" });

            List<Product> sauces = new List<Product>();

            sauces.Add(new Product { Name = "Гірчиця", NameEng = "Mustard sauce", PicPath = "/Resources/SteakUA/Mustard sauce.jpg", Description = "Гірчиця, солоний огірок, майонез", DescriptionEng = "mustard, pickled cucumber, mayonnaise" });
            sauces.Add(new Product { Name = "Кетчуп", NameEng = "Ketchup sauce", PicPath = "/Resources/SteakUA/Ketchup.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Сирний соус", NameEng = "Cheese sauce", PicPath = "/Resources/SteakUA/cheese sauce.jpg", Description = "Сир, майонез, вершки", DescriptionEng = "cheese, mayonnaise, cream" });
            sauces.Add(new Product { Name = "Соус BBQ", NameEng = "BBQ sauce", PicPath = "/Resources/SteakUA/bbq sauce.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Солодкий Чілі", NameEng = "Sweet chili sauce", PicPath = "/Resources/SteakUA/Sweet chilli sauce.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Гранатовий соус", NameEng = "Pomegranate sauce", PicPath = "/Resources/SteakUA/Pomegranate sauce.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Соус Теріякі", NameEng = "Teriyaki sauce", PicPath = "/Resources/SteakUA/Teriyaki sauce.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Соус Чілі", NameEng = "Chilli sauce", PicPath = "/Resources/SteakUA/chili sauce.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Часниковий соус", NameEng = "Garlic sauce", PicPath = "/Resources/SteakUA/garlic sauce.jpg", Description = "0", DescriptionEng = "0" });


            categories.Add(new Categorie { Name = "Соуси", NameEng = "Sauces", Products = sauces, CategoriePic = "/Resources/Steak/Cover/sauce.jpg" });

            

            
        }
    }
}
