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

            khachapuri.Add(new Product { Name = "Імеритинський Цілий", NameEng = "Imeretian Whole", PicPath = "/Resources/GeorgianUA/Իմերիթական ամբողջ.jpg", Description = "Сир, яйце, вершкове масло, борошно, сулугуні, чанах", DescriptionEng = "cheese, egg, butter, flour, suluguni, chanakh" });
            khachapuri.Add(new Product { Name = "Мегрельський Цілий", NameEng = "Megrelian Whole", PicPath = "/Resources/GeorgianUA/Մեգրելական ամբողջ.jpg", Description = "Сир,яйце, вершкове масло, борошно, сулугуні, чанах", DescriptionEng = "cheese, egg, butter, flour, suluguni, chanakh" });
            khachapuri.Add(new Product { Name = "Королівський Цілий", NameEng = "Royal Whole", PicPath = "/Resources/GeorgianUA/Արքայական խաչապուրի.jpg", Description = "Сир, яйце, вершкове масло, сулугуні, чанах", DescriptionEng = "cheese, egg, butter, suluguni, chanakh" });
            khachapuri.Add(new Product { Name = "На шампурі /200 г/", NameEng = "On a skewer /200 g/", PicPath = "/Resources/GeorgianUA/Շամփուրի վրա.jpg", Description = "Сир, яйце, вершкове масло, борошно, сулугуні", DescriptionEng = "cheese, egg, butter, flour, suluguni" });
            khachapuri.Add(new Product { Name = "Аджарський, 1 яйце /350 г/", NameEng = "Adjarian, 1 egg /350 g/", PicPath = "/Resources/GeorgianUA/Աջարական խաչապուրի 1 ձու.jpg", Description = "Сир, яйце, вершкове масло, борошно", DescriptionEng = "cheese, egg, butter, flour" });
            khachapuri.Add(new Product { Name = "Аджарський, 2 яйця /400 г/", NameEng = "Adjarian, 2 eggs /400 g/", PicPath = "/Resources/GeorgianUA/Աջարական խաչապուրի 2 ձու.jpg", Description = "Сир, яйце, вершкове масло, борошно", DescriptionEng = "cheese, egg, butter, flour" });
            khachapuri.Add(new Product { Name = "Аджарський з бастурмою, 1 яйце /440 г/", NameEng = "Adjarian with basturma, 1 egg /440 g/", PicPath = "/Resources/GeorgianUA/Աջարական խաչապուրի բաստուրմայով 1 ձու.jpg", Description = "Бастурма, сир, яйце, вершкове масло, борошно", DescriptionEng = "basturma, cheese, egg, butter, flour" });
            khachapuri.Add(new Product { Name = "Аджарський з бастурмою, 2 яйця /440 г/", NameEng = "Adjarian with basturma, 2 eggs /440 g/", PicPath = "/Resources/GeorgianUA/աջարական խաչապուրի բաստուրմայով 2 ձու.jpg", Description = "Бастурма, сир, яйце, вершкове масло, борошно", DescriptionEng = "basturma, cheese, egg, butter, flour" });
            khachapuri.Add(new Product { Name = "Кубдарі /250 г/", NameEng = "Kubdari /250 g/", PicPath = "/Resources/GeorgianUA/Կուբդարի.jpg", Description = "Свинина, сир, яйце, вершкове масло, борошно, цибуля", DescriptionEng = "pork, cheese, egg, butter, flour, onion" });
            khachapuri.Add(new Product { Name = "Лобіані /350 г/", NameEng = "Lobiani /350 g/", PicPath = "/Resources/GeorgianUA/Լոբիանի.jpg", Description = "Червона квасоля, сир, яйце, вершкове масло, борошно, цибуля", DescriptionEng = "red beans, cheese, egg, butter, flour, onion" });
            khachapuri.Add(new Product { Name = "Ачма /250 г/", NameEng = "Achma /250 g/", PicPath = "/Resources/GeorgianUA/Աչմա .jpg", Description = "Сир, яйце, вершкове масло, борошно", DescriptionEng = "cheese, egg, butter, flour" });




            categories.Add(new Categorie { Name = "Хачапурі", NameEng = "Khachapuri", Products = khachapuri, CategoriePic = "/Resources/Georgian/Cover/խաչապուրի.png" });


            List<Product> khinkali = new List<Product>();

            khinkali.Add(new Product { Name = "Хінкалі /від 5 шт/", NameEng = "Khinkali / from 5 pcs/", PicPath = "/Resources/GeorgianUA/Խինկալի.jpg", Description = "Телятина, цибуля, сало, тісто, коріандр, вершкове масло", DescriptionEng = "beef, onion, lard, dough, coriander, butter" });
            khinkali.Add(new Product { Name = "Смажені хінкалі/ від 5 шт/", NameEng = "Fried khinkali /from 5 pcs/", PicPath = "/Resources/GeorgianUA/Տապակած խինկալի.jpg", Description = "Телятина, цибуля, сало, тісто, коріандр, вершкове масло", DescriptionEng = "beef, onion, lard, dough, coriander, butter" });


            categories.Add(new Categorie { Name = "Хінкалі", NameEng = "Khinkali", Products = khinkali, CategoriePic = "/Resources/Georgian/Cover/խինկալի.png" });


            List<Product> mainDishes = new List<Product>();

            mainDishes.Add(new Product { Name = "Острі /300 г/", NameEng = "Ostri /300 g/", PicPath = "/Resources/GeorgianUA/Օստրի.jpg", Description = "Телятина, цибуля, перець, томати, коріандр, часник", DescriptionEng = "beef, onion, pepper, tomato, coriander, garlic" });
            mainDishes.Add(new Product { Name = "Чашашулі /250 г/", NameEng = "Chashashuli /250 g/", PicPath = "/Resources/GeorgianUA/Չաշուշուլի.jpg", Description = "Телятина, цибуля, перець, томати, часник, базилік, петрушка, томатний соус", DescriptionEng = "beef, onion, pepper, tomato, garlic, basil, parsley, tomato sauce" });
            mainDishes.Add(new Product { Name = "Чакапулі /300 г/", NameEng = "Chakapuli /300 g/", PicPath = "/Resources/GeorgianUA/Չաքապուլի.jpg", Description = "Говядина,естрагон, зелена цибуля, біле вино, ткемалі, коріандр, петрушка", DescriptionEng = "lamb, tarragon, green onions, white wine, tkemali, coriander, parsley" });
            mainDishes.Add(new Product { Name = "Чкмерулі /300 г/", NameEng = "Chkmeruli /300 g/", PicPath = "/Resources/GeorgianUA/Չքմերուլի.jpg", Description = "Курка, сметана, вершки, часник", DescriptionEng = "chicken, sour cream, cream, garlic" });
            mainDishes.Add(new Product { Name = "Мадам Боварі /300 г/", NameEng = "Madam Bovari /300 g/", PicPath = "/Resources/GeorgianUA/Մադամ բովարի.jpg", Description = "Печериці, свинина, томати, цибуля, естрагон, сулугуні", DescriptionEng = "champignons, beef, tomatoes, onions, tarragon, suluguni" });
            mainDishes.Add(new Product { Name = "Оджахурі /300 г/", NameEng = "Odjakhuri /300 g/", PicPath = "/Resources/GeorgianUA/Օջախուրի.jpg", Description = "Свинина, цибуля, картопля, перець, коріандр, часник", DescriptionEng = "pork, onion, potato, pepper, coriander, garlic" });
            mainDishes.Add(new Product { Name = "Гоніо /300 г/", NameEng = "Gonio /300 g/", PicPath = "/Resources/GeorgianUA/Գոնիո.jpg", Description = "Картопля, печериці, телятина, цибуля, сулугуні", DescriptionEng = "potatoes, mushrooms, beef, onion, suluguni" });
            mainDishes.Add(new Product { Name = "Кучмачі /300 г/", NameEng = "Kuchmachi /300 g/", PicPath = "/Resources/GeorgianUA/Կուչմաչի.jpg", Description = "Курячі сердечка та легені, перець, томати, цибуля, часник, томатний соус", DescriptionEng = "chicken hearts and lungs, pepper, tomato, onion, garlic, tomato sauce" });
            mainDishes.Add(new Product { Name = "Фаршировані печериці /250 г/", NameEng = "Stuffed champignons /250 g/", PicPath = "/Resources/GeorgianUA/Լցոնած շամպինյոն.jpg", Description = "Печериці, сулугуні, соняшникова олія", DescriptionEng = "champignons, suluguni, sunflower oil" });
            mainDishes.Add(new Product { Name = "Смажений сулугуні / 200 г/", NameEng = "Fried suluguni /3 pieces/ 200 g/", PicPath = "/Resources/GeorgianUA/Տապակած սուլուգունի.jpg", Description = "Сулугуні, яйця, паніровочні сухарі", DescriptionEng = "suluguni, eggs, bread crumbs" });
            mainDishes.Add(new Product { Name = "Каптопля по-грузинські", NameEng = "Georgian potatoes", PicPath = "/Resources/GeorgianUA/Վրացական կարտոֆիլ նյու.jpg", Description = "Картопля, майонез, кріп, часник, насіння коріандру", DescriptionEng = "potatoes, mayonnaise, dill, garlic, coriander seeds" });
            mainDishes.Add(new Product { Name = "Чахохбілі", NameEng = "Chakhokhbili", PicPath = "/Resources/GeorgianUA/Չախոխբիլի նյու.jpg", Description = "Курячі крильця, томати, томатна паста, базилік, болгарський перець, гострий перець", DescriptionEng = "chicken wings, tomato, tomato paste, basil, bell pepper, hot pepper" });
            mainDishes.Add(new Product { Name = "Оджахурі з грибами", NameEng = "Mushroom odjakhuri", PicPath = "/Resources/GeorgianUA/Սնկով օջախուրի նյու.jpg", Description = "Печериці, картопля, болгарський перець, томати, цибуля, часник", DescriptionEng = "champignons, potatoes, bell peppers, tomatoes, onions, garlic" });
            mainDishes.Add(new Product { Name = "Чічілакі", NameEng = "Chichilaki", PicPath = "/Resources/GeorgianUA/Չիչիլակի նյու.jpg", Description = "Курка, кріп, сметана, часник, соєвий соус", DescriptionEng = "chicken breast, dill, sour cream, garlic, soy sauce" });



            categories.Add(new Categorie { Name = "Main Гарячі страви", NameEng = "Main dishes", Products = mainDishes, CategoriePic = "/Resources/Georgian/Cover/main dishes.png" });


            List<Product> coldDishes = new List<Product>();

            coldDishes.Add(new Product { Name = "Сациві /300 г/", NameEng = "Satsivi /300 g/", PicPath = "/Resources/GeorgianUA/Սացիվի.jpg", Description = "Курка, яйця, горіхи", DescriptionEng = "chicken, eggs, nuts" });
            coldDishes.Add(new Product { Name = "Рулет з баклажана /150г/", NameEng = "Eggplant rolls /150g/", PicPath = "/Resources/GeorgianUA/Սմբուկով ռուլետ նյու.jpg", Description = "Баклажан, волоський горіх, цибуля, коріандр, часник", DescriptionEng = "eggplant, walnuts, onions, coriander, garlic" });
            coldDishes.Add(new Product { Name = "Кутаїсі /250 г/", NameEng = "Kutaisi /250 g/", PicPath = "/Resources/GeorgianUA/Քութաիսի.jpg", Description = "Томати,огірок, цибуля,  горіхи, оцет", DescriptionEng = "tomatoes, cucumbers, onions, nuts, vinegar" });
            coldDishes.Add(new Product { Name = "Сакартвело /250 г/", NameEng = "Sakartvelo /250 g/", PicPath = "/Resources/GeorgianUA/Սակարթվելո.jpg", Description = "Телятина, баклажани, волоські горіхи, часник, кріп", DescriptionEng = "beef, eggplant, walnuts, garlic, dill" });
            coldDishes.Add(new Product { Name = "Пхалі з баклажаном /50г/", NameEng = "Phali with eggplants /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Баклажани, волоський горіх, часник, спеції", DescriptionEng = "eggplants, walnuts, garlic, spices" });
            coldDishes.Add(new Product { Name = "Пхалі з буряком /50г/", NameEng = "Phali with beet /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Буряк, волоський горіх, часник, спеції", DescriptionEng = "Beet, walnuts, garlic, spices" });
            coldDishes.Add(new Product { Name = "Пхалі з білою кваолею /50г/", NameEng = "Phali with beans /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Біла квасоля, волоський горіх, часник, спеції", DescriptionEng = "Beans, walnuts, garlic, spices" });
            coldDishes.Add(new Product { Name = "Пхалі зі шпинатом /50г/", NameEng = "Phali with spinach /50g/", PicPath = "/Resources/GeorgianUA/Պխալի.jpg", Description = "Шпинат, волоський горіх, часник, спеції", DescriptionEng = "Spinach, walnuts, garlic, spice" });



            categories.Add(new Categorie { Name = "Холодні страви", NameEng = "Cold dishes", Products = coldDishes, CategoriePic = "/Resources/Georgian/Cover/Cold dishes.png" });

            List<Product> soups = new List<Product>();

            soups.Add(new Product { Name = "Суп з куркою /350 г/", NameEng = "Chicken soup /350 g/", PicPath = "/Resources/GeorgianUA/Հավով ապուր.jpg", Description = "Куряча грудка, перець, морква, цибуля", DescriptionEng = "chicken breast, peppers, carrots, onions" });
            soups.Add(new Product { Name = "Лобіо з волоським горіхом /300 г/", NameEng = "Lobio with walnuts /300 g/", PicPath = "/Resources/GeorgianUA/Լոբիո ընկույզով.jpg", Description = "Червона квасоля, цибуля, волоські горіхи", DescriptionEng = "red beans, onions, nuts" });
            soups.Add(new Product { Name = "Харчо /350 г/", NameEng = "Kharcho /350 g/", PicPath = "/Resources/GeorgianUA/Խարչո.jpg", Description = "Телятина, рис, цибуля, томатний соус, ткемалі", DescriptionEng = "beef, rice, onion, tomato sauce, tkemali" });
            soups.Add(new Product { Name = "Грибний суп /350 г/", NameEng = "Mushroom soup /350 g/", PicPath = "/Resources/GeorgianUA/Սնկով ապուր.jpg", Description = "Гриби, картопля, морква, сметана", DescriptionEng = "mushrooms, potatoes, carrots, sour cream" });
            soups.Add(new Product { Name = "Піті з бараниною /350г/", NameEng = "Pide with lamb /350g/", PicPath = "/Resources/GeorgianUA/Փիդե գառան մսով նյու.jpg", Description = "Телятина, нут, цибуля, картопля, часник", DescriptionEng = "lamb, peas, onions, potatoes, garlic" });


            categories.Add(new Categorie { Name = "Супи", NameEng = "Soups", Products = soups, CategoriePic = "/Resources/Georgian/Cover/soups.png" });

            List<Product> salads = new List<Product>();

            salads.Add(new Product { Name = "Урекі /250г/", NameEng = "Ureki /250g/", PicPath = "/Resources/GeorgianUA/Ուռեկի.jpg", Description = "Телятина, перець, солоний огірок, майонез, кріп", DescriptionEng = "beef, pepper, pickles, mayonnaise, dill" });
            salads.Add(new Product { Name = "Авлабар /250г/", NameEng = "Avlabar /250g/", PicPath = "/Resources/GeorgianUA/Հավլաբար.jpg", Description = "Куряча грудка, морква, гриби, майонез, кріп, часник", DescriptionEng = "chicken breast, carrots, mushrooms, mayonnaise, dill, garlic" });
            salads.Add(new Product { Name = "Тбілісі /250г/", NameEng = "Tbilisi /250g/", PicPath = "/Resources/GeorgianUA/Թբիլիսի.jpg", Description = "Куряча грудка, капуста, майонез, перець", DescriptionEng = "chicken breast, cabbage, mayonnaise, pepper" });
            salads.Add(new Product { Name = "Карі /250г/", NameEng = "Kari /250g/", PicPath = "/Resources/GeorgianUA/Կարի.jpg", Description = "Куряча грудка, солоні огірки, майонез, кріп", DescriptionEng = "chicken breast, pickled cucumbers, mayonnaise, dill" });
            salads.Add(new Product { Name = "Гурія /250г/", NameEng = "Guria /250g/", PicPath = "/Resources/GeorgianUA/Գուրիա.jpg", Description = "Куряча грудка, перець, кукурудза, оливки, майонез", DescriptionEng = "chicken breast, pepper, corn, olives, mayonnaise" });
            salads.Add(new Product { Name = "Раджулі", NameEng = "Rajuli", PicPath = "/Resources/GeorgianUA/Ռաճուլի նյու.jpg", Description = "Шинка, томати, кріп, сулугуні, часник", DescriptionEng = "ham, tomato, dill, suluguni, garlic" });


            categories.Add(new Categorie { Name = "Салати", NameEng = "Salads", Products = salads, CategoriePic = "/Resources/Georgian/Cover/Salads.png" });

            List<Product> sauces = new List<Product>();

            sauces.Add(new Product { Name = "Сацебелі /80 г/", NameEng = "Sacebeli /80 g/", PicPath = "/Resources/GeorgianUA/Սացեբելի.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Ткемалі /80 г/", NameEng = "Tkemali /80 g/", PicPath = "/Resources/GeorgianUA/Տղեմալի.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Аджика /80 г/", NameEng = "Adjika /80 g/", PicPath = "/Resources/GeorgianUA/Աջիկա.jpg", Description = "0", DescriptionEng = "0" });
            sauces.Add(new Product { Name = "Сметана /80 г/", NameEng = "Sour cream /80 g/", PicPath = "/Resources/GeorgianUA/Թթվասերային.jpg", Description = "0", DescriptionEng = "0" });


            categories.Add(new Categorie { Name = "Соуси", NameEng = "Sauces", Products = sauces, CategoriePic = "/Resources/Georgian/Cover/Sauces.png" });

            
        }
    }
}
