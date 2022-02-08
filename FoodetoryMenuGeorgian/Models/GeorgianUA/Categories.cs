using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.GeorgianUA
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> khachapuri = new List<Product>();

            khachapuri.Add(new Product { Name = "Імеритинський Цілий", NameEng = "Imeretian Whole", PicPath = "/Resources/GeorgianUA/Իմերիթական ամբողջ.jpg", Description = "Сулугуні, бринза, яйце, вершкове масло, борошно", DescriptionEng = "Suluguni, brynza, egg, butter, flour" });
            khachapuri.Add(new Product { Name = "Мегрельський Цілий", NameEng = "Megrelian Whole", PicPath = "/Resources/GeorgianUA/Մեգրելական ամբողջ.jpg", Description = "Сулугуні, яйце, вершкове масло, борошно, бринза", DescriptionEng = "Suluguni, egg, butter, flour, brynza" });
            khachapuri.Add(new Product { Name = "Королівський Цілий", NameEng = "Royal Whole", PicPath = "/Resources/GeorgianUA/Արքայական խաչապուրի.jpg", Description = "Сулугуні, яйце, вершкове масло, бринза", DescriptionEng = "Suluguni, egg, butter, brynza" });
            khachapuri.Add(new Product { Name = "Хачапурі на шампурі", NameEng = "On a skewer /200 g/", PicPath = "/Resources/GeorgianUA/Շամփուրի վրա.jpg", Description = "Сулугуні, яйце, вершкове масло, борошно", DescriptionEng = "Suluguni, egg, butter, flour," });
            khachapuri.Add(new Product { Name = "Аджарський, 1 яйце /350 г/", NameEng = "Adjarian, 1 egg /350 g/", PicPath = "/Resources/GeorgianUA/Աջարական խաչապուրի 1 ձու.jpg", Description = "Сулугуні, яйце, вершкове масло, борошно", DescriptionEng = "Suluguni, egg, butter, flour" });
            khachapuri.Add(new Product { Name = "Аджарський, 2 яйця /400 г/", NameEng = "Adjarian, 2 eggs /400 g/", PicPath = "/Resources/GeorgianUA/Աջարական խաչապուրի 2 ձու.jpg", Description = "Сулугуні, яйце, вершкове масло, борошно", DescriptionEng = "Suluguni, egg, butter, flour" });
            khachapuri.Add(new Product { Name = "Аджарський з бастурмою, 1 яйце /440 г/", NameEng = "Adjarian with basturma, 1 egg /440 g/", PicPath = "/Resources/GeorgianUA/Աջարական խաչապուրի բաստուրմայով 1 ձու.jpg", Description = "Бастурма, сулугуні, яйце, вершкове масло, борошно, бринза", DescriptionEng = "Basturma, suluguni, egg, butter, flour, brynza" });
            khachapuri.Add(new Product { Name = "Аджарський з бастурмою, 2 яйця /440 г/", NameEng = "Adjarian with basturma, 2 eggs /440 g/", PicPath = "/Resources/GeorgianUA/աջարական խաչապուրի բաստուրմայով 2 ձու.jpg", Description = "Бастурма, сулугуні, яйце, вершкове масло, борошно, бринза", DescriptionEng = "Basturma, suluguni, egg, butter, flour, brynza" });
            khachapuri.Add(new Product { Name = "Кубдарі /250 г/", NameEng = "Kubdari /250 g/", PicPath = "/Resources/GeorgianUA/Կուբդարի.jpg", Description = "Свинина, сулугуні, яйце, вершкове масло, борошно, цибуля", DescriptionEng = "Pork, suluguni, egg, butter, flour, onion" });
            khachapuri.Add(new Product { Name = "Лобіані /350 г/", NameEng = "Lobiani /350 g/", PicPath = "/Resources/GeorgianUA/Լոբիանի.jpg", Description = "Червона квасоля, сулугуні, яйце, вершкове масло, борошно, цибуля", DescriptionEng = "Red beans, suluguni, egg, butter, flour, onion" });
            khachapuri.Add(new Product { Name = "Ачма /250 г/", NameEng = "Achma /250 g/", PicPath = "/Resources/GeorgianUA/Աչմա .jpg", Description = "Сулугуні, яйце, вершкове масло, борошно", DescriptionEng = "Suluguni, egg, butter, flour" });




            categories.Add(new Categorie { Name = "Хачапурі", NameEng = "Khachapuri", Products = khachapuri, CategoriePic = "/Resources/Georgian/Cover/խաչապուրի.png" });


            List<Product> khinkali = new List<Product>();

            khinkali.Add(new Product { Name = "Хінкалі /від 5 шт/", NameEng = "Khinkali / from 5 pcs/", PicPath = "/Resources/GeorgianUA/Խինկալի.jpg", Description = "Телятина, цибуля, сало, тісто, кінза, вершкове масло, часник, перець чілі", DescriptionEng = "Beef, onion, lard, dough, Cilantro, butter, garlic, chili peppers" });
            khinkali.Add(new Product { Name = "Смажені хінкалі/ від 5 шт/", NameEng = "Fried khinkali /from 5 pcs/", PicPath = "/Resources/GeorgianUA/Տապակած խինկալի.jpg", Description = "Телятина, цибуля, сало, тісто, коріандр, вершкове масло, часний", DescriptionEng = "Beef, onion, lard, dough, coriander, butter, garlic" });


            categories.Add(new Categorie { Name = "Хінкалі", NameEng = "Khinkali", Products = khinkali, CategoriePic = "/Resources/Georgian/Cover/խինկալի.png" });


            List<Product> mainDishes = new List<Product>();

            mainDishes.Add(new Product { Name = "Острі /300 г/", NameEng = "Ostri /300 g/", PicPath = "/Resources/GeorgianUA/Օստրի.jpg", Description = "Телятина, цибуля, перець, томати, коріандр, часник", DescriptionEng = "Beef, onion, pepper, tomato, coriander, garlic" });
            mainDishes.Add(new Product { Name = "Чашашулі /250 г/", NameEng = "Chashashuli /250 g/", PicPath = "/Resources/GeorgianUA/Չաշուշուլի.jpg", Description = "Телятина, цибуля, перець, томати, часник, базилік, петрушка, томатний соус", DescriptionEng = "Beef, onion, pepper, tomato, garlic, basil, parsley, tomato sauce" });
            mainDishes.Add(new Product { Name = "Чакапулі /300 г/", NameEng = "Chakapuli /300 g/", PicPath = "/Resources/GeorgianUA/Չաքապուլի.jpg", Description = "Баранина,естрагон, зелена цибуля, біле вино, ткемалі, петрушка,тархун", DescriptionEng = "Lamb, tarragon, green onions, white wine, tkemali, coriander, parsley" });
            mainDishes.Add(new Product { Name = "Чкмерулі /300 г/", NameEng = "Chkmeruli /300 g/", PicPath = "/Resources/GeorgianUA/Չքմերուլի.jpg", Description = "Курка, сметана, вершки, часник", DescriptionEng = "Chicken, sour cream, cream, garlic" });
            mainDishes.Add(new Product { Name = "Мадам Боварі /300 г/", NameEng = "Madam Bovari /300 g/", PicPath = "/Resources/GeorgianUA/Մադամ բովարի.jpg", Description = "Печериці, телятина, томати, цибуля, естрагон, сулугуні, майонез", DescriptionEng = "Champignons, veal, tomatoes, onions, tarragon, suluguni, mayonnaise" });
            mainDishes.Add(new Product { Name = "Оджахурі /300 г/", NameEng = "Odjakhuri /300 g/", PicPath = "/Resources/GeorgianUA/Օջախուրի.jpg", Description = "Свинина, цибуля, картопля, перець, коріандр, часник, кінза", DescriptionEng = "Pork, onion, potato, pepper, coriander, garlic, cilantro" });
            mainDishes.Add(new Product { Name = "Гоніо /300 г/", NameEng = "Gonio /300 g/", PicPath = "/Resources/GeorgianUA/Գոնիո.jpg", Description = "Картопля, філе телятини, печериці, цибуля, сулугуні, сметана, майонез, вершки", DescriptionEng = "Potatoes, mushrooms, beef, onion, suluguni" });
            mainDishes.Add(new Product { Name = "Кучмачі /300 г/", NameEng = "Kuchmachi /300 g/", PicPath = "/Resources/GeorgianUA/Կուչմաչի.jpg", Description = "Курячі сердечка та легені, перець, томати, цибуля, часник, томатний соус", DescriptionEng = "Chicken hearts and lungs, pepper, tomato, onion, garlic, tomato sauce" });
            mainDishes.Add(new Product { Name = "Фаршировані печериці /250 г/", NameEng = "Stuffed champignons /250 g/", PicPath = "/Resources/GeorgianUA/Լցոնած շամպինյոն.jpg", Description = "Печериці, сулугуні, соняшникова олія", DescriptionEng = "Champignons, suluguni, sunflower oil" });
            mainDishes.Add(new Product { Name = "Смажений сулугуні / 200 г/", NameEng = "Fried suluguni /3 pieces/ 200 g/", PicPath = "/Resources/GeorgianUA/Տապակած սուլուգունի.jpg", Description = "Сулугуні, яйця, паніровочні сухарі", DescriptionEng = "Suluguni, eggs, bread crumbs" });
            mainDishes.Add(new Product { Name = "Каптопля по-грузинські", NameEng = "Georgian potatoes", PicPath = "/Resources/GeorgianUA/Վրացական կարտոֆիլ նյու.jpg", Description = "Картопля, майонез, кріп, часник", DescriptionEng = "Potatoes, mayonnaise, dill, garlic" });
            mainDishes.Add(new Product { Name = "Чахохбілі", NameEng = "Chakhokhbili", PicPath = "/Resources/GeorgianUA/Չախոխբիլի նյու.jpg", Description = "Курячі крильця, томати, томатна паста, базилік, болгарський перець, гострий перець, цибуля, часник, кінза", DescriptionEng = "Сhicken wings, tomato, tomato paste, basil, bell pepper, hot pepper. onion, garlic, cilantro" });
            mainDishes.Add(new Product { Name = "Оджахурі з грибами", NameEng = "Mushroom odjakhuri", PicPath = "/Resources/GeorgianUA/Սնկով օջախուրի նյու.jpg", Description = "Печериці, картопля, болгарський перець, томати, цибуля, часник, кріп, соєвий соус", DescriptionEng = "Champignons, potatoes, bell peppers, tomatoes, onions, garlic, dill,soy sauce" });
            mainDishes.Add(new Product { Name = "Чічілакі", NameEng = "Chichilaki", PicPath = "/Resources/GeorgianUA/Չիչիլակի նյու.jpg", Description = "Курка, кріп, сметана, часник, соєвий соус", DescriptionEng = "Chicken breast, dill, sour cream, garlic, soy sauce" });



            categories.Add(new Categorie { Name = "Main Гарячі страви", NameEng = "Main dishes", Products = mainDishes, CategoriePic = "/Resources/Georgian/Cover/main dishes.png" });


            List<Product> coldDishes = new List<Product>();

            coldDishes.Add(new Product { Name = "Сациві /300 г/", NameEng = "Satsivi /300 g/", PicPath = "/Resources/GeorgianUA/Սացիվի.jpg", Description = "Курка, яйця, горіхи часник, цибуля", DescriptionEng = "Chicken, eggs, nuts, garlic, onion" });
            coldDishes.Add(new Product { Name = "Рулет з баклажана /150г/", NameEng = "Eggplant rolls /150g/", PicPath = "/Resources/GeorgianUA/Սմբուկով ռուլետ նյու.jpg", Description = "Баклажани, волоський горіх, часник, спеції, кінза", DescriptionEng = "Eggplants, walnuts, garlic, spices, cilantro" });
            coldDishes.Add(new Product { Name = "Кутаїсі /250 г/", NameEng = "Kutaisi /250 g/", PicPath = "/Resources/GeorgianUA/Քութաիսի.jpg", Description = "Буряк, волоський горіх, часник, спеції, кінза", DescriptionEng = "Beet, walnuts, garlic, spices, cilantro" });
            coldDishes.Add(new Product { Name = "Сакартвело /250 г/", NameEng = "Sakartvelo /250 g/", PicPath = "/Resources/GeorgianUA/Սակարթվելո.jpg", Description = "Біла квасоля, волоський горіх, часник, спеції, кінза", DescriptionEng = "Beans, walnuts, garlic, spices, cilantro" });
            coldDishes.Add(new Product { Name = "Пхалі з баклажаном /50г/", NameEng = "Phali with eggplants /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Шпинат, волоський горіх, часник, спеції, кінза", DescriptionEng = "Spinach, walnuts, garlic, spice, cilantro" });
            coldDishes.Add(new Product { Name = "Пхалі з буряком /50г/", NameEng = "Phali with beet /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Баклажан,волоський горіх,коріандр,часник,кінза", DescriptionEng = "Eggplant, walnuts, coriander, garlic, cilantro" });
            coldDishes.Add(new Product { Name = "Пхалі з білою кваолею /50г/", NameEng = "Phali with beans /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Томати,огірок, цибуля,  горіхи, оцет, базилік, часник", DescriptionEng = "Tomatoes, cucumbers, onions, nuts, vinegar, basil,garlic" });
            coldDishes.Add(new Product { Name = "Пхалі зі шпинатом /50г/", NameEng = "Phali with spinach /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Телятина, баклажани, волоські горіхи, часник, кріп, майонез", DescriptionEng = "Beef, eggplant, walnuts, garlic, dill, mayonnaise" });



            categories.Add(new Categorie { Name = "Холодні страви", NameEng = "Cold dishes", Products = coldDishes, CategoriePic = "/Resources/Georgian/Cover/Cold dishes.png" });

            List<Product> soups = new List<Product>();

            soups.Add(new Product { Name = "Суп з куркою /350 г/", NameEng = "Chicken soup /350 g/", PicPath = "/Resources/GeorgianUA/Հավով ապուր.jpg", Description = "Куряча грудка, перець, морква, цибуля, кінза, часник, коріандр", DescriptionEng = "Chicken breast, peppers, carrots, onions, cilantro, garlic, coriander" });
            soups.Add(new Product { Name = "Лобіо з волоським горіхом /300 г/", NameEng = "Lobio with walnuts /300 g/", PicPath = "/Resources/GeorgianUA/Լոբիո ընկույզով.jpg", Description = "Червона квасоля, цибуля, волоські горіхи, часник, кінза", DescriptionEng = "Red beans, onions, nuts, garlic,cilantro" });
            soups.Add(new Product { Name = "Харчо /350 г/", NameEng = "Kharcho /350 g/", PicPath = "/Resources/GeorgianUA/Խարչո.jpg", Description = "Телятина, рис, цибуля, томатний соус, ткемалі", DescriptionEng = "Beef, rice, onion, tomato sauce, tkemali" });
            soups.Add(new Product { Name = "Грибний суп /350 г/", NameEng = "Mushroom soup /350 g/", PicPath = "/Resources/GeorgianUA/Սնկով ապուր.jpg", Description = "Гриби, картопля, морква, сметана, кріп, цибуля, масло", DescriptionEng = "Mushrooms, potatoes, carrots, sour cream, dill, onion, butter" });
            soups.Add(new Product { Name = "Піті з бараниною /350г/", NameEng = "Pide with lamb /350g/", PicPath = "/Resources/GeorgianUA/Փիդե գառան մսով նյու.jpg", Description = "Баранина, нут, цибуля, картопля, часник", DescriptionEng = "Lamb, peas, onions, potatoes, garlic" });


            categories.Add(new Categorie { Name = "Супи", NameEng = "Soups", Products = soups, CategoriePic = "/Resources/Georgian/Cover/soups.png" });

            List<Product> salads = new List<Product>();

            salads.Add(new Product { Name = "Урекі /250г/", NameEng = "Ureki /250g/", PicPath = "/Resources/GeorgianUA/Ուռեկի.jpg", Description = "Телятина, перець, солоний огірок, майонез, кріп, часник, перець", DescriptionEng = "Beef, pepper, pickles, mayonnaise, dill, garlic,pepper" });
            salads.Add(new Product { Name = "Авлабар /250г/", NameEng = "Avlabar /250g/", PicPath = "/Resources/GeorgianUA/Հավլաբար.jpg", Description = "Куряча грудка, морква, гриби, майонез, кріп, часник, печериці", DescriptionEng = "Chicken breast, carrots, mushrooms, mayonnaise, dill, garlic, mushrooms" });
            salads.Add(new Product { Name = "Тбілісі /250г/", NameEng = "Tbilisi /250g/", PicPath = "/Resources/GeorgianUA/Թբիլիսի.jpg", Description = "Куряча грудка, капуста, майонез, перець, часник, кріп", DescriptionEng = "Chicken breast, cabbage, mayonnaise, pepper" });
            salads.Add(new Product { Name = "Карі /250г/", NameEng = "Kari /250g/", PicPath = "/Resources/GeorgianUA/Կարի.jpg", Description = "Куряча грудка, солоні огірки, майонез, кріп", DescriptionEng = "Chicken breast, pickled cucumbers, mayonnaise, dill" });
            salads.Add(new Product { Name = "Гурія /250г/", NameEng = "Guria /250g/", PicPath = "/Resources/GeorgianUA/Գուրիա.jpg", Description = "Куряча грудка, перець, кукурудза, оливки, майонез, кріп, часник, морква", DescriptionEng = "Chicken breast, pepper, corn, olives, mayonnaise, dill, garlic, carrots" });
            salads.Add(new Product { Name = "Раджулі", NameEng = "Rajuli", PicPath = "/Resources/GeorgianUA/Ռաճուլի նյու.jpg", Description = "Шинка, томати, кріп, сулугуні, часник, сметана", DescriptionEng = "Ham, tomato, dill, suluguni, garlic, sour cream" });


            categories.Add(new Categorie { Name = "Салати", NameEng = "Salads", Products = salads, CategoriePic = "/Resources/Georgian/Cover/Salads.png" });

            List<Product> sauces = new List<Product>();

            sauces.Add(new Product { Name = "Сацебелі /80 г/", NameEng = "Sacebeli /80 g/", PicPath = "/Resources/GeorgianUA/Սացեբելի.jpg", Description = "Томати, часник, коріандр, кінза", DescriptionEng = "Tomatoes, garlic, coriander, cilantro" });
            sauces.Add(new Product { Name = "Ткемалі /80 г/", NameEng = "Tkemali /80 g/", PicPath = "/Resources/GeorgianUA/Տղեմալի.jpg", Description = "Алича, кінза, часник", DescriptionEng = "Alice, cilantro, garlic" });
            sauces.Add(new Product { Name = "Аджика /80 г/", NameEng = "Adjika /80 g/", PicPath = "/Resources/GeorgianUA/Աջիկա.jpg", Description = "Томати, гострий перець, часник", DescriptionEng = "Tomatoes, hot peppers, garlic" });
            sauces.Add(new Product { Name = "Сметана /80 г/", NameEng = "Sour cream /80 g/", PicPath = "/Resources/GeorgianUA/Թթվասերային.jpg", Description = "", DescriptionEng = "" });


            categories.Add(new Categorie { Name = "Соуси", NameEng = "Sauces", Products = sauces, CategoriePic = "/Resources/Georgian/Cover/Sauces.png" });

            
        }
    }
}
