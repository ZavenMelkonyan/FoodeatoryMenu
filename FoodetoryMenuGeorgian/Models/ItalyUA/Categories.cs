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


            pizzas.Add(new Product { Name = "Піца Пепероні Цілий", NameEng = "Pizza Pepperoni Whole", PicPath = "/Resources/ItalyUA/Պիցցա պեպերոնի ամբողջական.jpg", Description = "Сир, моцарела, пармезан, ковбаса Чорізо", DescriptionEng = "cheese, mozzarella, parmesan, Choriso sausage" });
            pizzas.Add(new Product { Name = "Піца Маргарита Цілий", NameEng = "Pizza Margarita Whole", PicPath = "/Resources/ItalyUA/Պիցցա Մարգարիտա ամբողջական.jpg", Description = "Томати, моцарела, пармезан, базилік", DescriptionEng = "tomatoes, mozzarella, parmesan, basil" });
            pizzas.Add(new Product { Name = "Піца Цезар Цілий", NameEng = "Pizza Caesar Whole", PicPath = "/Resources/ItalyUA/Պիցցա կեսար ամբողջական.jpg", Description = "Соус Цезар, листя салату, курка", DescriptionEng = "Caesar sauce, lettuce, chicken breast" });
            pizzas.Add(new Product { Name = "Кальцоне маленька", NameEng = "Calzone small", PicPath = "/Resources/ItalyUA/Կալզոնե փոքր.jpg", Description = "Курка, гриби, печериці, моцарела", DescriptionEng = "fillet, mushrooms, champignons, mozzarella" });
            pizzas.Add(new Product { Name = "Кальцоне велика", NameEng = "Calzone big", PicPath = "/Resources/ItalyUA/Կալզոնե մեծ.jpg", Description = "Курка, гриби, печериці, моцарела", DescriptionEng = "fillet, mushrooms, champignons, mozzarella" });
            pizzas.Add(new Product { Name = "Піца з морепродуктами Цілий", NameEng = "Pizza with seafood Whole", PicPath = "/Resources/ItalyUA/Պիցցա Ծովամթերքներ ամբողջական.jpg", Description = "Рукола, листя салату, томати чері, лосось", DescriptionEng = "arugula, lettuce, cherry tomatoes, salmon" });
            pizzas.Add(new Product { Name = "Піца з беконом Цілий", NameEng = "Pizza with bacon Whole", PicPath = "/Resources/ItalyUA/Պիցցա բեկոնով ամբողջական.jpg", Description = "Болгарський перець, томати чері, бекон", DescriptionEng = "bell pepper, cherry tomatoes, bacon" });
            pizzas.Add(new Product { Name = "Піца Салямі Цілий", NameEng = "Pizza with salami Whole", PicPath = "/Resources/ItalyUA/Պիցցա սալյամի ամբողջական.jpg", Description = "Салямі, томати чері, орегано, оливки", DescriptionEng = "salami, cherry tomatoes, oregano, olives" });
            pizzas.Add(new Product { Name = "Піца Римська Цілий", NameEng = "Pizza Roman Whole", PicPath = "/Resources/ItalyUA/Պիցցա հռոմեական ամբողջական.jpg", Description = "Рукола, болгарський перець, гарбуз", DescriptionEng = "arugula, bell pepper, pumpkin" });
            pizzas.Add(new Product { Name = "Піца Чотири сири Цілий", NameEng = "Pizza four cheeses Whole", PicPath = "/Resources/ItalyUA/Պիցցա 4 պանիր ամբողջական.jpg", Description = "Чеддер, моцарела, пармезан, дор блю", DescriptionEng = "cheddar cheese, mozzarella, parmesan, Dorblu" });
            pizzas.Add(new Product { Name = "Піца Капрезе Цілий", NameEng = "Pizza Caprese Whole", PicPath = "/Resources/ItalyUA/Պիցցա կապրեզե ամբողջական.jpg", Description = "Моцарела, вершковий соус, песто, базилік", DescriptionEng = "mozzarella, milk pesto sauce, basil" });
            pizzas.Add(new Product { Name = "Піца Верде Цілий", NameEng = "Pizza Verde Whole", PicPath = "/Resources/ItalyUA/Պիցցա Վեռդե ամբողջական.jpg", Description = "Рослинні вершки, рукола, гриби, томати", DescriptionEng = "vegetable cream, arugula, mushrooms, tomatoes" });
            pizzas.Add(new Product { Name = "Піца Римська з прошуто Цілий", NameEng = "Pizza roman with prosciutto Whole", PicPath = "/Resources/ItalyUA/roman pizza proshuto whole.jpg", Description = "Прошуто, рукола, томати черрі, крем чіз, моцарела, сир гран спіко", DescriptionEng = "prosciutto, arugula, cherry tomatoes, cream cheese, mozzarella, gran spicco cheese" });
            pizzas.Add(new Product { Name = "Піца Римська Пепероні Цілий", NameEng = "Pizza roman Pepperoni Whole", PicPath = "/Resources/ItalyUA/roman pizza pepperoni whole.jpg", Description = "Моцарела, рукола, томати чері, пепероні, сир гран спіко", DescriptionEng = "mozzarella, arugula, cherry tomatoes, pepperoni, gran spicco cheese" });
            pizzas.Add(new Product { Name = "Піца Римська Капрезе Цілий", NameEng = "Pizza roman Caprese Whole", PicPath = "/Resources/ItalyUA/roman pizza caprese whole.jpg", Description = "Моцарела, сир гран спіко, базиліко, томати чері", DescriptionEng = "mozzarella, gran spicco cheese, basil, cherry tomatoes" });
            pizzas.Add(new Product { Name = "Піца Італіано Цілий", NameEng = "Pizza Italiano Whole", PicPath = "/Resources/ItalyUA/Պիցցա իտալյանո ամբողջական.jpg", Description = "Філе телятини, рукола, томати чері, сир гран спіко, сир моцарела", DescriptionEng = "beef fillet, arugula, cherry tomatoes, cheese gran spicco, mozzarella" });
            pizzas.Add(new Product { Name = "Респелла", NameEng = "Respella", PicPath = "/Resources/ItalyUA/Respella.jpg", Description = "Курка, рукола, томати чері, моцарела, вершковий сир", DescriptionEng = "chicken breast, arugula, cherry tomatoes, mozzarella, cream cheese" });
            pizzas.Add(new Product { Name = "Естате ін Італіано Цілий", NameEng = "Estate in Italiano Whole", PicPath = "/Resources/ItalyUA/estante in italiano.jpg", Description = "Маслини, оливки, томати чері, болгарський перець, моцарела, сир фета, листя салату", DescriptionEng = "black and green olives, cherry tomatoes, bell peppers, mozzarella, feta cheese, lettuce" });



            categories.Add(new Categorie { Name = "Піца", NameEng = "Pizzas", Products = pizzas, CategoriePic = "/Resources/Italy/Cover/Պիցցա.png" });


            List<Product> pastas = new List<Product>();

            pastas.Add(new Product { Name = "Аррабіята /250 гр./", NameEng = "Arrabbiata /250 g/", PicPath = "/Resources/ItalyUA/Պաստա Արաբիատա.jpg", Description = "Перець чілі, базилік, томатний соус", DescriptionEng = "chilli, basil, tomato sauce" });
            pastas.Add(new Product { Name = "Карбонара /300 гр./", NameEng = "Carbonara /300 g/", PicPath = "/Resources/ItalyUA/Պաստա Կարբոնարա.jpg", Description = "Бекон, вершки, біле вино", DescriptionEng = "bacon, cream, white wine" });
            pastas.Add(new Product { Name = "Болоньєзе /350 гр./", NameEng = "Bolognese /350 g/", PicPath = "/Resources/ItalyUA/Պաստա Բոլոնեզ.jpg", Description = "Філе телятини, червоне вино, томатний соус", DescriptionEng = "veal fillet, red wine, tomato sauce" });
            pastas.Add(new Product { Name = "Паста з лососем у вершковому соусі /320гр./", NameEng = "Pasta with salmon in creamy sauce /320g/", PicPath = "/Resources/ItalyUA/Պաստա Սաղմոնով.jpg", Description = "Вершки 20%, соус песто, філе лосося", DescriptionEng = "cream 20%, Pesto sauce, salmon fillet" });
            pastas.Add(new Product { Name = "Паста з телятиною в томатно-вершковому соусі /320 гр./ ", NameEng = "Pasta with veal in tomato-cream sauce /320 g/", PicPath = "/Resources/ItalyUA/Հորթի միս տոմատային սերուցքով.jpg", Description = "Філе телятини, печериці, вершки, томатний соус", DescriptionEng = "veal fillet, mushrooms, cream, tomato sauce" });
            pastas.Add(new Product { Name = "Альфредо /300 гр./", NameEng = "Alfredo /300 g/", PicPath = "/Resources/ItalyUA/Պաստա Ալֆրեդո.jpg", Description = "Курка, печериці, вершки", DescriptionEng = "chicken breast, mushrooms, cream" });
            pastas.Add(new Product { Name = "Паста Фрутті ді Маре", NameEng = "Pasta Frutti di Mare", PicPath = "/Resources/ItalyUA/Պաստա դի մարե.jpg", Description = "Креветка, шпинат, базилік, сир, томати чері, орегано", DescriptionEng = "shrimps, spinach, basilic, cheese, cherry tomatoes, cream" });
            pastas.Add(new Product { Name = "Паста Горгонзола", NameEng = "Pasta gorgonzola", PicPath = "/Resources/ItalyUA/Պաստա գորգոնզոլա.jpg", Description = "Крем чіз, томати чері, цибуля, сир рокфор, вершки", DescriptionEng = "cream cheese, cherry tomatoes, onions, roquefort cheese, cream" });
            pastas.Add(new Product { Name = "Паста Верде з соусом песто /320 гр./", NameEng = "Pasta Verde with pesto sauce /320 g/", PicPath = "/Resources/ItalyUA/Պաստա Վեռդե պեստո սոուսով.jpg", Description = "Болгарський перець, гарбуз, морква, броколі, базилік, соус песто, томати чері", DescriptionEng = "bell pepper, pumpkin, carrot, broccoli, basil, pesto sauce, cherry tomatoes" });


            categories.Add(new Categorie { Name = "Паста", NameEng = "Pastas", Products = pastas, CategoriePic = "/Resources/Italy/Cover/Պաստա.png" });


            List<Product> hotDishes = new List<Product>();

            hotDishes.Add(new Product { Name = "Лазанья Болоньєзе /400 гр./", NameEng = "Lasagne Bolognese /400 g/", PicPath = "/Resources/ItalyUA/Լազանյա բոլոնեզի միջուկով.jpg", Description = "Філе телятини, паста (лазанья), томатний соус, соус бешамель", DescriptionEng = "veal fillet, pasta (lasagna), tomato sauce, béchamel" });
            hotDishes.Add(new Product { Name = "Лазанья Чотири сири /400 гр./", NameEng = "Four Cheese Lasagne /400 g/", PicPath = "/Resources/ItalyUA/Լազանյա 4 պանիր.jpg", Description = "Паста (лазанья), чеддер, пармезан, дор блю, моцарела", DescriptionEng = "pasta (lasagna), cheddar, parmesan, dorblu, mozzarella" });
            hotDishes.Add(new Product { Name = "Рол Альфредо /320 гр./", NameEng = "Chicken Alfredo Roll /320 g/", PicPath = "/Resources/ItalyUA/ՌոլլԱլֆրեդո.jpg", Description = "Курка, томати чері, гриби, соус песто", DescriptionEng = "chicken breast, cherry tomatoes, mushrooms, pesto sauce" });
            hotDishes.Add(new Product { Name = "Рол Альфредо з телятиною/320 гр./", NameEng = "Beef Alfredo Roll /320 g/", PicPath = "/Resources/ItalyUA/Beef roll alfredo.jpg", Description = "Філе телятини, томати чері, гриби, соус песто", DescriptionEng = "beef, cherry tomatoes, mushrooms, pesto sauce" });
            hotDishes.Add(new Product { Name = "Сабc з телятиною", NameEng = "Subs with veal", PicPath = "/Resources/ItalyUA/Սաբս հորթի մսով.jpg", Description = "Телятина, тісто, томати чері, червонокачанна капуста, оцет бальзамічний", DescriptionEng = "veal, dough, cherry tomatoes, purple cabbage, balsamic vinegar" });
            hotDishes.Add(new Product { Name = "Бефстроганів Імпасто з телятиною", NameEng = "Beef stroganoff impasto, beef", PicPath = "/Resources/ItalyUA/Բիֆստրոգանով իմպաստո, տավարի մսով.jpg", Description = "Філе телятини, печериці, сир моцарела, пармезан, вершки, орегано", DescriptionEng = "beef, champignon, mozarella cheese, parmesan cheese, cream, oregano" });
            hotDishes.Add(new Product { Name = "Бефстроганів Імпасто з куркою", NameEng = "Beef stroganoff impasto, chicken", PicPath = "/Resources/ItalyUA/Բիֆստրոգանով իմպաստո,  հավի մսով.jpg", Description = "Курка, перечиці, моцарела, пармезан, вершки, орегано", DescriptionEng = "chicken, champignon, mozarella cheese, parmesan cheese, cream, oregano" });



            categories.Add(new Categorie { Name = "Горячие блюда", NameEng = "Hot dishes", Products = hotDishes, CategoriePic = "/Resources/Italy/Cover/hot dishes.png" });


            List<Product> soups = new List<Product>();

            soups.Add(new Product { Name = "Грибний крем-суп/250 гр./", NameEng = "Mushroom cream soup /250 g/", PicPath = "/Resources/ItalyUA/Սնկով կրեմապուր.jpg", Description = "Печериці, картопля, вершки", DescriptionEng = "champignons, potatoes, cream" });
            soups.Add(new Product { Name = "Гарбузовий крем-суп /250 гр./", NameEng = "Pumpkin cream soup /250 g/", PicPath = "/Resources/ItalyUA/Դդմով կրեմապուր.jpg", Description = "Гарбуз, морква, картопля, вершки", DescriptionEng = "pumpkin, carrots, potatoes, cream" });
            soups.Add(new Product { Name = "Крем-суп з броколі", NameEng = "Broccoli cream-soup", PicPath = "/Resources/ItalyUA/Բրոկոլիով կրեմ ապուր.jpg", Description = "Броколі, шпинат, крем чіз, морква, вершки, яйце перепелине, базилік", DescriptionEng = "broccoli, spinach, cream-cheese, carrot, cream, quail egg, basilic" });
            soups.Add(new Product { Name = "Гаспачо", NameEng = "Gazpacho", PicPath = "/Resources/ItalyUA/Գասպաչոjpg.jpg", Description = "Перецб болгарський, томати, петрушка, базилік, часник, тост", DescriptionEng = "bell peppers, tomato, celery, basilic, garlic, toast bread" });
            soups.Add(new Product { Name = "Мінестроне", NameEng = "Minestrone", PicPath = "/Resources/ItalyUA/minestrone.jpg", Description = "Зелена квасоля, броколі, сир, гран спіко, селера, болгарський перець", DescriptionEng = "green beans, broccoli, cheese Gran Spicco, celery, bell pepper" });



            categories.Add(new Categorie { Name = "Супы", NameEng = "Soups", Products = soups, CategoriePic = "/Resources/Italy/Cover/soups.png" });

            List<Product> salads = new List<Product>();

            salads.Add(new Product { Name = "Горгонзола /200гр./", NameEng = "Gorgonzola /200g/", PicPath = "/Resources/ItalyUA/Աղցան գորգոնզոլա.jpg", Description = "Шпинат, печериці, сир рокфор, зелень", DescriptionEng = "spinach, mushrooms, Roquefort cheese, greens" });
            salads.Add(new Product { Name = "Цезар з куркою /230 гр./", NameEng = "Caesar with chicken /230g/", PicPath = "/Resources/ItalyUA/Աղցան կեսար հավի մսով.jpg", Description = "Курка, салат айсберг, салат ромен, соус Цезар", DescriptionEng = "chicken breast, Iceberg lettuce, Romano lettuce, Caesar sauce" });
            salads.Add(new Product { Name = "Цезар з морепродуктами /240 гр./", NameEng = "Caesar with seafood /240g/", PicPath = "/Resources/ItalyUA/Աղցան Կեսար ծովամթերքով.jpg", Description = "Морепродукти, салат айсберг, салат ромен, соус Цезар", DescriptionEng = "seafood, Iceberg lettuce, Romano lettuce, Caesar sauce" });
            salads.Add(new Product { Name = "Капрезе з соусом Песто /200 гр./", NameEng = "Caprese with Pesto sauce /200g/", PicPath = "/Resources/ItalyUA/Աղցան կապրեզե.jpg", Description = "Моцарела, томати, соус песто", DescriptionEng = "milk mozzarella, tomatoes, pesto sauce" });
            salads.Add(new Product { Name = "Рукола з томатами чері /200 гр./", NameEng = "Arugula with cherry tomatoes /200 g/", PicPath = "/Resources/ItalyUA/Աղցան Ռուկոլա չերիով.jpg", Description = "Рукола, листя салату, томати чері, соус карпачо", DescriptionEng = "arugula, lettuce, cherry tomatoes, carpaccio sauce" });
            salads.Add(new Product { Name = "Фіорі /240 гр./", NameEng = "Fiori /240 g/", PicPath = "/Resources/ItalyUA/Salad Fiori.jpg", Description = "Лаваш, болгарський перець, моцарела, бекон", DescriptionEng = "lavash, bell pepper, dry mozzarella, bacon" });
            salads.Add(new Product { Name = "Неаполь /240 гр./", NameEng = "Naples /240 g/", PicPath = "/Resources/ItalyUA/Աղցան Նապոլի.jpg", Description = "Курка, червона квасоля, болгарський перець", DescriptionEng = "chicken breast, red beans, bell pepper" });
            salads.Add(new Product { Name = "Аросто ді Поло", NameEng = "Di Polo Arosto", PicPath = "/Resources/ItalyUA/Դի պոլո արոստո.jpg", Description = "Курка, шпинат, листкове тісто, кускус, яйце перепелине", DescriptionEng = "chicken breast, spinach, puff pastry, couscous, quail egg" });
            salads.Add(new Product { Name = "Вітелло", NameEng = "Vitello", PicPath = "/Resources/ItalyUA/Վիտելլո.jpg", Description = "Філе телятини, листкове тісто, імбир, рукола, шпинат", DescriptionEng = "beef, puff pastry, ginger, arugula, spinach" });
            salads.Add(new Product { Name = "Літній Капрезе Фарро", NameEng = "Summer Caprese Farro", PicPath = "/Resources/ItalyUA/Summer Caprese Farro.jpg", Description = "Фета, томати чері, листя салату, оливки, огірок, базилік", DescriptionEng = "feta cheese, cherry tomatoes, lettuce, green olives, cucumber, basil" });
            salads.Add(new Product { Name = "Петро Дантра", NameEng = "Petro Dantra", PicPath = "/Resources/ItalyUA/Պետռո Դանտրա.jpg", Description = "Рукола, качина грудка, біле вино, вершковий сир, апельсин,насіння соняшникове, персик, мед, розмарин, гірчиця", DescriptionEng = "arugula, duck breast, white wine, cream cheese, orange, sunflower seeds, peach, honey, rosemary, mustard" });
            salads.Add(new Product { Name = "Кускус по-італійськи", NameEng = "Italian Couscous", PicPath = "/Resources/ItalyUA/Italian kuskus.jpg", Description = "Рукола, болгарський перець, томати чері, гарбуз, сир гран спіко, зелений горошок", DescriptionEng = "arugula, bell pepper, cherry tomatoes, pumpkin, gran spicco cheese, green peas" });


            categories.Add(new Categorie { Name = "Салаты", NameEng = "Salads", Products = salads, CategoriePic = "/Resources/Italy/Cover/salads.png" });

            

            
        }
    }
}
