using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.ItalyUA
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> pizzas = new List<Product>();


            pizzas.Add(new Product { Name = "Піца Пепероні Цілий", NameEng = "Pizza Pepperoni Whole", PicPath = "/Resources/ItalyUA/Պիցցա պեպերոնի ամբողջական.jpg", Description = "Сир, моцарела, пармезан, ковбаса Чорізо, ковбаса Пепероні", DescriptionEng = "Cheese, mozzarella, parmesan, Choriso sausage, Pepperoni sausage" });
            pizzas.Add(new Product { Name = "Піца Маргарита Цілий", NameEng = "Pizza Margarita Whole", PicPath = "/Resources/ItalyUA/Պիցցա Մարգարիտա ամբողջական.jpg", Description = "Томати, моцарела, пармезан, базилік", DescriptionEng = "Tomatoes, mozzarella, parmesan, basil" });
            pizzas.Add(new Product { Name = "Піца Цезар Цілий", NameEng = "Pizza Caesar Whole", PicPath = "/Resources/ItalyUA/Պիցցա կեսար ամբողջական.jpg", Description = "Соус Цезар, листя салату, курка", DescriptionEng = "Caesar sauce, lettuce, chicken breast" });
            pizzas.Add(new Product { Name = "Кальцоне", NameEng = "Calzone", PicPath = "/Resources/ItalyUA/Կալզոնե մեծ.jpg", Description = "Балик зі свинини, гриби, печериці, моцарела, соус 'Неаполітано'", DescriptionEng = "Pork balyk, mushrooms, champignons, mozzarella, sauce 'Neapolitano'" });
            pizzas.Add(new Product { Name = "Піца з морепродуктами Цілий", NameEng = "Pizza with seafood Whole", PicPath = "/Resources/ItalyUA/Պիցցա Ծովամթերքներ ամբողջական.jpg", Description = "Рукола, листя салату, томати чері, лосось, морський коктейль, каперси,  соус 'Неаполітано', соус Песто", DescriptionEng = "Arugula, lettuce, cherry tomatoes, salmon, sea ​​cocktail, capers, sauce 'Neapolitano', pesto sauce" });
            pizzas.Add(new Product { Name = "Піца з беконом Цілий", NameEng = "Pizza with bacon Whole", PicPath = "/Resources/ItalyUA/Պիցցա բեկոնով ամբողջական.jpg", Description = "Болгарський перець, томати чері, бекон, балик зі свинини, моцарела, пармезан", DescriptionEng = "Bell pepper, cherry tomatoes, bacon, pork balyk,mozzarella,parmesan" });
            pizzas.Add(new Product { Name = "Піца Салямі Цілий", NameEng = "Pizza with salami Whole", PicPath = "/Resources/ItalyUA/Պիցցա սալյամի ամբողջական.jpg", Description = "Салямі, томати чері, орегано, оливки, моцарела, пармезан", DescriptionEng = "Salami, cherry tomatoes, oregano, olives, mozzarella, parmesan" });
            pizzas.Add(new Product { Name = "Піца Римська Цілий", NameEng = "Pizza Roman Whole", PicPath = "/Resources/ItalyUA/Պիցցա հռոմեական ամբողջական.jpg", Description = "Рукола, болгарський перець, цукіні, баклажан, соус Песто, моцарела, пармезан", DescriptionEng = "Arugula, bell pepper, zucchini,eggplant,pesto sauce,mozzarella,parmesan" });
            pizzas.Add(new Product { Name = "Піца Чотири сири Цілий", NameEng = "Pizza four cheeses Whole", PicPath = "/Resources/ItalyUA/Պիցցա 4 պանիր ամբողջական.jpg", Description = "Чеддер, моцарела, пармезан, дор блю, сметана, соус 'Неаполітано'", DescriptionEng = "Cheddar cheese, mozzarella, parmesan, Dorblu, sour cream,sauce ''Neapolitano'" });
            pizzas.Add(new Product { Name = "Піца Капрезе Цілий", NameEng = "Pizza Caprese Whole", PicPath = "/Resources/ItalyUA/Պիցցա կապրեզե ամբողջական.jpg", Description = "Моцарела, соус 'Неаполітано', песто, базилік, молочна моцарела", DescriptionEng = "Mozzarella, sauce 'Neapolitano', pesto, basil, milk mozzarella" });
            pizzas.Add(new Product { Name = "Піца Верде Цілий", NameEng = "Pizza Verde Whole", PicPath = "/Resources/ItalyUA/Պիցցա Վեռդե ամբողջական.jpg", Description = "Рослинні вершки, рукола, гриби, соус 'Неаполітано', броколі, цукіні. баклажан", DescriptionEng = "Vegetable cream, arugula, mushrooms, sauce 'Neapolitano',broccoli,zucchini.eggplant" });
            pizzas.Add(new Product { Name = "Піца Римська з прошуто Цілий", NameEng = "Pizza roman with prosciutto Whole", PicPath = "/Resources/ItalyUA/roman pizza proshuto whole.jpg", Description = "Прошуто, рукола, томати черрі, крем чіз, моцарела, сир гран спіко", DescriptionEng = "Prosciutto, arugula, cherry tomatoes, cream cheese, mozzarella, gran spicco cheese" });
            pizzas.Add(new Product { Name = "Піца Римська Пепероні Цілий", NameEng = "Pizza roman Pepperoni Whole", PicPath = "/Resources/ItalyUA/roman pizza pepperoni whole.jpg", Description = "Моцарела, рукола, томати чері, чорізо, сир гран спіко, молочна моцарела", DescriptionEng = "Mozzarella, arugula, cherry tomatoes,Chorizo,gran spicco cheese,milk mozzarella" });
            pizzas.Add(new Product { Name = "Піца Римська Капрезе Цілий", NameEng = "Pizza roman Caprese Whole", PicPath = "/Resources/ItalyUA/roman pizza caprese whole.jpg", Description = "Моцарела, сир гран спіко, базиліко, томати чері, соус Песто, молочна моцарела", DescriptionEng = "Mozzarella, gran spicco cheese, basil, cherry tomatoes, Pesto sauce, milk mozzarella" });
            pizzas.Add(new Product { Name = "Піца Італіано Цілий", NameEng = "Pizza Italiano Whole", PicPath = "/Resources/ItalyUA/Պիցցա իտալյանո ամբողջական.jpg", Description = "Балик з телятини, рукола, томати чері, сир гран спіко, сир моцарела, пармезан", DescriptionEng = "Beef fillet, arugula, cherry tomatoes, cheese gran spicco, mozzarella" });
            pizzas.Add(new Product { Name = "Респелла (переместить в горячее)", NameEng = "Respella", PicPath = "/Resources/ItalyUA/Respella.jpg", Description = "Курка, рукола, томати чері, моцарела, вершковий сир", DescriptionEng = "Chicken breast, arugula, cherry tomatoes, mozzarella, cream cheese" });
            pizzas.Add(new Product { Name = "Естате ін Італіано Цілий", NameEng = "Estate in Italiano Whole", PicPath = "/Resources/ItalyUA/estante in italiano.jpg", Description = "Маслини, оливки, томати чері, болгарський перець, моцарела, сир фета, листя салату", DescriptionEng = "Black and green olives, cherry tomatoes, bell peppers, mozzarella, feta cheese, lettuce" });



            categories.Add(new Categorie { Name = "Піца", NameEng = "Pizzas", Products = pizzas, CategoriePic = "/Resources/Italy/Cover/Պիցցա.png" });


            List<Product> pastas = new List<Product>();

            pastas.Add(new Product { Name = "Аррабіята /250 гр./", NameEng = "Arrabbiata /250 g/", PicPath = "/Resources/ItalyUA/Պաստա Արաբիատա.jpg", Description = "Перець чілі, базилік, томатний соус, пармезан, в'ялені томати", DescriptionEng = "Chilli, basil, tomato sauce, sun-dried tomatoes, parmesan" });
            pastas.Add(new Product { Name = "Карбонара /300 гр./", NameEng = "Carbonara /300 g/", PicPath = "/Resources/ItalyUA/Պաստա Կարբոնարա.jpg", Description = "Бекон, вершки, біле вино, цибуля ріпчаста, пармезан, перепелине яйце", DescriptionEng = "Bacon, cream, white wine, onion,parmesan,quail egg" });
            pastas.Add(new Product { Name = "Болоньєзе /350 гр./", NameEng = "Bolognese /350 g/", PicPath = "/Resources/ItalyUA/Պաստա Բոլոնեզ.jpg", Description = "Соус Болоньєзе, червоне вино, томатний соус, пармезан, в'ялені томати", DescriptionEng = "Bolognese sauce, red wine, tomato sauce, sun-dried tomatoes, parmesan" });
            pastas.Add(new Product { Name = "Паста з лососем у вершковому соусі /320гр./", NameEng = "Pasta with salmon in creamy sauce /320g/", PicPath = "/Resources/ItalyUA/Պաստա Սաղմոնով.jpg", Description = "Вершки 20%, соус песто, філе лосося, цибуля, пармезан", DescriptionEng = "Cream 20%, Pesto sauce, salmon fillet, onion, parmesan" });
            pastas.Add(new Product { Name = "Паста з телятиною в томатно-вершковому соусі /320 гр./ ", NameEng = "Pasta with veal in tomato-cream sauce /320 g/", PicPath = "/Resources/ItalyUA/Հորթի միս տոմատային սերուցքով.jpg", Description = "Філе телятини, печериці, вершки, томатний соус, пармезан, в'ялен томати, петрушка", DescriptionEng = "Veal fillet, mushrooms, cream, tomato sauce, parmesan, sun-dried tomatoes" });
            pastas.Add(new Product { Name = "Альфредо /300 гр./", NameEng = "Alfredo /300 g/", PicPath = "/Resources/ItalyUA/Պաստա Ալֆրեդո.jpg", Description = "Курка, печериці, вершки, перепелине яйце, крем-чіз, пармезан", DescriptionEng = "Chicken breast, mushrooms, cream, quail egg, cream cheese, parmesan" });
            pastas.Add(new Product { Name = "Паста Фрутті ді Маре", NameEng = "Pasta Frutti di Mare", PicPath = "/Resources/ItalyUA/Պաստա դի մարե.jpg", Description = "Креветка, шпинат, базилік, сир, томати чері, орегано", DescriptionEng = "Shrimps, spinach, basilic, cheese, cherry tomatoes, cream" });
            pastas.Add(new Product { Name = "Паста Горгонзола", NameEng = "Pasta gorgonzola", PicPath = "/Resources/ItalyUA/Պաստա գորգոնզոլա.jpg", Description = "Крем чіз, томати чері, цибуля, сир рокфор, вершки, пармезан, біле вино", DescriptionEng = "Cream cheese, cherry tomatoes, onions, roquefort cheese, cream, parmesan, white wine" });
            pastas.Add(new Product { Name = "Паста Верде з соусом песто /320 гр./", NameEng = "Pasta Verde with pesto sauce /320 g/", PicPath = "/Resources/ItalyUA/Պաստա Վեռդե պեստո սոուսով.jpg", Description = "Болгарський перець, цукіні, морква, броколі, базилік, соус песто, томати чері, пармезан", DescriptionEng = "Bell pepper, zucchini, carrot, broccoli, basil, pesto sauce, cherry tomatoes, parmesan" });


            categories.Add(new Categorie { Name = "Паста", NameEng = "Pastas", Products = pastas, CategoriePic = "/Resources/Italy/Cover/Պաստա.png" });


            List<Product> hotDishes = new List<Product>();

            hotDishes.Add(new Product { Name = "Лазанья Болоньєзе /400 гр./", NameEng = "Lasagne Bolognese /400 g/", PicPath = "/Resources/ItalyUA/Լազանյա բոլոնեզի միջուկով.jpg", Description = "Соус Болоньєзе, паста (лазанья), томатний соус, соус бешамель, моцарела, пармезан", DescriptionEng = "Bolognese sauce, pasta (lasagna), tomato sauce, béchamel, mozzarella, parmesan" });
            hotDishes.Add(new Product { Name = "Лазанья Чотири сири /400 гр./", NameEng = "Four Cheese Lasagne /400 g/", PicPath = "/Resources/ItalyUA/Լազանյա 4 պանիր.jpg", Description = "Паста (лазанья), чеддер, пармезан, дор блю, моцарела, соус 'Наполітано'", DescriptionEng = "Pasta (lasagna), cheddar, parmesan, dorblu, mozzarella, sauce 'Neapolitano'" });
            hotDishes.Add(new Product { Name = "Рол Альфредо /320 гр./", NameEng = "Chicken Alfredo Roll /320 g/", PicPath = "/Resources/ItalyUA/ՌոլլԱլֆրեդո.jpg", Description = "Курка, томати чері, гриби, соус песто", DescriptionEng = "Chicken breast, cherry tomatoes, mushrooms, pesto sauce" });
            hotDishes.Add(new Product { Name = "Рол Альфредо з телятиною/320 гр./", NameEng = "Beef Alfredo Roll /320 g/", PicPath = "/Resources/ItalyUA/Beef roll alfredo.jpg", Description = "Філе телятини, томати чері, гриби, соус песто", DescriptionEng = "Beef, cherry tomatoes, mushrooms, pesto sauce" });
            hotDishes.Add(new Product { Name = "Сабc з телятиною", NameEng = "Subs with veal", PicPath = "/Resources/ItalyUA/Սաբս հորթի մսով.jpg", Description = "Телятина, тісто, томати, червонокачанна капуста, оцет бальзамічний, салат айсберг, соус 'Наполітано'", DescriptionEng = "Veal, dough, tomatoes, purple cabbage, balsamic vinegar, iceberg lettuce, sauce 'Napolitano'" });
            hotDishes.Add(new Product { Name = "Бефстроганів Імпасто з телятиною", NameEng = "Beef stroganoff impasto, beef", PicPath = "/Resources/ItalyUA/Բիֆստրոգանով իմպաստո, տավարի մսով.jpg", Description = "Теляча вирізка, печериці, сир моцарела, пармезан, вершки, орегано, соус 'Наполітано'", DescriptionEng = "Veal tenderloin, champignon, mozarella cheese, parmesan cheese, cream, oregano, sauce 'Neapolitano'" });
            hotDishes.Add(new Product { Name = "Бефстроганів Імпасто з куркою", NameEng = "Beef stroganoff impasto, chicken", PicPath = "/Resources/ItalyUA/Բիֆստրոգանով իմպաստո,  հավի մսով.jpg", Description = "Курка, перечиці, моцарела, пармезан, вершки, орегано, соус 'Наполітано'", DescriptionEng = "Chicken, champignon, mozarella cheese, parmesan cheese, cream, oregano, sauce 'Neapolitano'" });



            categories.Add(new Categorie { Name = "Горячие блюда", NameEng = "Hot dishes", Products = hotDishes, CategoriePic = "/Resources/Italy/Cover/hot dishes.png" });


            List<Product> soups = new List<Product>();

            soups.Add(new Product { Name = "Грибний крем-суп/250 гр./", NameEng = "Mushroom cream soup /250 g/", PicPath = "/Resources/ItalyUA/Սնկով կրեմապուր.jpg", Description = "Печериці, картопля, вершки", DescriptionEng = "Champignons, potatoes, cream" });
            soups.Add(new Product { Name = "Гарбузовий крем-суп /250 гр./", NameEng = "Pumpkin cream soup /250 g/", PicPath = "/Resources/ItalyUA/Դդմով կրեմապուր.jpg", Description = "Гарбуз, морква, картопля, вершки", DescriptionEng = "Pumpkin, carrots, potatoes, cream" });
            soups.Add(new Product { Name = "Крем-суп з броколі", NameEng = "Broccoli cream-soup", PicPath = "/Resources/ItalyUA/Բրոկոլիով կրեմ ապուր.jpg", Description = "Броколі, шпинат, крем чіз, морква, вершки, яйце перепелине, базилік", DescriptionEng = "Broccoli, spinach, cream-cheese, carrot, cream, quail egg, basilic" });
            soups.Add(new Product { Name = "Гаспачо", NameEng = "Gazpacho", PicPath = "/Resources/ItalyUA/Գասպաչոjpg.jpg", Description = "Перецб болгарський, томати, петрушка, базилік, часник, тост", DescriptionEng = "Bell peppers, tomato, celery, basilic, garlic, toast bread" });
            soups.Add(new Product { Name = "Мінестроне", NameEng = "Minestrone", PicPath = "/Resources/ItalyUA/minestrone.jpg", Description = "Стручкова квасоля, броколі, сир, гран спіко, селера, болгарський перець, зелена цибуля", DescriptionEng = "Green beans, broccoli, cheese Gran Spicco, celery, bell pepper, green onion" });



            categories.Add(new Categorie { Name = "Супы", NameEng = "Soups", Products = soups, CategoriePic = "/Resources/Italy/Cover/soups.png" });

            List<Product> salads = new List<Product>();

            salads.Add(new Product { Name = "Горгонзола /200гр./", NameEng = "Gorgonzola /200g/", PicPath = "/Resources/ItalyUA/Աղցան գորգոնզոլա.jpg", Description = "Шпинат, печериці, сир Рокфор, зелень, лимонний сік, оцет", DescriptionEng = "Spinach, mushrooms, Roquefort cheese, greens, lemon juice, vinegar" });
            salads.Add(new Product { Name = "Цезар з куркою /230 гр./", NameEng = "Caesar with chicken /230g/", PicPath = "/Resources/ItalyUA/Աղցան կեսար հավի մսով.jpg", Description = "Курка, салат айсберг, салат ромен, соус Цезар, перепелині яйця, пармезан", DescriptionEng = "Chicken breast, Iceberg lettuce, Romano lettuce, Caesar sauce, quail eggs, parmesan" });
            salads.Add(new Product { Name = "Цезар з морепродуктами /240 гр./", NameEng = "Caesar with seafood /240g/", PicPath = "/Resources/ItalyUA/Աղցան Կեսար ծովամթերքով.jpg", Description = "Морепродукти, салат айсберг, салат ромен, соус Цезар, пармезан, перепелині яйця", DescriptionEng = "Shrimps, Iceberg lettuce, Romano lettuce, Caesar sauce, parmesan, quail eggs" });
            salads.Add(new Product { Name = "Капрезе з соусом Песто /200 гр./", NameEng = "Caprese with Pesto sauce /200g/", PicPath = "/Resources/ItalyUA/Աղցան կապրեզե.jpg", Description = "Моцарела, томати, соус песто, базилік", DescriptionEng = "Milk mozzarella, tomatoes, pesto sauce, basil" });
            salads.Add(new Product { Name = "Рукола з томатами чері /200 гр./", NameEng = "Arugula with cherry tomatoes /200 g/", PicPath = "/Resources/ItalyUA/Աղցան Ռուկոլա չերիով.jpg", Description = "Рукола, листя салату, томати чері, соус карпачо, пармезан", DescriptionEng = "Arugula, lettuce, cherry tomatoes, carpaccio sauce, parmesan" });
            salads.Add(new Product { Name = "Фіорі /240 гр./", NameEng = "Fiori /240 g/", PicPath = "/Resources/ItalyUA/Salad Fiori.jpg", Description = "Лаваш, болгарський перець, моцарела, балик зі свинини", DescriptionEng = "Lavash, bell pepper, dry mozzarella, bacon, pork balyk" });
            salads.Add(new Product { Name = "Неаполь /240 гр./", NameEng = "Naples /240 g/", PicPath = "/Resources/ItalyUA/Աղցան Նապոլի.jpg", Description = "Курка, червона квасоля, болгарський перець, майонез, сметана, петрушка", DescriptionEng = "Chicken breast, red beans, bell pepper, mayonnaise, sour cream, parsley" });
            salads.Add(new Product { Name = "Аросто ді Поло", NameEng = "Di Polo Arosto", PicPath = "/Resources/ItalyUA/Դի պոլո արոստո.jpg", Description = "Курка, шпинат, листкове тісто, кускус, яйце перепелине, рукола, в'ялені томати, соус Сальса Б'янко", DescriptionEng = "Chicken breast, spinach, puff pastry, couscous, quail egg, sun - dried tomatoes,Salsa Bianco sauce" });
            salads.Add(new Product { Name = "Вітелло", NameEng = "Vitello", PicPath = "/Resources/ItalyUA/Վիտելլո.jpg", Description = "Філе телятини, листкове тісто, імбир, рукола, шпинат, перепелині яйця, листя салату, соус сальса Б'янко", DescriptionEng = "Beef, puff pastry, ginger, arugula, spinach, quail eggs,lettuce,Salsa Bianco sauce" });
            salads.Add(new Product { Name = "Літній Капрезе Фарро", NameEng = "Summer Caprese Farro", PicPath = "/Resources/ItalyUA/Summer Caprese Farro.jpg", Description = "Фета, томати чері, листя салату, оливки, огірок, базилік", DescriptionEng = "Feta cheese, cherry tomatoes, lettuce, green olives, cucumber, basil" });
            salads.Add(new Product { Name = "Петро Дантра", NameEng = "Petro Dantra", PicPath = "/Resources/ItalyUA/Պետռո Դանտրա.jpg", Description = "Рукола, качина грудка, біле вино, вершковий сир, апельсин,насіння соняшникове, персик, мед, розмарин, гірчиця, крем-чіз, полуниця", DescriptionEng = "Arugula, duck breast, white wine, cream cheese, orange, sunflower seeds, peach, honey, rosemary, mustard, cream cheese,strawberries" });
            salads.Add(new Product { Name = "Кускус по-італійськи", NameEng = "Italian Couscous", PicPath = "/Resources/ItalyUA/Italian kuskus.jpg", Description = "Рукола, болгарський перець, томати чері, цукіні, сир гран спіко, зелений горошок", DescriptionEng = "Arugula, bell pepper, cherry tomatoes, zucchini, gran spicco cheese, green peas" });


            categories.Add(new Categorie { Name = "Салаты", NameEng = "Salads", Products = salads, CategoriePic = "/Resources/Italy/Cover/salads.png" });

            

            
        }
    }
}
