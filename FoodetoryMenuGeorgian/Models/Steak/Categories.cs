﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.Steak
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> steak = new List<Product>();

            steak.Add(new Product { Name = "Ribeye steak /250-350 g/", NameArm = "Ռիբայ /250-350 գր/", NameRus = "Рибай /250-350 гр./", Price = "5500", PicPath = "/Resources/Steak/Ռիբայ սթեյք.jpg", Description = "beef", DescriptionArm = "տավարի միս ", DescriptionRus = "говядина" });
            steak.Add(new Product { Name = "Salmon steak /200-280 g/ ", NameArm = "Սաղմոնի /200-280 գր/", NameRus = "Из сальмона /200-280 гр./ ", Price = "6000", PicPath = "/Resources/Steak/Սաղմոնի սթեյք.jpg", Description = "fish, narsharab, lemon", DescriptionArm = "ձուկ, նարշարաբ, կիտրոն ", DescriptionRus = "рыба, наршараб, лимон" });
            steak.Add(new Product { Name = "Pork loin steak /250-350 g/", NameArm = "Խոզի փափկամսով /250-350 գր/", NameRus = "Из свинины /250-350 гр./", Price = "2900", PicPath = "/Resources/Steak/Pork loin steak.jpg", Description = "pork neck", DescriptionArm = "խոզի վիզ ", DescriptionRus = "свиная шейка" });
            steak.Add(new Product { Name = "Chicken steak /250 g/", NameArm = "Հավի կրծքամսով /250 գր/", NameRus = "Из куриной грудки /250 гр./", Price = "2900", PicPath = "/Resources/Steak/Chicken steak.jpg", Description = "pork", DescriptionArm = "հավի միս", DescriptionRus = "свинина" });
            steak.Add(new Product { Name = "Turkey steak /250 g/", NameArm = "Հնդկահավի կրծքամսով /250 գր/", NameRus = "Из филе индейки /250 гр./", Price = "2500", PicPath = "/Resources/Steak/Հնդկահավի սթեյք.jpg", Description = "turkey", DescriptionArm = "հնդկահավի միս", DescriptionRus = "индейка" });
            steak.Add(new Product { Name = "Pork Ribs BBQ /300-350 g/", NameArm = "Խոզի կողիկներ /300-350 գր/", NameRus = "Свиные ребрышки /300-350 гр./", Price = "3500", PicPath = "/Resources/Steak/Ռիբս.jpg", Description = "pork", DescriptionArm = "խոզի միս", DescriptionRus = "свинина" });


            categories.Add(new Categorie { Name = "Steak", NameArm = "Սթեյք", NameRus = "Стейк", Products = steak, CategoriePic = "/Resources/Steak/Cover/սթեյք.jpg" });


            List<Product> burger = new List<Product>();

            burger.Add(new Product { Name = "Classic beef burger", NameArm = "Կլասիկ տավարի կոտլետով", NameRus = "Бургер классический с говядиной", Price = "950", PicPath = "/Resources/Steak/Classic beef burger.jpg", Description = "beef, tomatoes, pickles, mustard  ", DescriptionArm = "տավարի միս, լոլիկ, թթու վարունգ, մանանեխ", DescriptionRus = "говядина, помидоры, соленые огурцы, горчица" });
            burger.Add(new Product { Name = "Classic chicken burger", NameArm = "Կլասիկ հավի կոտլետով", NameRus = "Куриный бургер классический", Price = "950", PicPath = "/Resources/Steak/Classic chicken burger.jpg", Description = "chicken, tomatoes, pickled cucumbers, mustard", DescriptionArm = "հավի միս, լոլիկ, թթու վարունգ, մանանեխ", DescriptionRus = "курятина, помидоры, соленые огурцы, горчица " });
            burger.Add(new Product { Name = "Cheeseburger", NameArm = "Չիզբուրգեր  ", NameRus = "Чизбургер", Price = "1200", PicPath = "/Resources/Steak/Cheeseburger.jpg", Description = "beef, cheese, tomatoes, cucumbers, mayonnaise, cream", DescriptionArm = "տավարի միս, պանիր, լոլիկ, վարունգ, մայոնեզ, սերուցք", DescriptionRus = "говядина, сыр, помидоры, огурцы, майонез, сливки" });
            burger.Add(new Product { Name = "Chicken cheese burger", NameArm = "Չիզբուրգեր հավի", NameRus = "Куриный чизбургер", Price = "1150", PicPath = "/Resources/Steak/chicken cheeseburger.jpg", Description = "chicken, cheese, tomatoes, cucumbers, mayonnaise, cream", DescriptionArm = "հավի միս, պանիր, լոլիկ, վարունգ, մայոնեզ, սերուցք", DescriptionRus = "курятина, сыр, помидоры, огурцы, майонез, сливки" });
            burger.Add(new Product { Name = "Double cheeseburger", NameArm = "Չիզբուրգեր դաբլ", NameRus = "Двойной чизбургер", Price = "1600", PicPath = "/Resources/Steak/Double cheese burger.jpg", Description = "beef, cheese, tomatoes, cucumbers, mayonnaise, cream", DescriptionArm = "տավարի միս, պանիր, լոլիկ, վարունգ, մայոնեզ, սերուցք", DescriptionRus = "говядина, сыр, помидоры, огурцы, майонез, сливки" });
            burger.Add(new Product { Name = "Double cheeseburger, chicken", NameArm = "Չիզբուրգեր դաբլ, հավի", NameRus = "Двойной чизбургер, Куриный", Price = "1500", PicPath = "/Resources/Steak/Double chicken cheese burger.jpg", Description = "chicken, cheese, tomatoes, cucumbers, mayonnaise, cream", DescriptionArm = "հավի միս, պանիր, լոլիկ, վարունգ, մայոնեզ, սերուցք", DescriptionRus = "курятина, сыр, помидоры, огурцы, майонез, сливки" });
            burger.Add(new Product { Name = "Beef Deluxe burger", NameArm = "Դելյուքս  տավարի մսով", NameRus = "Бургер Де Люкс с говядиной", Price = "1300", PicPath = "/Resources/Steak/Beef deluxe burger.jpg", Description = "beef, french fries, tomatoes, pickled cucumbers, onions", DescriptionArm = "տավարի միս, ֆրի, լոլիկ, թթու վարունգ, սոխ ", DescriptionRus = "говядина, картофель фри, помидоры, соленые огурцы, лук" });
            burger.Add(new Product { Name = "Chicken Deluxe burger", NameArm = "Դելյուքս հավի մսով", NameRus = "Бургер Де Люкс с курицей", Price = "1100", PicPath = "/Resources/Steak/Chicken deluxe burger.jpg", Description = "chicken, french fries, tomatoes, pickled cucumbers, onions", DescriptionArm = "հավի միս, ֆրի, լոլիկ, թթու վարունգ, սոխ", DescriptionRus = "курятина, картофель фри, помидоры, соленые огурцы, лук" });
            burger.Add(new Product { Name = "Veggie burger", NameArm = "Վեջի Բուրգեր", NameRus = "Веджибургер", Price = "850", PicPath = "/Resources/Steak/Veggie burger.jpg", Description = "bread crumbs, carrots, potatoes, peas, tomatoes, lettuce", DescriptionArm = "դեղին պաքսիմատ, գազար, կարտոֆիլ, ոլոռ, լոլիկ, հազար", DescriptionRus = "панировочные сухари, морковь, картофель, горох, помидоры, листья салата" });
            burger.Add(new Product { Name = "Beef steak burger", NameArm = "Սթեյք Բուրգեր տավարի մսով", NameRus = "Стейк бургер с говядинной", Price = "2200", PicPath = "/Resources/Steak/Beef steak burger.jpg", Description = "beef, tomatoes, red onion, pickled cucumbers, ketchup, mayonnaise", DescriptionArm = "տավարի միս, լոլիկ, կարմիր սոխ, թթու վարունգ, կետչուպ, մայոնեզ  ", DescriptionRus = "говядина, помидоры, красный лук, маринованные огурцы, кетчуп, майонез" });
            burger.Add(new Product { Name = "Chicken steak burger", NameArm = "Սթեյք Բուրգեր հավի մսով", NameRus = "Куриный стейк бургер", Price = "1500", PicPath = "/Resources/Steak/Chicken steak burger.jpg", Description = "chicken, tomatoes, red onion, pickled cucumbers, ketchup, mayonnaise", DescriptionArm = "հավի միս, լոլիկ, կարմիր սոխ, թթու վարունգ, կետչուպ, մայոնեզ ", DescriptionRus = "курятина, помидоры, красный лук, маринованные огурцы, кетчуп, майонез" });
            burger.Add(new Product { Name = "Boxmaster", NameArm = "Բոքս Մաստեր", NameRus = "БоксМастер", Price = "1100", PicPath = "/Resources/Steak/box master.jpg", Description = "chicken, french fries, tomatoes, pickled cucumbers, ketchup, mayonnaise, loshik", DescriptionArm = "հավի միս, ֆրի, լոլիկ, թթու վարունգ, կետչուպ, մայոնեզ, լոշիկ ", DescriptionRus = "курятина, картофель фри, помидоры, соленые огурцы, кетчуп, майонез, лошик" });
            burger.Add(new Product { Name = "Caesar roll", NameArm = "Կեսար ռոլլ", NameRus = "Цезарь Ролл", Price = "1500", PicPath = "/Resources/Steak/Caesar roll.jpg", Description = "chicken, french fries, tomatoes, pickled cucumbers, cream, onion, loshik", DescriptionArm = "հավի միս, ֆրի, լոլիկ, թթու վարունգ, սերուցք, սոխ, լոշիկ ", DescriptionRus = "курятина, картофель фри, помидоры, соленые огурцы, сливки, лук, лошик" });
            burger.Add(new Product { Name = "BBQ chicken double burger", NameArm = "BBQ հավի դաբլ չիզբուրգեր ", NameRus = "BBQ двойной Чикенбургер", Price = "2100", PicPath = "/Resources/Steak/BBQ double cheese burger.jpg", Description = "chicken, tomatoes, cucumbers, mayonnaise, cheese, BBQ sauce", DescriptionArm = "հավի միս, լոլիկ, վարունգ, մայոնեզ, պանիր, BBQ սոուս ", DescriptionRus = "курятина, помидоры, огурцы, майонез, сыр, соус BBQ" });
            burger.Add(new Product { Name = "BBQ chicken burger", NameArm = "BBQ հավի բուրգեր", NameRus = "BBQ Чикенбургер", Price = "1950", PicPath = "/Resources/Steak/BBQ chicken burger.jpg", Description = "chicken, tomatoes, pickled cucumbers, lettuce, bread crumbs, BBQ sauce", DescriptionArm = "հավի միս, լոլիկ, թթու վարունգ, լեթթուս, պաքսիմատ, BBQ սոուս ", DescriptionRus = "курятина, помидоры, соленые огурцы, листья салата, панировочные сухари, соус BBQ" });
            burger.Add(new Product { Name = "BBQ beef double burger", NameArm = "BBQ տավարի դաբլ բուրգեր ", NameRus = "BBQ двойной Бифбургер", Price = "1950", PicPath = "/Resources/Steak/BBQ Double beef burger.jpg", Description = "beef, tomatoes, cucumbers, mayonnaise, cheese, BBQ sauce", DescriptionArm = "տավարի միս, լոլիկ, վարունգ, մայոնեզ, պանիր, BBQ սոուս ", DescriptionRus = "говядина, помидоры, огурцы, майонез, сыр, соус BBQ" });
            burger.Add(new Product { Name = "Chef burger, beef", NameArm = "Շեֆ բուրգեր, տավարի", NameRus = "Шефбургер с говядиной", Price = "3100", PicPath = "/Resources/Steak/chef burger, beed.jpg", Description = "beef cutlet, cheese, pickles, red onions, bacon, lettuce, mayonnaise", DescriptionArm = "տավարի կոտլետ, պանիր, թթու վարունգ, կարմիր սոխ, բեկոն, լետուս, մայոնեզ", DescriptionRus = "котлета из говядины, сыр, маринованные огурцы, красный лук, бекон, листья салата, майонез" });
            burger.Add(new Product { Name = "Chef burger, chicken", NameArm = "Շեֆ բուրգեր, հավի", NameRus = "Шефбургер с курицей", Price = "2800", PicPath = "/Resources/Steak/chef burger, chicken.jpg", Description = "chicken cutlet, cheese, pickles, red onions, bacon, lettuce, mayonnaise", DescriptionArm = "հավի կոտլետ, պանիր, թթու վարունգ, կարմիր սոխ, բեկոն, լետուս, մայոնեզ", DescriptionRus = "куриная котлета, сыр, маринованные огурцы, красный лук, бекон, листья салата, майонез" });
            burger.Add(new Product { Name = "Big tasty, beef", NameArm = "Բիգ տեստի, տավարի", NameRus = "Биг Тейсти с говядиной", Price = "2400", PicPath = "/Resources/Steak/big tasty, beef and chicken.jpg", Description = "beef cutlet, tomato, mustard sauce, lettuce, onion, pickle, cheese", DescriptionArm = "տավարի կոտլետ, լոլիկ, մանանեխի սոուս, լետուս, սոխ, թթու վարունգ, պանիր", DescriptionRus = "котлета из говядины, помидоры, горчичный соус, листья салата, лук, маринованные огурцы, сыр" });
            burger.Add(new Product { Name = "Big tasty, chicken", NameArm = "Բիգ տեստի, հավի", NameRus = "Биг Тейсти с с курицей", Price = "2400", PicPath = "/Resources/Steak/big tasty, beef and chicken.jpg", Description = "chicken cutlet, tomato, mustard sauce, lettuce, onion, pickle, cheese", DescriptionArm = "հավի կոտլետ, լոլիկ, մանանեխի սոուս, լետուս, սոխ, թթու վարունգ, պանիր", DescriptionRus = "куриная котлета, помидор, горчичный соус, листья салата, лук, маринованный огурцы, сыр" });
            burger.Add(new Product { Name = "Trout burger", NameArm = "Իշխանով բուրգեր", NameRus = "Бургер с форелью", Price = "2500", PicPath = "/Resources/Steak/Իշխանով բուրգեր.jpg", Description = "trout fillet, red onion, mustard sauce, tomato, cheese", DescriptionArm = "իշխանի ֆիլե, սոխ կարմիր, մանանեխի սոուս, լոլիկ, պանիր", DescriptionRus = "филе форели, лук красный, соус горчичный, помидоры, сыр" });
            burger.Add(new Product { Name = "Kufta burger", NameArm = "Քուֆթա բուրգեր", NameRus = "Кюфта бургер", Price = "1500", PicPath = "/Resources/Steak/kufta burger.jpg", Description = "kufta, lettuce, tomato, mayonnaise, cheese", DescriptionArm = "քուֆթա, լետուս, լոլիկ, մայոնեզ, պանիր", DescriptionRus = "кюфта, листья салата, помидоры, майонез, сыр" });
            burger.Add(new Product { Name = "Caesar burger", NameArm = "Կեսար բուրգեր", NameRus = "Цезарь бургер", Price = "1800", PicPath = "/Resources/Steak/caesar burger.jpg", Description = "chicken breast, cheese, lettuce, tomato, mayonnaise, jalapeno", DescriptionArm = "հավի կրծքամիս, պանիր, լետուս, լոլիկ, մայոնեզ, հալապենյո", DescriptionRus = "куриная грудка, сыр, листья салата, помидоры, майонез, халапеньо" });
            burger.Add(new Product { Name = "Grill vegie burger", NameArm = "Գրիլ վեջի բուրգեր", NameRus = "Гриль Веджибургер", Price = "750", PicPath = "/Resources/Steak/gril vegie burger.jpg", Description = "bell pepper, pumpkin, lettuce, broccoli, ketchup sauce, pickles", DescriptionArm = "բուլղարական պղպեղ, դդմիկ, լետուս, բրոկոլի, կետչուպի սոուս, թթու վարունգ     ", DescriptionRus = "болгарский перец, тыква, листья салата, брокколи, кетчуп соус, соленые огурцы" });


            categories.Add(new Categorie { Name = "Burger", NameArm = "Բուրգեր", NameRus = "Бургеры", Products = burger, CategoriePic = "/Resources/Steak/Cover/burger.jpg" });


            List<Product> sandwich = new List<Product>();

            sandwich.Add(new Product { Name = "Classic sandwich", NameArm = "Կլասիկ սենդվիչ", NameRus = "Сэндвич классический", Price = "850", PicPath = "/Resources/Steak/Classic sandwich.jpg", Description = "turkey ham, tomatoes, bread, lettuce, cheese, ketchup, mayonnaise", DescriptionArm = "հնդկահավի վետչինա, լոլիկ, հաց, հազար, պանիր, կետչուպ, մայոնեզ", DescriptionRus = "ветчина из индейки, помидоры, хлеб, листья салата, сыр, кетчуп, майонез" });
            sandwich.Add(new Product { Name = "Chicken club sandwich", NameArm = "Հավով քլաբ սենդվիչ", NameRus = "Клаб сэндвич с курицей", Price = "1500", PicPath = "/Resources/Steak/Chicken club sandwich.jpg", Description = "chicken, tomatoes, bacon, mayonnaise, cheese, ketchup", DescriptionArm = "հավի միս, լոլիկ, բեկոն, մայոնեզ, պանիր, կետչուպ ", DescriptionRus = "курятина, помидоры, бекон, майонез, сыр, кетчуп" });
            sandwich.Add(new Product { Name = "Ham and cheese sandwich", NameArm = "Հեմ Չիզ", NameRus = "Сэндвич с ветчиной и сыром", Price = "1300", PicPath = "/Resources/Steak/ham cheese sandwich.jpg", Description = "pork ham, tomatoes, cucumbers, mayonnaise, ketchup, lettuce", DescriptionArm = "խոզի վետչինա, լոլիկ, վարունգ, մայոնեզ, կետչուպ, հազար", DescriptionRus = "ветчина свиная, помидоры, огурцы, майонез, кетчуп, листья салата" });



            categories.Add(new Categorie { Name = "Sandwich", NameArm = "Սենդվիչներ", NameRus = "Сэндвичи", Products = sandwich, CategoriePic = "/Resources/Steak/Cover/sandwich.jpg" });

            List<Product> mainDishes = new List<Product>();

            mainDishes.Add(new Product { Name = "Chicken drumstick (2 pieces)", NameArm = "Հավի բդիկ 2 հատ", NameRus = "Куриные бёдрышки 2 шт.", Price = "950/1850/2650", PicPath = "/Resources/Steak/Chicken drumsticks 2 pieces.jpg", Description = "chicken legs, flour, breading, salt, pepper", DescriptionArm = "հավի բդիկ, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриные окорочки, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken drumstick (4 pieces)", NameArm = "Հավի բդիկ 4 հատ", NameRus = "Куриные бёдрышки 4 шт.", Price = "950/1850/2650", PicPath = "/Resources/Steak/Chicken drumsticks 4 pieces.jpg", Description = "chicken legs, flour, breading, salt, pepper", DescriptionArm = "հավի բդիկ, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриные окорочки, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken drumstick (6 pieces)", NameArm = "Հավի բդիկ 6 հատ", NameRus = "Куриные бёдрышки 6 шт.", Price = "950/1850/2650", PicPath = "/Resources/Steak/Chicken drumsticks 6 pieces.jpg", Description = "chicken legs, flour, breading, salt, pepper", DescriptionArm = "հավի բդիկ, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриные окорочки, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken wings (3 pieces)", NameArm = "Հավի թևիկ 3 հատ", NameRus = "Куриные крылышки 3 шт.", Price = "950/1550/2350", PicPath = "/Resources/Steak/Chicken wings 3 pieces.jpg", Description = "chicken wings, flour, breading, salt, pepper", DescriptionArm = "հավի թևիկ, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриные крылышки, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken wings (6 pieces)", NameArm = "Հավի թևիկ 6 հատ", NameRus = "Куриные крылышки 6 шт.", Price = "950/1550/2350", PicPath = "/Resources/Steak/Chicken wings 6 pieces.jpg", Description = "chicken wings, flour, breading, salt, pepper", DescriptionArm = "հավի թևիկ, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриные крылышки, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken wings (9 pieces)", NameArm = "Հավի թևիկ 9 հատ", NameRus = "Куриные крылышки 9 шт.", Price = "950/1550/2350", PicPath = "/Resources/Steak/Chicken wings 9 pieces.jpg", Description = "chicken wings, flour, breading, salt, pepper", DescriptionArm = "հավի թևիկ, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриные крылышки, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken nuggets (4 pieces)", NameArm = "Նագետ 4 հատ", NameRus = "Наггетсы 4/ шт.", Price = "950/1600/2500", PicPath = "/Resources/Steak/Chicken nuggets 4 pieces.jpg", Description = "chicken breast, flour, breading, salt, pepper", DescriptionArm = "հավի  կրծքամիս, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриная грудка, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken nuggets (8 pieces)", NameArm = "Նագետ 8 հատ", NameRus = "Наггетсы 8 шт.", Price = "950/1600/2500", PicPath = "/Resources/Steak/Chicken nuggets 8 pieces.jpg", Description = "chicken breast, flour, breading, salt, pepper", DescriptionArm = "հավի  կրծքամիս, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриная грудка, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken nuggets (12 pieces)", NameArm = "Նագետ 12 հատ", NameRus = "Наггетсы 12 шт.", Price = "950/1600/2500", PicPath = "/Resources/Steak/Chicken nuggets 12 pieces.jpg", Description = "chicken breast, flour, breading, salt, pepper", DescriptionArm = "հավի  կրծքամիս, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриная грудка, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken sticks (small)", NameArm = "Հավի ձողիկներ փոքր", NameRus = "Куриные палочки(маленькая порция)", Price = "950 / 1200", PicPath = "/Resources/Steak/Chicken sticks small.jpg", Description = "chicken breast, flour, breading, salt, pepper", DescriptionArm = "հավի կրծքամիս, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриная грудка, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "Chicken sticks (big)", NameArm = "Հավի ձողիկներ մեծ", NameRus = "Куриные палочки(большая порция)", Price = "950 / 1200", PicPath = "/Resources/Steak/Chicken sticks big.jpg", Description = "chicken breast, flour, breading, salt, pepper", DescriptionArm = "հավի կրծքամիս, ալյուր, պաքսիմատ, աղ, պղպեղ ", DescriptionRus = "куриная грудка, мука, панировка, соль, перец" });
            mainDishes.Add(new Product { Name = "French fries (small)", NameArm = "Ֆրի փոքր", NameRus = "Картофель фри (маленькая порция)", Price = "450/550", PicPath = "/Resources/Steak/French fries small.jpg", Description = "potatoes", DescriptionArm = "կարտոֆիլ", DescriptionRus = "картофель" });
            mainDishes.Add(new Product { Name = "French fries (big)", NameArm = "Ֆրի մեծ", NameRus = "Картофель фри (большая порция)", Price = "450/550", PicPath = "/Resources/Steak/French fries big.jpg", Description = "potatoes", DescriptionArm = "կարտոֆիլ", DescriptionRus = "картофель" });
            mainDishes.Add(new Product { Name = "Hash browns", NameArm = "Հաշբրաուն կարտոֆիլ", NameRus = "Хашбраун", Price = "0", PicPath = "/Resources/Steak/Hashbrown potato.jpg", Description = "potato, onion", DescriptionArm = "կարտոֆի, սոխ", DescriptionRus = "картофель, лук" });
            mainDishes.Add(new Product { Name = "Country Style Fried Potatoes(small portion)", NameArm = "Գյուղական ֆրի փոքր", NameRus = "Картофель по-деревенски(маленькая порция)", Price = "0", PicPath = "/Resources/Steak/village potatoes small.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            mainDishes.Add(new Product { Name = "Country Style Fried Potatoes(big portion)", NameArm = "Գյուղական ֆրի մեծ", NameRus = "Картофель по-деревенски(большая порция)", Price = "0", PicPath = "/Resources/Steak/village potatoes big.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            mainDishes.Add(new Product { Name = "Chips", NameArm = "Չիփս կարտոֆիլ", NameRus = "Картофельные чипсы", Price = "0", PicPath = "/Resources/Steak/potato chips.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            mainDishes.Add(new Product { Name = "Chips with becon", NameArm = "Չիփս բեկոնով", NameRus = "Чипсы с беконом", Price = "0", PicPath = "/Resources/Steak/bacon chips.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            mainDishes.Add(new Product { Name = "Sweet corn", NameArm = "Եգիպտացորեն", NameRus = "Кукуруза", Price = "0", PicPath = "/Resources/Steak/corn bbq.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            mainDishes.Add(new Product { Name = "Veggie rolls", NameArm = "Վեգի ռոլլեր", NameRus = "Вегетарианские роллы", Price = "0", PicPath = "/Resources/Steak/Veggie rolls.jpg", Description = "4 pieces", DescriptionArm = "4 հատ", DescriptionRus = "4 шт" });
            mainDishes.Add(new Product { Name = "Cheese sticks", NameArm = "Պանրի ձողեր", NameRus = "Сырные палочки", Price = "0", PicPath = "/Resources/Steak/Cheese sticks.jpg", Description = "4 pieces", DescriptionArm = "4 հատ", DescriptionRus = "4 шт" });


            categories.Add(new Categorie { Name = "Main dishes", NameArm = "Հիմնական ուտեստներ", NameRus = "Основные блюда", Products = mainDishes, CategoriePic = "/Resources/Steak/Cover/main dishes.jpg" });

            List<Product> sauces = new List<Product>();

            sauces.Add(new Product { Name = "Mustard sauce", NameArm = "Մանանեխի սոուս", NameRus = "Горчица", Price = "150", PicPath = "/Resources/Steak/Mustard sauce.jpg", Description = "mustard, pickled cucumber, mayonnaise", DescriptionArm = "մանանեխ, թթու վարունգ, մայոնեզ ", DescriptionRus = "горчица, соленые огурцы, майонез" });
            sauces.Add(new Product { Name = "Ketchup sauce", NameArm = "Կետչուպ", NameRus = "Кетчуп", Price = "150", PicPath = "/Resources/Steak/Ketchup.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Cheese sauce", NameArm = "Պանրային սոուս", NameRus = "Сырный соус", Price = "250", PicPath = "/Resources/Steak/cheese sauce.jpg", Description = "cheese, mayonnaise, cream", DescriptionArm = "պանիր, մայոնեզ, սերուցք ", DescriptionRus = "сыр, майонез, сливки" });
            sauces.Add(new Product { Name = "BBQ sauce", NameArm = "BBQ  սոուս", NameRus = "Соус BBQ ", Price = "350", PicPath = "/Resources/Steak/bbq sauce.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Sweet chili sauce", NameArm = "Sweet Chili սոուս", NameRus = "Сладкий Чили", Price = "300", PicPath = "/Resources/Steak/Sweet chilli sauce.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Pomegranate sauce", NameArm = "Նարշարաբ", NameRus = "Гранатовый соус", Price = "150", PicPath = "/Resources/Steak/Pomegranate sauce.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Teriyaki sauce", NameArm = "Տերիյակի սոուս", NameRus = "Соус терияки", Price = "250", PicPath = "/Resources/Steak/Teriyaki sauce.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Chilli sauce", NameArm = "Չիլի սոուս", NameRus = "Соус чили", Price = "250", PicPath = "/Resources/Steak/chili sauce.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Garlic sauce", NameArm = "Սխտորի սոուս", NameRus = "Чесночный соус", Price = "250", PicPath = "/Resources/Steak/garlic sauce.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });


            categories.Add(new Categorie { Name = "Sauces", NameArm = "Սոուսներ", NameRus = "Соусы", Products = sauces, CategoriePic = "/Resources/Steak/Cover/sauce.jpg" });


        }
    }
}
