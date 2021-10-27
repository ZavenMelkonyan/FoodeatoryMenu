using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models
{
    public class Products
    {
        public List<Tuple<string, string, string>> products = new List<Tuple<string, string, string>>();
        public Products()
        {
            products.Add(new Tuple<string, string, string>("Vegan Maki", "Վեգան Մակի", "Веган маки"));
            products.Add(new Tuple<string, string, string>("Salmon Maki", "Սաղմոնով Մակի", "Маки с лососем"));
            products.Add(new Tuple<string, string, string>("Smoked salmon Maki", "Ապխտած սաղմոնով Մակի", "Маки с копченым лососем"));
            products.Add(new Tuple<string, string, string>("Avocado Maki", "Ավոկադոյով Մակի", "Маки с авокадо"));
            products.Add(new Tuple<string, string, string>("Kappa Maki", "Կապպա Մակի", "Каппа Маки"));
            products.Add(new Tuple<string, string, string>("Unagi Maki", "Ունագի Մակի", "Унаги Маки"));
            products.Add(new Tuple<string, string, string>("Chukka Maki", "Չուկա Մակի", "Чука Маки"));
            products.Add(new Tuple<string, string, string>("Ebi Maki", "Էբի Մակի", "Эбби Маки"));
            products.Add(new Tuple<string, string, string>("Tuna Maki", "Թունայով Մակի", "Маки с тунцом"));
            products.Add(new Tuple<string, string, string>("Philadelphia orange", "Ֆիլադելֆիա օրանժ", "Филадельфия оранж"));
            products.Add(new Tuple<string, string, string>("Philadelphia classic", "Ֆիլադելֆիա դասական", "Филадельфия классический"));
            products.Add(new Tuple<string, string, string>("Dragon", "Դրակոն", "Дракон"));
            products.Add(new Tuple<string, string, string>("Green Alaska", "Գրին Ալյասկա", "Грин Аляска"));
            products.Add(new Tuple<string, string, string>("Layer", "Լայեր", "Лайяр "));
            products.Add(new Tuple<string, string, string>("Sunshine", "Սանշայն", "Саншайн"));
            products.Add(new Tuple<string, string, string>("Double cheese", "Դաբլ-չիզ", "Двойной сыр"));
            products.Add(new Tuple<string, string, string>("Chess", "Շախմատ", "Шахматы"));
            products.Add(new Tuple<string, string, string>("Pyramid", "Պիրամիդա", "Пирамида"));
            products.Add(new Tuple<string, string, string>("Canada", "Կանադա", "Канада"));
            products.Add(new Tuple<string, string, string>("Valentine", "Վալենտինկա", "Валентинка"));
            products.Add(new Tuple<string, string, string>("California", "Կալիֆորնիա", "Калифорния"));
            products.Add(new Tuple<string, string, string>("Caesar", "Կեսար", "Цезарь"));
            products.Add(new Tuple<string, string, string>("Ebi California", "Էբի կալիֆորնիա", "Эбби Калифорния"));
            products.Add(new Tuple<string, string, string>("Green Dragon", "Գրին Դրակոն", "Зеленый дракон"));
            products.Add(new Tuple<string, string, string>("Crazy Ebi", "Քրեյզի Էբի", "Крейзи Эбби"));
            products.Add(new Tuple<string, string, string>("Unagi Yaki", "Ունագի Յակի", "Унаги Яки"));
            products.Add(new Tuple<string, string, string>("Beef Yaki", "Բիֆ Յակի", "Биф Яки"));
            products.Add(new Tuple<string, string, string>("Ebi Tempura", "Էբի Տեմպուրա", "Эбби Темпура"));
            products.Add(new Tuple<string, string, string>("Salmon Tempura", "Սաղմոնով Տեմպուրա", "Темпура с лососем"));
            products.Add(new Tuple<string, string, string>("Vegan Tempura", "Վեգան Տեմպուրա", "Веган Темпура"));
            products.Add(new Tuple<string, string, string>("Unagi Tempura", "Ունագի Տեմպուրա", "Унаги Темпура"));
            products.Add(new Tuple<string, string, string>("Tuna-sushi", "Թունա-սուշի", "Суши с тунцом"));
            products.Add(new Tuple<string, string, string>("Salmon-sushi", "Սաղմոն-սուշի", "Суши с лососем"));
            products.Add(new Tuple<string, string, string>("Avocado-sushi", "Ավոկադո-սուշի", "Суши с авокадо"));
            products.Add(new Tuple<string, string, string>("Unagi-sushi", "Ունագի-սուշի", "Унаги суши"));
            products.Add(new Tuple<string, string, string>("Shrimps-sushi", "Ծովախեցգետին-սուշի", "Суши с креветками"));
            products.Add(new Tuple<string, string, string>("Unagi Gunkan", "Ունագի Գուն-Կան", "Унаги Гункан"));
            products.Add(new Tuple<string, string, string>("Salmon Gunkan", "Սաղմոնով Գուն-Կան", "Гункан с лососем"));
            products.Add(new Tuple<string, string, string>("Shrimps Gunkan", "Ծովախեցգետնով Գուն-Կան", "Гункан с креветками"));
            products.Add(new Tuple<string, string, string>("Salmon, caviar Gunkan", "Սաղմոնով, ձկնկիթով Գուն-Կան", "Гункан с икрой лосося"));
            products.Add(new Tuple<string, string, string>("Unagi Temaki", "Ունագի Տեմակի", "Унаги Темаки"));
            products.Add(new Tuple<string, string, string>("Ebi Temaki", "Էբի Տեմակի", "Эбби Темаки"));
            products.Add(new Tuple<string, string, string>("Salmon Temaki", "Սաղմոնով Տեմակի", "Темаки с лососем"));
            products.Add(new Tuple<string, string, string>("Tuna Temaki", "Թունայով Տեմակի", "Темаки с тунцом"));
            products.Add(new Tuple<string, string, string>("Caviar Temaki", "Ձկնկիթով Տեմակի", "Темаки с икрой"));
            products.Add(new Tuple<string, string, string>("Salmon Sashimi", "Սաղմոնի Սաշիմի", "Сашими из лосося"));
            products.Add(new Tuple<string, string, string>("Tuna Sashimi", "Թունայով Սաշիմի", "Сашими из тунца"));
            products.Add(new Tuple<string, string, string>("Smoked Eels Sashimi", "Ապխտած ուգրով Սաշիմի", "Сашими с копченым угрем"));
            products.Add(new Tuple<string, string, string>("Shrimps Sashimi", "Ծովախեցգետնի Սաշիմի", "Сашими из креветок"));
            products.Add(new Tuple<string, string, string>("Ocean mushroom Sashimi", "Ծովային սնկով Սաշիմի", "Сашими с морскими грибами"));
            products.Add(new Tuple<string, string, string>("Pizza Ocean Assortment", "Պիցցա Ծովային Տեսականի", "Пицца с морепродуктами"));
            products.Add(new Tuple<string, string, string>("Shrimp sandwich", "Ծովախեցգետնով սենդվիչ", "Сэндвич с креветками"));
            products.Add(new Tuple<string, string, string>("Chinese pig ears", "Խոզի ականջներ 250g", "Свиные уши"));
            products.Add(new Tuple<string, string, string>("Chukya", "Չուկյա 160g", "Чукья"));
            products.Add(new Tuple<string, string, string>("California Salad", "Կալիֆորնիա Աղցան", "Калифорния Салат"));
            products.Add(new Tuple<string, string, string>("Miso soup with shrimps", "Միսո ապուր ծովախեցգետնով", "Мисо суп с креветками"));
            products.Add(new Tuple<string, string, string>("Tom yum", "Տոմ-Յամ", "Том ям"));
            products.Add(new Tuple<string, string, string>("Funchoza with pork", "Խոզի մսով ֆունչոզա", "Фунчоза со свининой"));
            products.Add(new Tuple<string, string, string>("Udon with pork", "Խոզի մսով Ուդոն", "Удон со свининой"));
            products.Add(new Tuple<string, string, string>("Soba with pork", "Խոզի մսով Սոբա", "Соба со свининой"));
            products.Add(new Tuple<string, string, string>("Tamago with pork", "Խոզի մսով Տամագո", "Тамаго со свининой"));
            products.Add(new Tuple<string, string, string>("Funchoza with chicken ", "Հավի մսով Ֆունչոզա", "Фунчоза с курицей"));
            products.Add(new Tuple<string, string, string>("Soba with chicken", "Հավի մսով Սոբա", "Соба с курицей"));
            products.Add(new Tuple<string, string, string>("Tamago with chicken", "Հավի մսով ձվի Տամագո", "Тамаго с курицей"));
            products.Add(new Tuple<string, string, string>("Udon with chicken", "Հավի մսով Ուդոն", "Удон с курицей"));
            products.Add(new Tuple<string, string, string>("Soba with beef", "Տավարի մսով Սոբա", "Соба с говядиной"));
            products.Add(new Tuple<string, string, string>("Tamago with beef", "Տավարի մսով ձվի Տամագո", "Тамаго с говядиной"));
            products.Add(new Tuple<string, string, string>("Udon with beef", "Տավարի մսով Ուդոն", "Удон с говядиной"));
            products.Add(new Tuple<string, string, string>("Funchoza with beef", "Տավարի մսով Ֆունչոզա", "Фунчоза с говядиной"));
            products.Add(new Tuple<string, string, string>("Soba with seafood cocktail", "Ծովային կոկտեյլ Սոբա", "Соба с морским коктейлем"));
            products.Add(new Tuple<string, string, string>("Tamago with seafood cocktail", "Ծովային կոկտեյլ Տամագո", "Тамаго с морским коктейлем"));
            products.Add(new Tuple<string, string, string>("Udon with seafood cocktail", "Ծովային կոկտեյլ Ուդոն", "Удон с морским коктейлем"));
            products.Add(new Tuple<string, string, string>("Funchoza with seafood cocktail", "Ծովային կոկտեյլ Ֆունչոզա", "Фунчоза с морским коктейлем"));
            products.Add(new Tuple<string, string, string>("Mushroom wok with Udon", "Սնկով վոկ Ուդոն", "Вок грибной с Удоном"));
            products.Add(new Tuple<string, string, string>("Mushroom wok with rice", "Սնկով վոկ բրնձով", "Вок грибной с рисом"));
            products.Add(new Tuple<string, string, string>("Mushroom wok with funchoza", "Սնկով վոկ ֆունչոզա", "Вок грибной с фунчозой"));
            products.Add(new Tuple<string, string, string>("Set one", "Սեթ մեկ", "Сет один"));
            products.Add(new Tuple<string, string, string>("Set two", "Սեթ երկու", "Сет два"));
            products.Add(new Tuple<string, string, string>("Set three", "Սեթ երեք", "Сет три"));
            products.Add(new Tuple<string, string, string>("Set four", "Սեթ չորս", "Сет четыре"));
        }
    }
}
