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
            khachapuri.Add(new Product { Name = "Royal /130 g/", NameArm = "Արքայական  /130 գր/", NameRus = "Королевский /130 гр./", Price = "2100/550", PicPath = "/Resources/Georgian/Արքայական խաչապուրի.jpg", Description = "cheese, egg, butter, suluguni, chanakh", DescriptionArm = "պանիր, ձու, կարագ, սուլուգունի, չանախ", DescriptionRus = "сыр, яйцо, масло сливочное, сулугуни, чанах" });
            khachapuri.Add(new Product { Name = "On a skewer /200 g/", NameArm = "Շամփուրի վրա /200 գր/ ", NameRus = "На шампуре / 200 гр./", Price = "890", PicPath = "/Resources/Georgian/Շամփուրի վրա.jpg", Description = "cheese, egg, butter, flour, suluguni", DescriptionArm = "պանիր, ձու, կարագ, ալյուր, սուլուգունի", DescriptionRus = "сыр, яйцо, масло сливочное, мука, сулугуни" });
            khachapuri.Add(new Product { Name = "Adjarian, 1 egg /350 g/", NameArm = "Աջարական 1 ձու /350 գր/", NameRus = "Аджарский, 1 яйцо /350 гр./", Price = "1300", PicPath = "/Resources/Georgian/Աջարական խաչապուրի 1 ձու.jpg", Description = "cheese, egg, butter, flour", DescriptionArm = "պանիր, ձու, կարագ, ալյուր", DescriptionRus = "сыр, яйцо, масло сливочное, мука" });
            khachapuri.Add(new Product { Name = "Adjarian, 2 eggs /400 g/", NameArm = "Աջարական 2 ձու /400 գր/", NameRus = "Аджарский, 2 яйца /400 гр./", Price = "1400", PicPath = "/Resources/Georgian/Աջարական խաչապուրի 2 ձու.jpg", Description = "cheese, egg, butter, flour", DescriptionArm = "պանիր, ձու, կարագ, ալյուր", DescriptionRus = "сыр, яйцо, масло сливочное, мука" });
            khachapuri.Add(new Product { Name = "Kubdari /250 g/", NameArm = "Կուբդարի /250 գր/", NameRus = "Кубдари /250 гр./", Price = "1500", PicPath = "/Resources/Georgian/Կուբդարի.jpg", Description = "pork, cheese, egg, butter, flour, onion", DescriptionArm = "խոզի միս, պանիր, ձու, կարագ, ալյուր, սոխ", DescriptionRus = "свинина, сыр, яйцо, масло сливочное, мука, лук" });
            khachapuri.Add(new Product { Name = "Lobiani /350 g/", NameArm = "Լոբիանի /350 գր/", NameRus = "Лобиани /350 гр./", Price = "690", PicPath = "/Resources/Georgian/Լոբիանի.jpg", Description = "red beans, cheese, egg, butter, flour, onion", DescriptionArm = "կարմիր լոբի, պանիր, ձու, կարագ, ալյուր, սոխ", DescriptionRus = "красная фасоль, сыр, яйцо, масло сливочное, мука, лук" });
            khachapuri.Add(new Product { Name = "Achma /250 g/", NameArm = "Աչմա /250գր/", NameRus = "Ачма /250 гр./", Price = "790", PicPath = "/Resources/Georgian/Աչմա .jpg", Description = "cheese, egg, butter, flour", DescriptionArm = "պանիր, ձու, կարագ, ալյուր", DescriptionRus = "сыр, яйцо, масло сливочное, мука" });




            categories.Add(new Categorie { Name = "Khachapuri", NameArm = "Խաչապուրի", NameRus = "Хачапури", Products = khachapuri });


            List<Product> khinkali = new List<Product>();

            khinkali.Add(new Product { Name = "Khinkali / from 5 pcs/", NameArm = "Խինկալի /սկսած 5 հատից/ ", NameRus = "Хинкали /от 5 штук/", Price = "200", PicPath = "/Resources/Georgian/Խինկալի.jpg", Description = "beef, onion, lard, dough, coriander, butter", DescriptionArm = "տավարի միս, սոխ, սալ, խմոր, համեմ, կարագ", DescriptionRus = "говядина, лук, сало, тесто, кориандр, масло сливочное" });
            khinkali.Add(new Product { Name = "Fried khinkali / from 5 pcs /", NameArm = "Խինկալի տապակած/սկսած 5 հատից/", NameRus = "Хинкали жареные /от 5 шт/", Price = "220", PicPath = "/Resources/Georgian/Տապակած խինկալի.jpg", Description = "beef, onion, lard, dough, coriander, butter", DescriptionArm = "միս, խմոր, սոխ, սալ, տավարի միս, համեմ", DescriptionRus = "говядина, лук, сало, тесто, кориандр, масло сливочное" });


            categories.Add(new Categorie { Name = "Khinkali", NameArm = "Խինկալի", NameRus = "Хинкали", Products = khinkali });


            List<Product> mainDishes = new List<Product>();

            mainDishes.Add(new Product { Name = "Ostri /300 g/", NameArm = "Օստրի / 300 գր/", NameRus = "Остри /300 гр./", Price = "1450", PicPath = "/Resources/Georgian/Օստրի.jpg", Description = "beef, onion, pepper, tomato, coriander, garlic", DescriptionArm = "տավարի միս, սոխ, ծիծակ, տոմատ, համեմ,  սխտոր", DescriptionRus = "говядина, лук, перец, помидор, кориандр, чеснок" });
            mainDishes.Add(new Product { Name = "Chashashuli /250 g/", NameArm = "Չաշուշուլի /250 գր/", NameRus = "Чашашули /250 гр./", Price = "1200", PicPath = "/Resources/Georgian/Չաշուշուլի.jpg", Description = "beef, onion, pepper, tomato, garlic, basil, parsley, tomato sauce", DescriptionArm = "տավարի միս, պղպեղ, լոլիկ, սոխ, տոմատ, սխտոր, ռեհան, մաղադանոս", DescriptionRus = "говядина, лук, перец, помидор, чеснок, базилик, петрушка, томатный соус" });
            mainDishes.Add(new Product { Name = "Chakapuli /300 g/", NameArm = "Չաքապուլի / 300 գր/", NameRus = "Чакапули /300 гр./", Price = "2500", PicPath = "/Resources/Georgian/Չաքապուլի.jpg", Description = "lamb, tarragon, green onions, white wine, tkemali, coriander, parsley", DescriptionArm = "գառի միս, թարխուն, կանաչ սոխ, սպիտակ գինի, տղեմալի, համեմ, մաղադանոս", DescriptionRus = "баранина, эстрагон, зеленый лук, белое вино, ткемали, кориандр, петрушка" });
            mainDishes.Add(new Product { Name = "Chkmeruli /300 g/", NameArm = "Չքմերուլի / 300 գր/", NameRus = "Чкмерули /300 гр./", Price = "950", PicPath = "/Resources/Georgian/Չքմերուլի.jpg", Description = "chicken, sour cream, cream, garlic", DescriptionArm = "հավի միս, թթվասեր, սերուցք, սխտոր", DescriptionRus = "курятина, сметана, сливки, чеснок" });
            mainDishes.Add(new Product { Name = "Madam Bovari /300 g/", NameArm = "Մադամ բովարի/ 300 գր/", NameRus = "Мадам Бовари /300 гр./", Price = "1800", PicPath = "/Resources/Georgian/Մադամ բովարի.jpg", Description = "champignons, beef, tomatoes, onions, tarragon, suluguni", DescriptionArm = "շամպինյոն, տավարի միս, լոլիկ, սոխ, թարխուն,սուլուգունի", DescriptionRus = "шампиньоны, говядина, помидоры, лук, эстрагон, сулугуни" });
            mainDishes.Add(new Product { Name = "Odjakhuri /300 g/", NameArm = "Օջախուրի / 300 գր/ ", NameRus = "Оджахури /300 гр./", Price = "1800", PicPath = "/Resources/Georgian/Օջախուրի.jpg", Description = "pork, onion, potato, pepper, coriander, garlic", DescriptionArm = "խոզի միս, սոխ, կարտոֆիլ, պղպեղ, համեմ, սխտոր", DescriptionRus = "свинина, лук, картофель, перец, кориандр, чеснок" });
            mainDishes.Add(new Product { Name = "Gonio /300 g/", NameArm = "Գոնիո  /300 գր/", NameRus = "Гонио /300 гр./", Price = "1800", PicPath = "/Resources/Georgian/Գոնիո.jpg", Description = "potatoes, mushrooms, beef, onion, suluguni", DescriptionArm = "կարտոֆիլ, շամպինյոն, տավարի միս, սոխ, սուլուգունի", DescriptionRus = "картофель, шампиньоны, говядина, лук, сулугуни" });
            mainDishes.Add(new Product { Name = "Kuchmachi /300 g/", NameArm = "Կուչմաչի /300 գր/", NameRus = "Кучмачи  /300 гр./", Price = "950", PicPath = "/Resources/Georgian/Կուչմաչի.jpg", Description = "chicken hearts and lungs, pepper, tomato, onion, garlic, tomato sauce", DescriptionArm = "հավի սիրտ եւ թոք,  պղպեղ, լոլիկ, սոխ, տոմատ, սխտոր", DescriptionRus = "куриное сердечки и легкие, перец, помидор, лук, чеснок, томатный соус" });
            mainDishes.Add(new Product { Name = "Stuffed champignons /250 g/", NameArm = "Լցոնած շամպինյոն /250 գր/", NameRus = "Шампиньоны фаршированные / 250 гр./", Price = "1200", PicPath = "/Resources/Georgian/Լցոնած շամպինյոն.jpg", Description = "champignons, suluguni, sunflower oil", DescriptionArm = "շամպինյոն,  սուլուգունի, ձեթ", DescriptionRus = "шампиньоны, сулугуни, подсолнечное масло" });
            mainDishes.Add(new Product { Name = "Fried suluguni /3 pieces/ 200 g/", NameArm = "Տապաքած սուլուգունի/3 կտոր /200 գր/", NameRus = "Сулугуни жареный /3 куска/ 200 гр./", Price = "1200", PicPath = "/Resources/Georgian/Տապակած սուլուգունի.jpg", Description = "suluguni, eggs, bread crumbs", DescriptionArm = "սուլուգունի , ձու, պաքսիմատ", DescriptionRus = "сулугуни, яйца, панировочные сухари" });
            mainDishes.Add(new Product { Name = "Fried oyster mushrooms / 300 g/", NameArm = "Տապակած կախասունկ /300 գր/", NameRus = "Вешенки жареные / 300 гр./", Price = "950", PicPath = "/Resources/Georgian/Տապակած կախասունկ.jpg", Description = "oyster mushrooms, sunflower oil, onions", DescriptionArm = "կախասունկ, ձեթ, սոխ", DescriptionRus = "вешенки, подсолнечное масло, лук" });
            mainDishes.Add(new Product { Name = "Georgian potatoes", NameArm = "Վրացական կարտոֆիլ", NameRus = "Картошка по-грузински", Price = "750", PicPath = "/Resources/Georgian/Վրացական կարտոֆիլ նյու.jpg", Description = "potatoes, mayonnaise, dill, garlic, coriander seeds", DescriptionArm = "կարտոֆիլ, մայոնեզ, սամիթ, սխտոր, համեմի սերմ", DescriptionRus = "картофель, майонез, укроп, чеснок, семена кориандра" });
            mainDishes.Add(new Product { Name = "Chakhokhbili", NameArm = "Չախոխբիլի", NameRus = "Чахохбили", Price = "1800", PicPath = "/Resources/Georgian/Չախոխբիլի նյու.jpg", Description = "chicken wings, tomato, tomato paste, basil, bell pepper, hot pepper", DescriptionArm = "հավի թևիկ, լոլիկ, տոմատի մածուկ, ռեհան, բուլղարական պղպեղ, կծու պղպեղ", DescriptionRus = "куриные крылышки, помидоры, томатная паста, базилик, болгарский перец, острый перец" });
            mainDishes.Add(new Product { Name = "Mushroom odjakhuri", NameArm = "Սնկով օջախուրի", NameRus = "Оджахури с грибами", Price = "1100", PicPath = "/Resources/Georgian/Սնկով օջախուրի նյու.jpg", Description = "champignons, potatoes, bell peppers, tomatoes, onions, garlic", DescriptionArm = "շամպինիոն, կարտոֆիլ, բուլղարական պղպեղ, լոլիկ, սոխ, սխտոր", DescriptionRus = "шампиньоны, картофель, болгарский перец, помидоры, лук, чеснок" });
            mainDishes.Add(new Product { Name = "Chichilaki", NameArm = "Չիչիլակի", NameRus = "Чичилаки", Price = "1600", PicPath = "/Resources/Georgian/Չիչիլակի նյու.jpg", Description = "chicken breast, dill, sour cream, garlic, soy sauce", DescriptionArm = "հավի կրծքամիս, սամիթ, թթվասեր, սխտոր, սոյայի սոուս", DescriptionRus = "куриная грудка, укроп, сметана, чеснок, соевый соус" });



            categories.Add(new Categorie { Name = "Main dishes", NameArm = "Տաք ուտեստներ", NameRus = "Горячие блюда", Products = mainDishes });


            List<Product> coldDishes = new List<Product>();

            coldDishes.Add(new Product { Name = "Satsivi / 300 g/", NameArm = "Սացիվի /300 գր/", NameRus = "Сациви /300 гр./", Price = "1600", PicPath = "/Resources/Georgian/Սացիվի.jpg", Description = "chicken, eggs, nuts", DescriptionArm = "ընկույզ, հավ, ձու", DescriptionRus = "курятина, яйца, орехи" });
            coldDishes.Add(new Product { Name = "Phali with eggplants, beets, beans, spinach / 50g/", NameArm = "Պխալի սմբուկով, բազուկով,լոբով, սպանախով / 50 գր / ", NameRus = "Пхали с баклажанами, свеклой, фасолью, шпинатом / 50гр. / ", Price = "470", PicPath = "/Resources/Georgian/Պխալի.jpg", Description = "eggplants, beets, beans, spinach, walnuts, garlic, spices", DescriptionArm = "ընկույզ, սխտոր, համեմունքներ, սմբուկ, բազուկ, լոբի, սպանախ", DescriptionRus = "баклажаны, свекла, фасоль, шпинат, грецкие орехи, чеснок, специи" });
            coldDishes.Add(new Product { Name = "Eggplant rolls / 150g/", NameArm = "Սմբուկով ռուլետ/150գր/", NameRus = "Рулет аклажановый /150 гр./", Price = "850", PicPath = "/Resources/Georgian/Սմբուկով ռուլետ նյու.jpg", Description = "eggplant, walnuts, onions, coriander, garlic", DescriptionArm = "սմբուկ, ընկույզ, սոխ, համեմ, սխտոր", DescriptionRus = "баклажаны, грецкие орехи, лук, кориандр, чеснок" });
            coldDishes.Add(new Product { Name = "Kutaisi / 250 g/", NameArm = "Քութաիսի /250 գր/", NameRus = "Кутаиси /250 гр./", Price = "650", PicPath = "/Resources/Georgian/Քութաիսի.jpg", Description = "tomatoes, cucumbers, onions, nuts, vinegar", DescriptionArm = "լոլիկ,վարունգ,սոխ,ընկույզ,քացախ", DescriptionRus = "помидоры, огурцы, лук, орехи, уксус" });
            coldDishes.Add(new Product { Name = "Sakartvelo / 250 g/", NameArm = "Սակարթվելո /250 գր/", NameRus = "Сакартвело /250 гр./", Price = "1200", PicPath = "/Resources/Georgian/Սակարթվելո.jpg", Description = "beef, eggplant, walnuts, garlic, dill", DescriptionArm = "սմբուկ,տավարի միս, ընկույզ, սխտոր, սամիթ", DescriptionRus = "говядина, баклажаны, грецкие орехи, чеснок, укроп" });



            categories.Add(new Categorie { Name = "Cold dishes", NameArm = "Սառը ուտեստներ", NameRus = "Холодные блюда", Products = coldDishes });

            List<Product> soups = new List<Product>();

            soups.Add(new Product { Name = "Chicken soup /350 g/", NameArm = "Հավով ապուր /350 գր/   ", NameRus = "Куриный суп /350 гр./", Price = "1250", PicPath = "/Resources/Georgian/Հավով ապուր.jpg", Description = "chicken breast, peppers, carrots, onions", DescriptionArm = "հավի  կրծքամիս, պղպեղ, գազար, սոխ", DescriptionRus = "куриная грудка, перец, морковь, лук" });
            soups.Add(new Product { Name = "Lobio with walnuts /300 g/", NameArm = "Լոբիո ընկույզով /300 գր/", NameRus = "Лобио с грецкими орехами / 300 гр./", Price = "650", PicPath = "/Resources/Georgian/Լոբիո ընկույզով.jpg", Description = "red beans, onions, nuts", DescriptionArm = "կարմիր լոբի, սոխ,  ընկույզ", DescriptionRus = "красная фасоль, лук, орехи" });
            soups.Add(new Product { Name = "Kharcho /350 g/", NameArm = "Խարչո  /350 գր/", NameRus = "Харчо /350 гр./", Price = "1200", PicPath = "/Resources/Georgian/Խարչո.jpg", Description = "beef, rice, onion, tomato sauce, tkemali", DescriptionArm = "տղեմալի, տավարի միս, բրինձ,  սոխ, տոմատ", DescriptionRus = "говядина, рис, лук, томатный соус, ткемали" });
            soups.Add(new Product { Name = "Mushroom soup /350 g/", NameArm = "Սնկապուր /350 գր/", NameRus = "Грибной суп / 350 гр. /", Price = "850", PicPath = "/Resources/Georgian/Սնկով ապուր.jpg", Description = "mushrooms, potatoes, carrots, sour cream", DescriptionArm = "սունկ,  կարտոֆիլ, գազար,   թթվասեր", DescriptionRus = "грибы, картофель, морковь, сметана" });
            soups.Add(new Product { Name = "Pide with lamb /350g/", NameArm = "Փիդե գառան մսով /350 գր/", NameRus = "Пиде с бараниной  / 350 гр./ ", Price = "2500", PicPath = "/Resources/Georgian/Փիդե գառան մսով նյու.jpg", Description = "lamb, peas, onions, potatoes, garlic", DescriptionArm = "գառան միս, սիսեռ, սոխ, կարտոֆիլ, սխտոր", DescriptionRus = "баранина, нут (горох), лук, картофель, чеснок" });


            categories.Add(new Categorie { Name = "Soups", NameArm = "Ապուրներ", NameRus = "Супы", Products = soups });

            List<Product> salads = new List<Product>();

            salads.Add(new Product { Name = "Ureki / 250 g/", NameArm = "Ուռեկի /250 գր/", NameRus = "Уреки /250 гр./", Price = "1100", PicPath = "/Resources/Georgian/Ուռեկի.jpg", Description = "beef, pepper, pickles, mayonnaise, dill", DescriptionArm = "տավարի միս, պղպեղ, թթու վարունգ, մայոնեզ, սամիթ", DescriptionRus = "говядина, перец, соленые огурцы, майонез, укроп" });
            salads.Add(new Product { Name = "Avlabar / 250 g/", NameArm = "Հավլաբար /250 գր/", NameRus = "Авлабар /250 гр./", Price = "1400", PicPath = "/Resources/Georgian/Հավլաբար.jpg", Description = "chicken breast, carrots, mushrooms, mayonnaise, dill, garlic", DescriptionArm = "հավի  կրծքամիս, գազար, սունկ, մայոնեզ, սամիթ, սխտոր", DescriptionRus = "куриная грудка, морковь, грибы, майонез, укроп, чеснок" });
            salads.Add(new Product { Name = "Tbilisi / 250 g/", NameArm = "Թբիլիսի  /250 գր/", NameRus = "Тбилиси /250 гр./", Price = "1100", PicPath = "/Resources/Georgian/Թբիլիսի.jpg", Description = "chicken breast, cabbage, mayonnaise, pepper", DescriptionArm = "կաղամբ, հավի  կրծքամիս, մայոնեզ, պղպեղ", DescriptionRus = "куриная грудка, капуста, майонез, перец" });
            salads.Add(new Product { Name = "Kari / 250 g/", NameArm = "Կարի /250 գր/", NameRus = "Кари /250 гр./", Price = "1300", PicPath = "/Resources/Georgian/Կարի.jpg", Description = "chicken breast, pickled cucumbers, mayonnaise, dill", DescriptionArm = "հավի  կրծքամիս, թթու վարունգ, մայոնեզ, սամիթ", DescriptionRus = "куриная грудка, соленые огурцы, майонез, укроп" });
            salads.Add(new Product { Name = "Guria / 250 g/", NameArm = "Գուրիա", NameRus = "Гуриа", Price = "1400", PicPath = "/Resources/Georgian/Գուրիա.jpg", Description = "chicken breast, pepper, corn, olives, mayonnaise", DescriptionArm = "հավի  կրծքամիս, պղպեղ, եգիպտացորեն, ձիթապտուղ,մայոնեզ", DescriptionRus = "куриная грудка, перец, кукуруза, оливки, майонез" });
            salads.Add(new Product { Name = "Rajuli", NameArm = "Ռաջուլի", NameRus = "Раджули", Price = "1100", PicPath = "/Resources/Georgian/Ռաճուլի նյու.jpg", Description = "ham, tomato, dill, suluguni, garlic", DescriptionArm = "խոզապուխտ, լոլիկ, սամիթ, սուլուգունի, սխտոր", DescriptionRus = "ветчина, помидоры, укроп, сулугуни, чеснок" });


            categories.Add(new Categorie { Name = "Salads", NameArm = "Աղցաններ", NameRus = "Салаты", Products = salads });

            List<Product> sauces = new List<Product>();

            sauces.Add(new Product { Name = "Sacebeli /80 g/", NameArm = "Սացեբելի /80գր/", NameRus = "Сацебели /80 гр./", Price = "250", PicPath = "/Resources/Georgian/Սացեբելի.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Tkemali /80 g/", NameArm = "Տղեմալի /80գր/", NameRus = "Ткемали /80 гр./", Price = "250", PicPath = "/Resources/Georgian/Տղեմալի.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Adjika /80 g/", NameArm = "Աջիկա /80գր/", NameRus = "Аджика /80 гр./", Price = "250", PicPath = "/Resources/Georgian/Աջիկա.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });
            sauces.Add(new Product { Name = "Sour cream /80 g/", NameArm = "Թթվասեր /80գր/", NameRus = "Сметана /80 гр./", Price = "150", PicPath = "/Resources/Georgian/Թթվասերային.jpg", Description = "", DescriptionArm = "", DescriptionRus = "" });


            categories.Add(new Categorie { Name = "Sauces", NameArm = "Սոուսներ", NameRus = "Соусы", Products = sauces });

        }
    }
}
