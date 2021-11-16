using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.Italy
{
    public class Categories
    {
        public List<Categorie> categories { get; set; }
        public Categories()
        {
            categories = new List<Categorie>();
            List<Product> pizzas = new List<Product>();

            pizzas.Add(new Product { Name = "Pizza Pepperoni", NameArm = "Պիցցա Պեպերոնի", NameRus = "Пицца Пепперони", Price = "2700/550", PicPath = "/Resources/Italy/Պիցցա պեպերոնի.png", Description = "cheese, mozzarella, parmesan, Choriso sausage", DescriptionArm = "պանիր, մոցառելլա, պարմեզան, երշիկ Choriso", DescriptionRus = "сыр, моцарелла, пармезан, колбаса Choriso" });
            pizzas.Add(new Product { Name = "Pizza Margarita", NameArm = "Պիցցա Մարգարիտա", NameRus = "Пицца Маргарита", Price = "1920/390", PicPath = "/Resources/Italy/Պիցցա Մարգարիտա.png", Description = "tomatoes, mozzarella, parmesan, basil", DescriptionArm = "լոլիկ, մոցառելլա,  պարմեզան, բազիլիկ", DescriptionRus = "помидоры, моцарелла, пармезан, базилик" });
            pizzas.Add(new Product { Name = "Pizza Caesar", NameArm = "Պիցցա Կեսար", NameRus = "Пицца Цезарь", Price = "2340/550", PicPath = "/Resources/Italy/Պիցցա կեսար.png", Description = "Caesar sauce, lettuce, chicken breast", DescriptionArm = "կեսարի սոուս, հազար, հավի կրծքամիս", DescriptionRus = "Соус Цезарь, листья салата, куриная грудка" });
            pizzas.Add(new Product { Name = "Pizza Calzone", NameArm = "Պիցցա Կալզոնե", NameRus = "Пицца Кальцоне", Price = "990/550", PicPath = "/Resources/Italy/Կալզոնե.png", Description = "fillet, mushrooms, champignons, mozzarella", DescriptionArm = "ֆիլե, սունկ, շամպինյոն,  մոցառելլա", DescriptionRus = "филе, грибы, шампиньоны, моцарелла" });
            pizzas.Add(new Product { Name = "Pizza with seafood", NameArm = "Պիցցա Ծովամթերքներ", NameRus = "Пицца с морепродуктами", Price = "3540/590", PicPath = "/Resources/Italy/Պիցցա ծովամթերքով.png", Description = "arugula, lettuce, cherry tomatoes, salmon", DescriptionArm = "ռուկկոլա, լետտուս, չերրի լոլիկ, սաղմոն", DescriptionRus = "руккола, листья салата, помидоры черри, лосось" });
            pizzas.Add(new Product { Name = "Pizza with bacon", NameArm = "Պիցցա Բեկոնով", NameRus = "Пицца с беконом", Price = "2340/450", PicPath = "/Resources/Italy/Պիցցա Բեկոնով.jpg", Description = "bell pepper, cherry tomatoes, bacon", DescriptionArm = "բուլղարական պղպեղ,  չերրի լոլիկ, բեկոն", DescriptionRus = "болгарский перец, помидоры черри, бекон" });
            pizzas.Add(new Product { Name = "Pizza with salami", NameArm = "Պիցցա Սալյամի", NameRus = "Пицца с салями", Price = "2700/450", PicPath = "/Resources/Italy/Պիցցա Սլայամի.png", Description = "salami, cherry tomatoes, oregano, olives", DescriptionArm = "սալյամի,  չերրի լոլիկ, օրեգանո, սեւ ձիթապտուղ", DescriptionRus = "салями, помидоры черри, орегано, оливки" });
            pizzas.Add(new Product { Name = "Pizza Roman", NameArm = "Պիցցա Հռոմեական", NameRus = "Пицца Римская", Price = "2700/550", PicPath = "/Resources/Italy/Պիցցա Հռոմեական.png", Description = "arugula, bell pepper, pumpkin", DescriptionArm = "ռուկկոլա,  բուլղարական պղպեղ, դդմիկ", DescriptionRus = "руккола, болгарский перец, тыква" });
            pizzas.Add(new Product { Name = "Pizza four cheeses", NameArm = "Պիցցա 4 պանիր", NameRus = "Пицца четыре сыра", Price = "2340/550", PicPath = "/Resources/Italy/Պիցցա 4 պանիր.png", Description = "cheddar cheese, mozzarella, parmesan, Dorblu", DescriptionArm = "պանիր չեդդեր, մոցառելլա, պարմեզան, դորբլյու", DescriptionRus = "сыр чеддер, моцарелла, пармезан, Дорблю" });
            pizzas.Add(new Product { Name = "Pizza Caprese", NameArm = "Պիցցա Կապրեզե", NameRus = "Пицца Капрезе", Price = "3300/550", PicPath = "/Resources/Italy/Պիցցա Կապրեզե.png", Description = "mozzarella, milk pesto sauce, basil", DescriptionArm = "մոցառելլա, կաթնային պեստո սոուս, բազիլիկ", DescriptionRus = "моцарелла, молочный соус песто, базилик" });
            pizzas.Add(new Product { Name = "Pizza Verde", NameArm = "Պիցցա Վեռդե", NameRus = "Пицца Верде", Price = "2100/490", PicPath = "/Resources/Italy/Պիցցա Վեռդե.png", Description = "vegetable cream, arugula, mushrooms, tomatoes", DescriptionArm = "բանջարեղենային սերուցք, ռուկկոլա, սունկ, լոլիկ", DescriptionRus = "растительные сливки, руккола, грибы, помидоры" });


            categories.Add(new Categorie { Name = "Pizzas", NameArm = "Պիցցաներ", NameRus = "Пиццы", Products = pizzas });


            List<Product> pastas = new List<Product>();

            pastas.Add(new Product { Name = "Arrabbiata /250 g/", NameArm = "Արաբիատա /250գր/", NameRus = "Арабиата /250 гр./", Price = "1300", PicPath = "/Resources/Italy/Պաստա Արաբիատա.png", Description = "chilli, basil, tomato sauce", DescriptionArm = "չիլի պղպեղ, բազիլիկ, տոմատային սոուս", DescriptionRus = "перец чили, базилик, томатный соус" });
            pastas.Add(new Product { Name = "Carbonara /300 g/", NameArm = "Կարբոնարա /300գր/", NameRus = "Карбонара /300 гр./", Price = "1600", PicPath = "/Resources/Italy/Պաստա Կարբոնարա.png", Description = "bacon, cream, white wine", DescriptionArm = "բեկոն, սերուցք, սպիտակ գինի", DescriptionRus = "бекон, сливки, белое вино" });
            pastas.Add(new Product { Name = "Bolognese /350 g/", NameArm = "Բոլոնեզ /350գր/", NameRus = "Болоньезе /350 гр./", Price = "1500", PicPath = "/Resources/Italy/Պաստա Բոլոնեզ.png", Description = "veal fillet, red wine, tomato sauce", DescriptionArm = "հորթի փափկամիս , կարմիր գինի,  տոմատային սոուս", DescriptionRus = "филе телятины, красное вино, томатный соус" });
            pastas.Add(new Product { Name = "Salmon in creamy sauce /320g/", NameArm = "Սաղմոն սերուցքային սոուսով  /320գր/ ", NameRus = "Лосось в сливочном соусе /320гр./", Price = "2500", PicPath = "/Resources/Italy/Պաստա Սաղմոնով.png", Description = "cream 20%, Pesto sauce, salmon fillet", DescriptionArm = "սերուցք 20%, պեստո սոուս, սաղմոնի ֆիլե", DescriptionRus = "сливки 20%, соус Песто, филе лосося" });
            pastas.Add(new Product { Name = "Veal in tomato-cream sauce /320 g/", NameArm = "Հորթի միս տոմատա-սերուցքային սոուսով / 320գր / ", NameRus = "Телятина в томатно - сливочном соусе / 320 гр./ ", Price = "1600", PicPath = "/Resources/Italy/Հորթի միս տոմատային սերուցքով.png", Description = "veal fillet, mushrooms, cream, tomato sauce", DescriptionArm = "սունկ շամպինյոն, սերուցք, տոմատային սոուս,հորթի փափկամիս", DescriptionRus = "филе телятины, шампиньоны, сливки, томатный соус " });
            pastas.Add(new Product { Name = "Alfredo /300 g/", NameArm = "Ալֆրեդո /300գր/", NameRus = "Альфредо /300 гр./", Price = "1600", PicPath = "/Resources/Italy/Պաստա Ալֆրեդո.png", Description = "chicken breast, mushrooms, cream", DescriptionArm = "հավի կրծքամիս,  սունկ  շամպինյոն,  սերուցք", DescriptionRus = "куриная грудка, шампиньоны, сливки" });


            categories.Add(new Categorie { Name = "Pastas", NameArm = "Պաստաներ", NameRus = "Паста", Products = pastas });


            List<Product> hotDishes = new List<Product>();

            hotDishes.Add(new Product { Name = "Risotto with mushrooms /300 g/", NameArm = "Ռիզոտտո սնկով / 300գր/", NameRus = "Ризотто с грибами /300 гр./", Price = "1100", PicPath = "/Resources/Italy/Ռիզոտտո սնկով.png", Description = "champignons, oyster mushrooms, Arborio rice", DescriptionArm = "սունկ  շամպինյոն, կախասունկ, բրինձ Arborio", DescriptionRus = "шампиньоны, вешенки, рис Арборио" });
            hotDishes.Add(new Product { Name = "Risotto with chicken and spinach /250 g/", NameArm = "Ռիզոտտո հավի մսով, սպանախով /250գր/", NameRus = "Ризотто с курицей и шпинатом / 250 гр./ ", Price = "1200", PicPath = "/Resources/Italy/Ռիզոտտո հավի մսով.png", Description = "chicken breast, spinach, Arborio rice", DescriptionArm = "բրինձ Arborio, սպանախ, հավի կրծքամիս", DescriptionRus = "куриная грудка, шпинат, рис Арборио" });
            hotDishes.Add(new Product { Name = "Lasagne Bolognese /400 g/", NameArm = "Լազանյա բոլոնեզի միջուկով / 400գր/", NameRus = "Лазанья Болоньезе /400 гр./", Price = "2600", PicPath = "/Resources/Italy/Լազանյա բոլոնեզի միջուկով.png", Description = "veal fillet, pasta (lasagna), tomato sauce, béchamel", DescriptionArm = "տոմատային սոուս, բեշամել, մակարոն (լազանի), հորթի փափկամիս", DescriptionRus = "филе телятины, паста (лазанья), томатный соус, бешамель " });
            hotDishes.Add(new Product { Name = "Four Cheese Lasagne /400 g/", NameArm = "Լազանյա 4 պանիր /400գր/", NameRus = "Лазанья Четыре сыра /400 гр./", Price = "2400", PicPath = "/Resources/Italy/Լազանյա 4 պանիր.png", Description = "pasta (lasagna), cheddar, parmesan, dorblu, mozzarella", DescriptionArm = "մակարոն (լազանի), չեդդեր,   պարմեզան, դորբլյու, մոցառելլա", DescriptionRus = "паста (лазанья), чеддер, пармезан, дорблю, моцарелла" });
            hotDishes.Add(new Product { Name = "Chicken Alfredo Roll /320 g/", NameArm = "Ռոլլ Ալֆրեդո /320գր/", NameRus = "Ролл Альфредо /320 гр./", Price = "1800", PicPath = "/Resources/Italy/ՌոլլԱլֆրեդո.png", Description = "chicken breast, cherry tomatoes, mushrooms, pesto sauce", DescriptionArm = "հավի կրծքամիս, չերրի լոլիկ, սոունկ, պեստո", DescriptionRus = "куриная грудка, помидоры черри, грибы, соус песто" });
            hotDishes.Add(new Product { Name = "Ravioli Bolognese /200g/", NameArm = "Ռավիոլի բոլոնեզ /200գր/", NameRus = "Равиоли Болоньезе / 200гр./", Price = "890", PicPath = "/Resources/Italy/Ռավիոլի բոլոնեզ.png", Description = "veal fillet, dough for lasagna, parmesan, tomato sauce", DescriptionArm = "հորթի փափկամիս, խմոր լազանի,  պարմեզան,տոմատային սոուս", DescriptionRus = "филе телятины, тесто для лазаньи, пармезан, томатный соус" });



            categories.Add(new Categorie { Name = "Hot dishes", NameArm = "Տաք ուտեստներ", NameRus = "Горячие блюда", Products = hotDishes });



            List<Product> soups = new List<Product>();

            soups.Add(new Product { Name = "Mushroom cream soup /250 g/", NameArm = "Սնկով կրեմապուր /250գր/  ", NameRus = "Грибной крем-суп 250 гр./", Price = "650", PicPath = "/Resources/Italy/Սնկով կրեմապուր.png", Description = "champignons, potatoes, cream", DescriptionArm = "սունկ  շամպինյոն, կարտոֆիլ, սերուցք", DescriptionRus = "шампиньоны, картофель, сливки" });
            soups.Add(new Product { Name = "Pumpkin cream soup /250 g/", NameArm = "Դդումով կրեմապուր/250գր/ ", NameRus = "Тыквенный крем-суп /250 гр./", Price = "650", PicPath = "/Resources/Italy/Դդմով կրեմապուր.png", Description = "pumpkin, carrots, potatoes, cream", DescriptionArm = "դդում, գազար, կարտոֆիլ, սերուցք", DescriptionRus = "тыква, морковь, картофель, сливки" });


            categories.Add(new Categorie { Name = "Soups", NameArm = "Ապուրներ", NameRus = "Супы", Products = soups });

            List<Product> salads = new List<Product>();

            salads.Add(new Product { Name = "Gorgonzola /200g/", NameArm = "Գորգոնզոլա /200գր/", NameRus = "Горгонзола /200гр./", Price = "1350", PicPath = "/Resources/Italy/Աղցան գորգոնզոլա.png", Description = "spinach, mushrooms, Roquefort cheese, greens", DescriptionArm = "սպանախ,  շամպինյոն, ռոկֆոր պանիր, կանաչիներ", DescriptionRus = "шпинат, шампиньоны, сыр рокфор, зелень" });
            salads.Add(new Product { Name = "Salmon Tartare /280g/", NameArm = "Թար-թար սաղմոնով /280գր/ ", NameRus = "Тар-тар из лосося /280гр./", Price = "2500", PicPath = "/Resources/Italy/Աղցան Թար-թար.png", Description = "salmon fillet, avocado, cucumber, caviar", DescriptionArm = "ավոկադո, խավիար, սյոմգայի ֆիլե, վարունգ", DescriptionRus = " филе симеги, огурец, авокадо, икра" });
            salads.Add(new Product { Name = "Caesar with chicken /230g/", NameArm = "Կեսար հավի մսով /230գր/ ", NameRus = "Цезарь с курицей /230 гр./", Price = "1400", PicPath = "/Resources/Italy/Աղցան կեսար հավի մսով.png", Description = "chicken breast, Iceberg lettuce, Romano lettuce, Caesar sauce", DescriptionArm = "այսբերգ հազար, ռոմանո,  կեսարի սոուս, հավի  կրծքամիս", DescriptionRus = "куриная грудка, салат айсберг, салат романо, соус цезарь " });
            salads.Add(new Product { Name = "Caesar with seafood /240g/", NameArm = "Կեսար ծովամթերքով/240գր/  ", NameRus = "Цезарь с морепродуктами /240 гр./", Price = "1700", PicPath = "/Resources/Italy/Աղցան Կեսար ծովամթերքով.png", Description = "seafood, Iceberg lettuce, Romano lettuce, Caesar sauce", DescriptionArm = "այսբերգ հազար, ռոմանո,  կեսարի սոուս, ծովամթերք", DescriptionRus = "морепродукты, салат айсберг, салат романо, соус цезарь " });
            salads.Add(new Product { Name = "Caprese with Pesto sauce /200g/", NameArm = "Կապրեզե պեստո սոուսով /200գր/", NameRus = "Капрезе с соусом Песто /200 гр./", Price = "1200", PicPath = "/Resources/Italy/Աղցան կապրեզե.png", Description = "milk mozzarella, tomatoes, pesto sauce", DescriptionArm = "կաթնային մոցառելլա, լոլիկ, պեստո սոուս", DescriptionRus = "молочная моцарелла, помидоры, соус песто" });
            salads.Add(new Product { Name = "Arugula with cherry tomatoes /200 g/", NameArm = "Ռուկկոլա չերրիով/200գր/", NameRus = "Руккола с помидорами черри /200 гр./", Price = "1500", PicPath = "/Resources/Italy/Աղցան Ռուկոլա չերիով.png", Description = "arugula, lettuce, cherry tomatoes, carpaccio sauce", DescriptionArm = "ռուկկոլա, հազար, կարպաչո սոուս, չերրի լոլիկ", DescriptionRus = "руккола, листья салата, помидоры черри, соус карпаччо" });
            salads.Add(new Product { Name = "Fiori /240 g/", NameArm = "Ֆիորի /240գր/", NameRus = "Фьори /240 гр./", Price = "1250", PicPath = "/Resources/Italy/Աղցան Ֆիորի.png", Description = "lavash, bell pepper, dry mozzarella, bacon", DescriptionArm = "լավաշ, բուլղարական պղպեղ, չոր  մոցառելլա, բեկոն", DescriptionRus = "лаваш, болгарский перец, сухая моцарелла, бекон" });
            salads.Add(new Product { Name = "Naples /240 g/", NameArm = "Նապոլի/240գր/", NameRus = "Неаполь /240 гр./", Price = "750", PicPath = "/Resources/Italy/Աղցան Նապոլի.png", Description = "chicken breast, red beans, bell pepper", DescriptionArm = "կարմիր լոբի, հավի կրծքամիս,  բուլղարական պղպեղ", DescriptionRus = "куриная грудка, красная фасоль, болгарский перец" });
            salads.Add(new Product { Name = "Verde", NameArm = "Վեռդե ", NameRus = "Верде", Price = "1400", PicPath = "/Resources/Italy/Աղցան Վեռդե.png", Description = "avocado, cucumber, lettuce, spinach, carpaccio sauce", DescriptionArm = "ավոկադո, վարունգ, հազար, սպանախ,  կարպաչո սոուս", DescriptionRus = "авокадо, огурец, листья салата, шпинат, соус карпаччо" });


            categories.Add(new Categorie { Name = "Salads", NameArm = "Աղցաններ", NameRus = "Салаты", Products = salads });


        }
    }
}
