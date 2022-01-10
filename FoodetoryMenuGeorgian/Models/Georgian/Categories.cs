using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.Georgian
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> khachapuri = new List<Product>();

            khachapuri.Add(new Product { Name = "Imeretian whole", NameArm = "Իմերիթական ամբողջական", NameRus = "Имеритинский целая", Price = "1500/350", PicPath = "/Resources/Georgian/Իմերիթական ամբողջ.jpg", Description = "cheese, egg, butter, flour, suluguni, chanakh", DescriptionArm = "պանիր, ձու, կարագ, ալյուր, սուլուգունի, չանախ", DescriptionRus = "сыр, яйцo, масло сливочное, мука, сулугуни, чанах" });
            khachapuri.Add(new Product { Name = "Imeretian 1 piece", NameArm = "Իմերիթական 1 կտոր", NameRus = "Имеритинский 1 кусок", Price = "1500/350", PicPath = "/Resources/Georgian/Իմերիթական կտոր.jpg", Description = "cheese, egg, butter, flour, suluguni, chanakh", DescriptionArm = "պանիր, ձու, կարագ, ալյուր, սուլուգունի, չանախ", DescriptionRus = "сыр, яйцo, масло сливочное, мука, сулугуни, чанах" });
            khachapuri.Add(new Product { Name = "Megrelian whole", NameArm = "Մեգրելական ամբողջական", NameRus = "Мегрельский целая", Price = "1800/450", PicPath = "/Resources/Georgian/Մեգրելական ամբողջ.jpg", Description = "cheese, egg, butter, flour, suluguni, chanakh", DescriptionArm = "պանիր, ձու, կարագ, ալյուր, սուլուգունի, չանախ", DescriptionRus = "сыр, яйцо, масло сливочное, мука, сулугуни, чанах" });
            khachapuri.Add(new Product { Name = "Megrelian 1 piece", NameArm = "Մեգրելական 1 կտոր", NameRus = "Мегрельский 1 кусок", Price = "1800/450", PicPath = "/Resources/Georgian/Մեգրելական կտոր.jpg", Description = "cheese, egg, butter, flour, suluguni, chanakh", DescriptionArm = "պանիր, ձու, կարագ, ալյուր, սուլուգունի, չանախ", DescriptionRus = "сыр, яйцо, масло сливочное, мука, сулугуни, чанах" });
            khachapuri.Add(new Product { Name = "Royal whole", NameArm = "Արքայական  ամբողջական", NameRus = "Королевский целая", Price = "2100/550", PicPath = "/Resources/Georgian/Արքայական խաչապուրի մեծ.jpg", Description = "cheese, egg, butter, suluguni, chanakh", DescriptionArm = "պանիր, ձու, կարագ, սուլուգունի, չանախ", DescriptionRus = "сыр, яйцо, масло сливочное, сулугуни, чанах" });
            khachapuri.Add(new Product { Name = "Royal 1 piece", NameArm = "Արքայական  1 կտոր", NameRus = "Королевский 1 кусок", Price = "2100/550", PicPath = "/Resources/Georgian/Արքայական, կտոր.jpg", Description = "cheese, egg, butter, suluguni, chanakh", DescriptionArm = "պանիր, ձու, կարագ, սուլուգունի, չանախ", DescriptionRus = "сыр, яйцо, масло сливочное, сулугуни, чанах" });
            khachapuri.Add(new Product { Name = "On a skewer /200 g/", NameArm = "Շամփուրի վրա /200 գր/ ", NameRus = "На шампуре/200 гр./", Price = "890", PicPath = "/Resources/Georgian/Շամփուրի վրա.jpg", Description = "cheese, egg, butter, flour, suluguni", DescriptionArm = "պանիր, ձու, կարագ, ալյուր, սուլուգունի", DescriptionRus = "сыр, яйцо, масло сливочное, мука, сулугуни" });
            khachapuri.Add(new Product { Name = "Adjarian, 1 egg /350 g/", NameArm = "Աջարական 1 ձու /350 գր/", NameRus = "Аджарский, 1 яйцо /350 гр./", Price = "1300", PicPath = "/Resources/Georgian/Աջարական խաչապուրի 1 ձու.jpg", Description = "cheese, egg, butter, flour", DescriptionArm = "պանիր, ձու, կարագ, ալյուր", DescriptionRus = "сыр, яйцо, масло сливочное, мука" });
            khachapuri.Add(new Product { Name = "Adjarian, 2 eggs /400 g/", NameArm = "Աջարական 2 ձու /400 գր/", NameRus = "Аджарский, 2 яйца /400 гр./", Price = "1400", PicPath = "/Resources/Georgian/Աջարական խաչապուրի 2 ձու.jpg", Description = "cheese, egg, butter, flour", DescriptionArm = "պանիր, ձու, կարագ, ալյուր", DescriptionRus = "сыр, яйцо, масло сливочное, мука" });
            khachapuri.Add(new Product { Name = "Adjarian with basturma, 1 egg /440 g/", NameArm = "Աջարական բաստուրմայով 1 ձու /440 գր/", NameRus = "Аджарский с бастурмой, 1 яйцо /440 гр./", Price = "1300", PicPath = "/Resources/Georgian/Աջարական խաչապուրի բաստուրմայով 1 ձու.jpg", Description = "basturma, cheese, egg, butter, flour", DescriptionArm = "բաստուրմա, պանիր, ձու, կարագ, ալյուր", DescriptionRus = "бастурма, сыр, яйцо, масло сливочное, мука" });
            khachapuri.Add(new Product { Name = "Adjarian with basturma, 2 eggs /440 g/", NameArm = "Աջարական բաստուրմայով 2 ձու /440 գր/", NameRus = "Аджарский с бастурмой, 2 яйца /440 гр./", Price = "1400", PicPath = "/Resources/Georgian/աջարական խաչապուրի բաստուրմայով 2 ձու.jpg", Description = "basturma, cheese, egg, butter, flour", DescriptionArm = "բաստուրմա, պանիր, ձու, կարագ, ալյուր", DescriptionRus = "бастурма, сыр, яйцо, масло сливочное, мука" });
            khachapuri.Add(new Product { Name = "Kubdari /250 g/", NameArm = "Կուբդարի /250 գր/", NameRus = "Кубдари /250 гр./", Price = "1500", PicPath = "/Resources/Georgian/Կուբդարի.jpg", Description = "pork, cheese, egg, butter, flour, onion", DescriptionArm = "խոզի միս, պանիր, ձու, կարագ, ալյուր, սոխ", DescriptionRus = "свинина, сыр, яйцо, масло сливочное, мука, лук" });
            khachapuri.Add(new Product { Name = "Lobiani /350 g/", NameArm = "Լոբիանի /350 գր/", NameRus = "Лобиани /350 гр./", Price = "690", PicPath = "/Resources/Georgian/Լոբիանի.jpg", Description = "red beans, cheese, egg, butter, flour, onion", DescriptionArm = "կարմիր լոբի, պանիր, ձու, կարագ, ալյուր, սոխ", DescriptionRus = "красная фасоль, сыр, яйцо, масло сливочное, мука, лук" });
            khachapuri.Add(new Product { Name = "Achma /250 g/", NameArm = "Աչմա /250գր/", NameRus = "Ачма /250 гр./", Price = "790", PicPath = "/Resources/Georgian/Աչմա .jpg", Description = "cheese, egg, butter, flour", DescriptionArm = "պանիր, ձու, կարագ, ալյուր", DescriptionRus = "сыр, яйцо, масло сливочное, мука" });




            categories.Add(new Categorie { Name = "Khachapuri", NameArm = "Խաչապուրի", NameRus = "Хачапури", Products = khachapuri, CategoriePic = "/Resources/Georgian/Cover/խաչապուրի.png" });


            List<Product> khinkali = new List<Product>();

            khinkali.Add(new Product { Name = "Khinkali/from 5 pcs/", NameArm = "Խինկալի /սկսած 5 հատից/ ", NameRus = "Хинкали /от 5 штук/", Price = "200", PicPath = "/Resources/Georgian/Խինկալի.jpg", Description = "beef, onion, lard, dough, coriander, butter", DescriptionArm = "տավարի միս, սոխ, սալ, խմոր, համեմ, կարագ", DescriptionRus = "говядина, лук, сало, тесто, кориандр, масло сливочное" });
            khinkali.Add(new Product { Name = "Fried khinkali/from 5 pcs /", NameArm = "Խինկալի տապակած/սկսած 5 հատից/", NameRus = "Хинкали жареные /от 5 шт/", Price = "220", PicPath = "/Resources/Georgian/Տապակած խինկալի.jpg", Description = "beef, onion, lard, dough, coriander, butter", DescriptionArm = "միս, խմոր, սոխ, սալ, տավարի միս, համեմ", DescriptionRus = "говядина, лук, сало, тесто, кориандр, масло сливочное" });


            categories.Add(new Categorie { Name = "Khinkali", NameArm = "Խինկալի", NameRus = "Хинкали", Products = khinkali, CategoriePic = "/Resources/Georgian/Cover/խինկալի.png" });


            List<Product> mainDishes = new List<Product>();

            mainDishes.Add(new Product { Name = "Ostri /300 g/", NameArm = "Օստրի/300 գր/", NameRus = "Остри /300 гр./", Price = "1450", PicPath = "/Resources/Georgian/Օստրի.jpg", Description = "beef, onion, pepper, tomato, coriander, garlic", DescriptionArm = "տավարի միս, սոխ, ծիծակ, տոմատ, համեմ,  սխտոր", DescriptionRus = "говядина, лук, перец, помидор, кориандр, чеснок" });
            mainDishes.Add(new Product { Name = "Chashashuli /250 g/", NameArm = "Չաշուշուլի /250 գր/", NameRus = "Чашашули /250 гр./", Price = "1200", PicPath = "/Resources/Georgian/Չաշուշուլի.jpg", Description = "beef, onion, pepper, tomato, garlic, basil, parsley, tomato sauce", DescriptionArm = "տավարի միս, պղպեղ, լոլիկ, սոխ, տոմատ, սխտոր, ռեհան, մաղադանոս", DescriptionRus = "говядина, лук, перец, помидор, чеснок, базилик, петрушка, томатный соус" });
            mainDishes.Add(new Product { Name = "Chakapuli /300 g/", NameArm = "Չաքապուլի/300 գր/", NameRus = "Чакапули /300 гр./", Price = "2500", PicPath = "/Resources/Georgian/Չաքապուլի.jpg", Description = "lamb, tarragon, green onions, white wine, tkemali, coriander, parsley", DescriptionArm = "գառի միս, թարխուն, կանաչ սոխ, սպիտակ գինի, տղեմալի, համեմ, մաղադանոս", DescriptionRus = "баранина, эстрагон, зеленый лук, белое вино, ткемали, кориандр, петрушка" });
            mainDishes.Add(new Product { Name = "Chkmeruli /300 g/", NameArm = "Չքմերուլի/300 գր/", NameRus = "Чкмерули /300 гр./", Price = "950", PicPath = "/Resources/Georgian/Չքմերուլի.jpg", Description = "chicken, sour cream, cream, garlic", DescriptionArm = "հավի միս, թթվասեր, սերուցք, սխտոր", DescriptionRus = "курятина, сметана, сливки, чеснок" });
            mainDishes.Add(new Product { Name = "Madam Bovari /300 g/", NameArm = "Մադամ բովարի/ 300 գր/", NameRus = "Мадам Бовари /300 гр./", Price = "1800", PicPath = "/Resources/Georgian/Մադամ բովարի.jpg", Description = "champignons, beef, tomatoes, onions, tarragon, suluguni", DescriptionArm = "շամպինյոն, տավարի միս, լոլիկ, սոխ, թարխուն,սուլուգունի", DescriptionRus = "шампиньоны, говядина, помидоры, лук, эстрагон, сулугуни" });
            mainDishes.Add(new Product { Name = "Odjakhuri /300 g/", NameArm = "Օջախուրի/300 գր/ ", NameRus = "Оджахури /300 гр./", Price = "1800", PicPath = "/Resources/Georgian/Օջախուրի.jpg", Description = "pork, onion, potato, pepper, coriander, garlic", DescriptionArm = "խոզի միս, սոխ, կարտոֆիլ, պղպեղ, համեմ, սխտոր", DescriptionRus = "свинина, лук, картофель, перец, кориандр, чеснок" });
            mainDishes.Add(new Product { Name = "Gonio /300 g/", NameArm = "Գոնիո  /300 գր/", NameRus = "Гонио /300 гр./", Price = "1800", PicPath = "/Resources/Georgian/Գոնիո.jpg", Description = "potatoes, mushrooms, beef, onion, suluguni", DescriptionArm = "կարտոֆիլ, շամպինյոն, տավարի միս, սոխ, սուլուգունի", DescriptionRus = "картофель, шампиньоны, говядина, лук, сулугуни" });
            mainDishes.Add(new Product { Name = "Kuchmachi /300 g/", NameArm = "Կուչմաչի /300 գր/", NameRus = "Кучмачи  /300 гр./", Price = "950", PicPath = "/Resources/Georgian/Կուչմաչի.jpg", Description = "chicken hearts and lungs, pepper, tomato, onion, garlic, tomato sauce", DescriptionArm = "հավի սիրտ եւ թոք,  պղպեղ, լոլիկ, սոխ, տոմատ, սխտոր", DescriptionRus = "куриное сердечки и легкие, перец, помидор, лук, чеснок, томатный соус" });
            mainDishes.Add(new Product { Name = "Stuffed champignons /250 g/", NameArm = "Լցոնած շամպինյոն /250 գր/", NameRus = "Шампиньоны фаршированные/250 гр./", Price = "1200", PicPath = "/Resources/Georgian/Լցոնած շամպինյոն.jpg", Description = "champignons, suluguni, sunflower oil", DescriptionArm = "շամպինյոն,  սուլուգունի, ձեթ", DescriptionRus = "шампиньоны, сулугуни, подсолнечное масло" });
            mainDishes.Add(new Product { Name = "Fried suluguni /3 pieces/ 200 g/", NameArm = "Տապաքած սուլուգունի/3 կտոր /200 գր/", NameRus = "Сулугуни жареный /3 куска/ 200 гр./", Price = "1200", PicPath = "/Resources/Georgian/Տապակած սուլուգունի.jpg", Description = "suluguni, eggs, bread crumbs", DescriptionArm = "սուլուգունի , ձու, պաքսիմատ", DescriptionRus = "сулугуни, яйца, панировочные сухари" });
            mainDishes.Add(new Product { Name = "Georgian potatoes", NameArm = "Վրացական կարտոֆիլ", NameRus = "Картошка по-грузински", Price = "750", PicPath = "/Resources/Georgian/Վրացական կարտոֆիլ նյու.jpg", Description = "potatoes, mayonnaise, dill, garlic, coriander seeds", DescriptionArm = "կարտոֆիլ, մայոնեզ, սամիթ, սխտոր, համեմի սերմ", DescriptionRus = "картофель, майонез, укроп, чеснок, семена кориандра" });
            mainDishes.Add(new Product { Name = "Chakhokhbili", NameArm = "Չախոխբիլի", NameRus = "Чахохбили", Price = "1800", PicPath = "/Resources/Georgian/Չախոխբիլի նյու.jpg", Description = "chicken wings, tomato, tomato paste, basil, bell pepper, hot pepper", DescriptionArm = "հավի թևիկ, լոլիկ, տոմատի մածուկ, ռեհան, բուլղարական պղպեղ, կծու պղպեղ", DescriptionRus = "куриные крылышки, помидоры, томатная паста, базилик, болгарский перец, острый перец" });
            mainDishes.Add(new Product { Name = "Mushroom odjakhuri", NameArm = "Սնկով օջախուրի", NameRus = "Оджахури с грибами", Price = "1100", PicPath = "/Resources/Georgian/Սնկով օջախուրի նյու.jpg", Description = "champignons, potatoes, bell peppers, tomatoes, onions, garlic", DescriptionArm = "շամպինիոն, կարտոֆիլ, բուլղարական պղպեղ, լոլիկ, սոխ, սխտոր", DescriptionRus = "шампиньоны, картофель, болгарский перец, помидоры, лук, чеснок" });
            mainDishes.Add(new Product { Name = "Chichilaki", NameArm = "Չիչիլակի", NameRus = "Чичилаки", Price = "1600", PicPath = "/Resources/Georgian/Չիչիլակի նյու.jpg", Description = "chicken breast, dill, sour cream, garlic, soy sauce", DescriptionArm = "հավի կրծքամիս, սամիթ, թթվասեր, սխտոր, սոյայի սոուս", DescriptionRus = "куриная грудка, укроп, сметана, чеснок, соевый соус" });
            mainDishes.Add(new Product { Name = "Pork money bags", NameArm = "Խոզի խուրջին", NameRus = "Мешок свиной", Price = "1600", PicPath = "/Resources/Georgian/Խուրջին խոզի մսով.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });



            categories.Add(new Categorie { Name = "Main dishes", NameArm = "Տաք ուտեստներ", NameRus = "Горячие блюда", Products = mainDishes, CategoriePic = "/Resources/Georgian/Cover/main dishes.png" });


            List<Product> coldDishes = new List<Product>();

            coldDishes.Add(new Product { Name = "Satsivi/300 g/", NameArm = "Սացիվի /300 գր/", NameRus = "Сациви /300 гр./", Price = "1600", PicPath = "/Resources/Georgian/Սացիվի.jpg", Description = "chicken, eggs, nuts", DescriptionArm = "ընկույզ, հավ, ձու", DescriptionRus = "курятина, яйца, орехи" });
            coldDishes.Add(new Product { Name = "Eggplant rolls/150g/", NameArm = "Սմբուկով ռուլետ/150գր/", NameRus = "Рулет аклажановый /150 гр./", Price = "850", PicPath = "/Resources/Georgian/Սմբուկով ռուլետ նյու.jpg", Description = "eggplant, walnuts, onions, coriander, garlic", DescriptionArm = "սմբուկ, ընկույզ, սոխ, համեմ, սխտոր", DescriptionRus = "баклажаны, грецкие орехи, лук, кориандр, чеснок" });
            coldDishes.Add(new Product { Name = "Kutaisi/250 g/", NameArm = "Քութաիսի /250 գր/", NameRus = "Кутаиси /250 гр./", Price = "650", PicPath = "/Resources/Georgian/Քութաիսի.jpg", Description = "tomatoes, cucumbers, onions, nuts, vinegar", DescriptionArm = "լոլիկ,վարունգ,սոխ,ընկույզ,քացախ", DescriptionRus = "помидоры, огурцы, лук, орехи, уксус" });
            coldDishes.Add(new Product { Name = "Sakartvelo/250 g/", NameArm = "Սակարթվելո /250 գր/", NameRus = "Сакартвело /250 гр./", Price = "1200", PicPath = "/Resources/Georgian/Սակարթվելո.jpg", Description = "beef, eggplant, walnuts, garlic, dill", DescriptionArm = "սմբուկ,տավարի միս, ընկույզ, սխտոր, սամիթ", DescriptionRus = "говядина, баклажаны, грецкие орехи, чеснок, укроп" });



            categories.Add(new Categorie { Name = "Cold dishes", NameArm = "Սառը ուտեստներ", NameRus = "Холодные блюда", Products = coldDishes, CategoriePic = "/Resources/Georgian/Cover/Cold dishes.png" });

            List<Product> soups = new List<Product>();

            soups.Add(new Product { Name = "Chicken soup /350 g/", NameArm = "Հավով ապուր /350 գր/   ", NameRus = "Куриный суп /350 гр./", Price = "1250", PicPath = "/Resources/Georgian/Հավով ապուր.jpg", Description = "chicken breast, peppers, carrots, onions", DescriptionArm = "հավի  կրծքամիս, պղպեղ, գազար, սոխ", DescriptionRus = "куриная грудка, перец, морковь, лук" });
            soups.Add(new Product { Name = "Lobio with walnuts /300 g/", NameArm = "Լոբիո ընկույզով /300 գր/", NameRus = "Лобио с грецкими орехами/300 гр./", Price = "650", PicPath = "/Resources/Georgian/Լոբիո ընկույզով.jpg", Description = "red beans, onions, nuts", DescriptionArm = "կարմիր լոբի, սոխ,  ընկույզ", DescriptionRus = "красная фасоль, лук, орехи" });
            soups.Add(new Product { Name = "Kharcho /350 g/", NameArm = "Խարչո  /350 գր/", NameRus = "Харчо /350 гр./", Price = "1200", PicPath = "/Resources/Georgian/Խարչո.jpg", Description = "beef, rice, onion, tomato sauce, tkemali", DescriptionArm = "տղեմալի, տավարի միս, բրինձ,  սոխ, տոմատ", DescriptionRus = "говядина, рис, лук, томатный соус, ткемали" });
            soups.Add(new Product { Name = "Mushroom soup /350 g/", NameArm = "Սնկապուր /350 գր/", NameRus = "Грибной суп/350 гр. /", Price = "850", PicPath = "/Resources/Georgian/Սնկով ապուր.jpg", Description = "mushrooms, potatoes, carrots, sour cream", DescriptionArm = "սունկ,  կարտոֆիլ, գազար,   թթվասեր", DescriptionRus = "грибы, картофель, морковь, сметана" });
            soups.Add(new Product { Name = "Pide with lamb /350g/", NameArm = "Փիդե գառան մսով /350 գր/", NameRus = "Пиде с бараниной /350 гр./ ", Price = "2500", PicPath = "/Resources/Georgian/Փիդե գառան մսով նյու.jpg", Description = "lamb, peas, onions, potatoes, garlic", DescriptionArm = "գառան միս, սիսեռ, սոխ, կարտոֆիլ, սխտոր", DescriptionRus = "баранина, нут (горох), лук, картофель, чеснок" });


            categories.Add(new Categorie { Name = "Soups", NameArm = "Ապուրներ", NameRus = "Супы", Products = soups, CategoriePic = "/Resources/Georgian/Cover/soups.png" });

            List<Product> salads = new List<Product>();

            salads.Add(new Product { Name = "Ureki/250 g/", NameArm = "Ուռեկի /250 գր/", NameRus = "Уреки /250 гр./", Price = "1100", PicPath = "/Resources/Georgian/Ուռեկի.jpg", Description = "beef, pepper, pickles, mayonnaise, dill", DescriptionArm = "տավարի միս, պղպեղ, թթու վարունգ, մայոնեզ, սամիթ", DescriptionRus = "говядина, перец, соленые огурцы, майонез, укроп" });
            salads.Add(new Product { Name = "Avlabar/250 g/", NameArm = "Հավլաբար /250 գր/", NameRus = "Авлабар /250 гр./", Price = "1400", PicPath = "/Resources/Georgian/Հավլաբար.jpg", Description = "chicken breast, carrots, mushrooms, mayonnaise, dill, garlic", DescriptionArm = "հավի  կրծքամիս, գազար, սունկ, մայոնեզ, սամիթ, սխտոր", DescriptionRus = "куриная грудка, морковь, грибы, майонез, укроп, чеснок" });
            salads.Add(new Product { Name = "Tbilisi/250 g/", NameArm = "Թբիլիսի  /250 գր/", NameRus = "Тбилиси /250 гр./", Price = "1100", PicPath = "/Resources/Georgian/Թբիլիսի.jpg", Description = "chicken breast, cabbage, mayonnaise, pepper", DescriptionArm = "կաղամբ, հավի  կրծքամիս, մայոնեզ, պղպեղ", DescriptionRus = "куриная грудка, капуста, майонез, перец" });
            salads.Add(new Product { Name = "Kari/250 g/", NameArm = "Կարի /250 գր/", NameRus = "Кари /250 гр./", Price = "1300", PicPath = "/Resources/Georgian/Կարի.jpg", Description = "chicken breast, pickled cucumbers, mayonnaise, dill", DescriptionArm = "հավի  կրծքամիս, թթու վարունգ, մայոնեզ, սամիթ", DescriptionRus = "куриная грудка, соленые огурцы, майонез, укроп" });
            salads.Add(new Product { Name = "Guria/250 g/", NameArm = "Գուրիա", NameRus = "Гуриа", Price = "1400", PicPath = "/Resources/Georgian/Գուրիա.jpg", Description = "chicken breast, pepper, corn, olives, mayonnaise", DescriptionArm = "հավի  կրծքամիս, պղպեղ, եգիպտացորեն, ձիթապտուղ,մայոնեզ", DescriptionRus = "куриная грудка, перец, кукуруза, оливки, майонез" });
            salads.Add(new Product { Name = "Rajuli", NameArm = "Ռաջուլի", NameRus = "Раджули", Price = "1100", PicPath = "/Resources/Georgian/Ռաճուլի նյու.jpg", Description = "ham, tomato, dill, suluguni, garlic", DescriptionArm = "խոզապուխտ, լոլիկ, սամիթ, սուլուգունի, սխտոր", DescriptionRus = "ветчина, помидоры, укроп, сулугуни, чеснок" });


            categories.Add(new Categorie { Name = "Salads", NameArm = "Աղցաններ", NameRus = "Салаты", Products = salads, CategoriePic = "/Resources/Georgian/Cover/Salads.png" });

            List<Product> sauces = new List<Product>();

            sauces.Add(new Product { Name = "Sacebeli /80 g/", NameArm = "Սացեբելի /80գր/", NameRus = "Сацебели /80 гр./", Price = "250", PicPath = "/Resources/Georgian/Սացեբելի.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Tkemali /80 g/", NameArm = "Տղեմալի /80գր/", NameRus = "Ткемали /80 гр./", Price = "250", PicPath = "/Resources/Georgian/Տղեմալի.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Adjika /80 g/", NameArm = "Աջիկա /80գր/", NameRus = "Аджика /80 гр./", Price = "250", PicPath = "/Resources/Georgian/Աջիկա.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Sour cream /80 g/", NameArm = "Թթվասեր /80գր/", NameRus = "Сметана /80 гр./", Price = "150", PicPath = "/Resources/Georgian/Թթվասերային.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });


            categories.Add(new Categorie { Name = "Sauces", NameArm = "Սոուսներ", NameRus = "Соусы", Products = sauces, CategoriePic = "/Resources/Georgian/Cover/Sauces.png" });

            List<Product> kebab = new List<Product>();

            kebab.Add(new Product { Name = "Chicken kebab/ 180 g", NameArm = "Հավի քաբաբ, կլասիկ/180գր/", NameRus = "Кебаб из курицы, классический/180 гр./ ", Price = "850", PicPath = "/Resources/Manghal/Հավի քաբաբ.jpg", Description = "chicken, lard, onion", DescriptionArm = " հավի միս, սալ, սոխ", DescriptionRus = "курица, сало, лук" });
            kebab.Add(new Product { Name = "Chicken kebab with mushrooms, 180g", NameArm = "Հավի քաբաբ, սնկով /180գր", NameRus = "Шашлык из курицы с грибами/180 гр./", Price = "950", PicPath = "/Resources/Manghal/Հավի քաբաբ սնկով.jpg", Description = "chicken, lard, mushrooms, onion", DescriptionArm = "հավի միս, սալ, սունկ, սոխ ", DescriptionRus = "курица, сало, грибы, лук" });
            kebab.Add(new Product { Name = "Chicken kebab with cheese, 180g", NameArm = "Հավի քաբաբ, պանրով /180գր", NameRus = "Кебаб из курицы с сыром/180 гр./", Price = "950", PicPath = "/Resources/Manghal/Հավի քաբաբ պանրով.jpg", Description = "chicken, lard, cheese, onion", DescriptionArm = "հավի միս, սալ, պանիր, սոխ ", DescriptionRus = "курица, сало, сыр, лук" });
            kebab.Add(new Product { Name = "Beef kebab, 180g", NameArm = "Տավարի քաբաբ, կլասիկ /180գր", NameRus = "Кебаб из говядины, классический/180 гр./", Price = "950", PicPath = "/Resources/Manghal/Տավարի քաբաբ.jpg", Description = "beef, chicken, lard, onion", DescriptionArm = "տավարի միս, հավի միս, սալ, սոխ ", DescriptionRus = "говядина, курица, сало, лук" });
            kebab.Add(new Product { Name = "Beef kebab with mushrooms, 180g", NameArm = "Տավարի քաբաբ, սնկով /180գր", NameRus = "Шашлык из говядины с грибами/180 гр./", Price = "1050", PicPath = "/Resources/Manghal/Տավարի քաբաբ սնկով.jpg", Description = "beef, chicken, lard, mushrooms, onion", DescriptionArm = "տավարի միս, հավի միս, սալ, սունկ, սոխ ", DescriptionRus = "говядина, курица, сало, грибы, лук" });
            kebab.Add(new Product { Name = "Beef kebab with cheese, 180g", NameArm = "Տավարի քաբաբ, պանրով /180գր", NameRus = "Кебаб из говядины с сыром/180 гр./", Price = "1050", PicPath = "/Resources/Manghal/Տավարի քաբաբ պանրով.jpg", Description = "beef, chicken, lard, cheese, onion", DescriptionArm = "տավարի միս, հավի միս, սալ, պանիր, սոխ ", DescriptionRus = "говядина, курица, сало, сыр, лук" });
            kebab.Add(new Product { Name = "Beef kebab with vegetables, 270g", NameArm = "Տավարի քաբաբ, բանջարեղենով /270 գր", NameRus = "Кебаб из говядины с овощами/270 гр./", Price = "1450", PicPath = "/Resources/Manghal/Տավարի քաբաբ բանջարեղենով.jpg", Description = "minced beef for kebab, tomatoes, hot pepper", DescriptionArm = "տավարի քաբաբի միս, լոլիկ, կծու պղպեղ ", DescriptionRus = "говяжий фарш для кебаба, помидоры, острый перец" });

            categories.Add(new Categorie { Name = "Kebab", NameArm = "Քաբաբ", NameRus = "Кебаб", Products = kebab, CategoriePic = "/Resources/Georgian/Cover/քաբաբ.jpg" });

            List<Product> ikibir = new List<Product>();

            ikibir.Add(new Product { Name = "Pork ikibir,200g", NameArm = "Խոզի իքիբիր/200գր", NameRus = "Икибир из свинины/200 гр./ ", Price = "1100", PicPath = "/Resources/Manghal/Խոզի իքիբիր.jpg", Description = "pork tenderloin,lard,spices", DescriptionArm = "խոզի փափկամիս,սալ,համեմունքներ", DescriptionRus = "свиная вырезка,сало,специи" });
            ikibir.Add(new Product { Name = "Chicken ikibir,200g", NameArm = "Հավի իքիբիր/200գր", NameRus = "Икибир из курицы/200 гр./ ", Price = "850", PicPath = "/Resources/Manghal/Հավի իքիբիր.jpg", Description = "chicken,spices", DescriptionArm = "հավի միս,համեմունքներ ", DescriptionRus = "курица,специи" });
            ikibir.Add(new Product { Name = "Arabic ikibir,200g", NameArm = "Արաբական իքիբիր/180գր", NameRus = "Икибир по - арабски/180 гр./ ", Price = "1200", PicPath = "/Resources/Manghal/Արաբական իքիբիր.jpg", Description = "chicken,spices", DescriptionArm = "հավի միս,համեմունքներ ", DescriptionRus = "курица,специи" });

            categories.Add(new Categorie { Name = "Ikibir", NameArm = "Իքիբիր", NameRus = "Икибир", Products = ikibir, CategoriePic = "/Resources/Georgian/Cover/իքիբիր.jpg" });

            List<Product> ghars = new List<Product>();

            ghars.Add(new Product { Name = "Pork Ghars BBQ", NameArm = "Խոզի ղարսի խորոված", NameRus = "Шашлык Карс из свинины", Price = "550", PicPath = "/Resources/Manghal/Խոզի ղարսի խորոված.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատի սոուս ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус" });
            ghars.Add(new Product { Name = "Chicken Ghars BBQ", NameArm = "Հավի ղարսի խորոված", NameRus = "Шашлык Карс из курицы", Price = "500", PicPath = "/Resources/Manghal/հավի ղարսի խորոված.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատի սոուս ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус" });

            categories.Add(new Categorie { Name = "Ghars", NameArm = "Ղարս", NameRus = "Шашлык Карс", Products = ghars, CategoriePic = "/Resources/Georgian/Cover/ղարս.jpg" });

            List<Product> porkBBQ = new List<Product>();

            porkBBQ.Add(new Product { Name = "Pork chop, 250g", NameArm = "Խոզի Չալաղաջ/250 գր/", NameRus = "Свиная отбивная/250 гр./ ", Price = "2300", PicPath = "/Resources/Manghal/Խոզի չալաղաջ.jpg", Description = "pork, spices", DescriptionArm = "խոզի միս, համեմունքներ", DescriptionRus = "свинина, специи" });
            porkBBQ.Add(new Product { Name = "Pork ribs, 300g", NameArm = "Խոզի Մատեր /300 գր/", NameRus = "Свиные ребрышки /300 гр./", Price = "2100", PicPath = "/Resources/Manghal/Խոզի մատեր.jpg", Description = "pork, spices", DescriptionArm = "խոզի միս, համեմունքներ", DescriptionRus = "свинина, специи" });

            categories.Add(new Categorie { Name = "Pork BBQ", NameArm = "Խոզի խորոված", NameRus = "Шашлык из свинины", Products = porkBBQ, CategoriePic = "/Resources/Georgian/Cover/Խոզի խորոված.jpg" });

            List<Product> shawarma = new List<Product>();

            shawarma.Add(new Product { Name = "Chicken shawarma in pitta bread", NameArm = "Հավի շաուրմա, լոշիկով", NameRus = "Куриная шаурма в лепешке", Price = "650", PicPath = "/Resources/Manghal/Հավի շաուրմա լոշիկով.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce, tomato, pickled cucumber, mayonnaise, potatoes", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատ, լոլիկ, թթու վարունգ, մայոնեզ, կարտոֆիլ ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус, помидор, соленые огурцы, майонез, картофель" });
            shawarma.Add(new Product { Name = "Chicken shawarma, with bread", NameArm = "Հավի շաուրմա, հացով", NameRus = "Куриная шаурма в хлебе", Price = "500", PicPath = "/Resources/Manghal/Հավի շաուրմա հացով.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce, tomato, pickled cucumber, mayonnaise, potatoes", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատ, լոլիկ, թթու վարունգ, մայոնեզ, կարտոֆիլ ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус, помидор, соленые огурцы, майонез, картофель" });
            shawarma.Add(new Product { Name = "Chicken shawarma, with lavash", NameArm = "Հավի շաուրմա, լավաշով", NameRus = "Куриная шаурма в лаваше", Price = "850", PicPath = "/Resources/Manghal/Հավի շաուրմա լավաշով.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce, tomato, pickled cucumber, mayonnaise, potatoes", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատ, լոլիկ, թթու վարունգ, մայոնեզ, կարտոֆիլ ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус, помидор, соленые огурцы, майонез, картофель" });
            shawarma.Add(new Product { Name = "Pork shawarma in pitta bread", NameArm = "Խոզի շաուրմա, լոշիկով", NameRus = "Шаурма из свинины в лепешке", Price = "750", PicPath = "/Resources/Manghal/Խոզի շաուրմա լոշիկով.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce, tomato, pickled cucumber, mayonnaise, potatoes", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատ, լոլիկ, թթու վարունգ, մայոնեզ, կարտոֆիլ ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус, помидор, соленые огурцы, майонез, картофель" });
            shawarma.Add(new Product { Name = "Pork shawarma, with bread", NameArm = "Խոզի շաուրմա, հացով", NameRus = "Шаурма из свинины в хлебе", Price = "550", PicPath = "/Resources/Manghal/Խոզի շաուրմա հացով.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce, tomato, pickled cucumber, mayonnaise, potatoes", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատ, լոլիկ, թթու վարունգ, մայոնեզ, կարտոֆիլ ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус, помидор, соленые огурцы, майонез, картофель" });
            shawarma.Add(new Product { Name = "Pork shawarma, with lavash", NameArm = "Խոզի շաուրմա, լավաշով", NameRus = "Шаурма из свинины в лаваше", Price = "950", PicPath = "/Resources/Manghal/Խոզի շաուրմա լավաշով.jpg", Description = "meat, greens, onion, hot pepper, garlic sauce, tomato sauce, tomato, pickled cucumber, mayonnaise, potatoes", DescriptionArm = "միս, կանաչի, սոխ, կծու պղպեղ, սխտորի սոուս, տոմատ, լոլիկ, թթու վարունգ, մայոնեզ, կարտոֆիլ ", DescriptionRus = "мясо, зелень, лук, острый перец, чесночный соус, томатный соус, помидор, соленые огурцы, майонез, картофель" });

            categories.Add(new Categorie { Name = "Shawarma", NameArm = "Շաուրմա", NameRus = "Шаурма", Products = shawarma, CategoriePic = "/Resources/Georgian/Cover/շաուրմա.jpg" });

            List<Product> onthefire = new List<Product>();


            onthefire.Add(new Product { Name = "Potato BBQ, 200g", NameArm = "Պլեճ/200 գր/", NameRus = "Картофель Плеч/200 гр./ ", Price = "450", PicPath = "/Resources/Manghal/Պլեճ կարտոֆիլ.jpg", Description = "potatoes, spices", DescriptionArm = "կարտոֆիլ, համեմունքներ", DescriptionRus = "картофель, специи" });
            onthefire.Add(new Product { Name = "Mushrooms BBQ. 200g", NameArm = "Սունկ /200 գր/", NameRus = "Грибы /200 гр./ ", Price = "550", PicPath = "/Resources/Manghal/Խորոված սունկ.jpg", Description = "mushrooms, spices", DescriptionArm = "սունկ, համեմունքներ", DescriptionRus = "грибы, специи" });
            onthefire.Add(new Product { Name = "BBQ chicken wings", NameArm = "Հավի թևիկ", NameRus = "Куриные крылышки", Price = "790", PicPath = "/Resources/Manghal/Հավի թևիկներ.jpg", Description = "chicken wings, spices", DescriptionArm = "հավի թևիկ, համեմունքներ", DescriptionRus = "куриные крылышки, специи" });
            onthefire.Add(new Product { Name = "BBQ chicken breast, 200g", NameArm = "Հավի կրծքամիս /200 գր/", NameRus = "Куриная грудка /200 гр./", Price = "1250", PicPath = "/Resources/Manghal/Հավի դոշի խորոված.jpg", Description = "chicken breast, spices", DescriptionArm = "հավի դոշ, համեմունքներ", DescriptionRus = "куриная грудка, специи" });
            onthefire.Add(new Product { Name = "Beef BBQ, 270g", NameArm = "Տավարի մսի խորոված /270 գր/", NameRus = "Шашлык из говядины /270 гр./", Price = "2300", PicPath = "/Resources/Manghal/Տավարի խորոված.jpg", Description = "beef, spices", DescriptionArm = "տավարի միս, համեմունքներ", DescriptionRus = "говядина, специи" });
            onthefire.Add(new Product { Name = "Lahmacun, small ", NameArm = "Լահմաջո, փոքր ", NameRus = "Лахмаджун, маленький ", Price = "250", PicPath = "/Resources/Manghal/Լահմաջո փոքր.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            onthefire.Add(new Product { Name = "Lahmacun, large ", NameArm = "Լահմաջո, մեծ ", NameRus = "Лахмаджун, большой ", Price = "390", PicPath = "/Resources/Manghal/Լահմաջո մեծ.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            onthefire.Add(new Product { Name = "Lahmacun, with cheese", NameArm = "Լահմաջո, պանրով", NameRus = "Лахмаджун, с сыром", Price = "450", PicPath = "/Resources/Manghal/Լահմաջո պանրով.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            onthefire.Add(new Product { Name = "Lavash ", NameArm = "Լավաշ ", NameRus = "Лаваш ", Price = "120", PicPath = "/Resources/Manghal/Լավաշ.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });

            categories.Add(new Categorie { Name = "On the fire", NameArm = "Կրակի վրա", NameRus = "На костре", Products = onthefire, CategoriePic = "/Resources/Georgian/Cover/կրակի վրա.jpg" });

        }
    }
}
