using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models
{
    public class Description
    {
        public Dictionary<string, string> descriptions = new Dictionary<string, string>();
        public Description()
        {
            descriptions.Add("Vegan Maki", "rice, cream cheese, nori, cucumber");
            descriptions.Add("Salmon Maki", "rice, cream cheese, nori, salmon");
            descriptions.Add("Smoked salmon Maki", "rice, cream cheese, nori, smoked salmon");
            descriptions.Add("Avocado Maki", "rice, cream cheese, nori, avocado");
            descriptions.Add("Kappa Maki", "rice, cream cheese, nori, cucumber, sesame");
            descriptions.Add("Unagi Maki", "rice, cream cheese, nori, eel");
            descriptions.Add("Chukka Maki", "rice, cream cheese, nori, chuka");
            descriptions.Add("Ebi Maki", "rice, cream cheese, nori, shrimp");
            descriptions.Add("Tuna Maki", "rice, cream cheese, nori, tuna");
            descriptions.Add("Philadelphia orange", "cheese, salmon, cucumber, avocado");
            descriptions.Add("Philadelphia classic", "cheese cremette, avocado, salmon fillet");
            descriptions.Add("Dragon", "eel, crab sticks, avocado, cucumber");
            descriptions.Add("Green Alaska", "cheese, cucumber, smoked salmon, dill");
            descriptions.Add("Layer", "salmon, cheese cremette, caviar");
            descriptions.Add("Sunshine", "eel, shrimps, salmon fillet");
            descriptions.Add("Double cheese", "cheese cremette, cheese president, cucumber");
            descriptions.Add("Chess", "salmon, tuna, tobiko, cucumber");
            descriptions.Add("Pyramid", "salmon fillet, cucumber, tobiko, cheese cremette");
            descriptions.Add("Canada", "eel, cheese cremette, avocado, crab sticks");
            descriptions.Add("Valentine", "tuna fillet, tobiko, cucumber, cremette cheese");
            descriptions.Add("California", "tobiko, cucumber, avocado, crab sticks");
            descriptions.Add("Caesar", "cheese cremette, lettuce, cucumber, cheese Gran Spicco");
            descriptions.Add("Ebi California", "tobiko, cucumber, avocado, shrimp");
            descriptions.Add("Green Dragon", "unagi, salmon fillet, avocado, cucumber, eel, cheese cremette ");
            descriptions.Add("Crazy Ebi", "salmon, cucumber, cremette cheese, tobiko, shrimps");
            descriptions.Add("Unagi Yaki", "avocado, unagi");
            descriptions.Add("Beef Yaki", "beef, tuna, cucumber, avocado, cheese");
            descriptions.Add("Ebi Tempura", "crab sticks, avocado");
            descriptions.Add("Salmon Tempura", "salmon, cheese, avocado, cucumber");
            descriptions.Add("Vegan Tempura", "pepper, cucumber");
            descriptions.Add("Unagi Tempura", "eel, cheese, cucumber, tobiko, avocado");
            descriptions.Add("Tuna-sushi", "tuna, rice");
            descriptions.Add("Salmon-sushi", "salmon, rice");
            descriptions.Add("Avocado-sushi", "avocado, rice");
            descriptions.Add("Unagi-sushi", "eel, rice");
            descriptions.Add("Shrimps-sushi", "shrimp, rice");
            descriptions.Add("Unagi Gunkan", "unagi, sauce, rice, nori");
            descriptions.Add("Salmon Gunkan", "salmon, sauce, rice, nori");
            descriptions.Add("Shrimps Gunkan", "shrimp, rice, nori");
            descriptions.Add("Salmon, caviar Gunkan", "salmon caviar, rice, nori");
            descriptions.Add("Unagi Temaki", "eel, cucumber, avocado, cheese");
            descriptions.Add("Ebi Temaki", "shrimps, cucumber");
            descriptions.Add("Salmon Temaki", "salmon, cucumber, caviar");
            descriptions.Add("Tuna Temaki", "tuna, cucumber");
            descriptions.Add("Caviar Temaki", "caviar, cucumber, avocado, cheese");
            descriptions.Add("Salmon Sashimi", "salmon fillet");
            descriptions.Add("Tuna Sashimi", "tuna fillet");
            descriptions.Add("Smoked Eels Sashimi", "eel fillet");
            descriptions.Add("Shrimps Sashimi", "shrimp");
            descriptions.Add("Ocean mushroom Sashimi", "sea mushrooms");
            descriptions.Add("Pizza Ocean Assortment", "crab meat, shrimps, eels, salmon, tobico, ocean mushroom");
            descriptions.Add("Shrimp sandwich", "bell pepper, cucumber, cheese");
            descriptions.Add("Chinese pig ears", "bell pepper, cucumber, sea mushroom");
            descriptions.Add("Chukya", "bell pepper, nut sauce, chuka");
            descriptions.Add("California Salad", "bell pepper, shrimps, cherry tomatoes, garlic sauce");
            descriptions.Add("Miso soup with shrimps", "shrimp, seaweed, mushrooms");
            descriptions.Add("Tom yum", "shrimps, oyster mushrooms, cherry tomatoes, chili peppers");
            descriptions.Add("Funchoza with pork", "pork, funchoza, bell pepper, green beans, leek, ginger");
            descriptions.Add("Udon with pork", "wheat noodles, pork, bell pepper, carrots, green beans, leek, ginger");
            descriptions.Add("Soba with pork", "buckwheat noodles, pork, green beans, bell pepper, garlic, leek, ginger");
            descriptions.Add("Tamago with pork", "egg noodles, pork, bell pepper, green beans, leek, ginger");
            descriptions.Add("Funchoza with chicken ", "rice noodles, chicken breast, bell pepper, green beans, leek, ginger");
            descriptions.Add("Soba with chicken", "chicken breast, bell pepper, green beans, leek, garlic, ginger");
            descriptions.Add("Tamago with chicken", "chicken breast, bell pepper, green beans, leek, garlic, ginger");
            descriptions.Add("Udon with chicken", "chicken breast, udon, carrot, bell pepper, leek, garlic, ginger");
            descriptions.Add("Soba with beef", "beef, buckwheat noodles, bell peppers, green beans, leek, garlic");
            descriptions.Add("Tamago with beef", "beef, egg tamago, bell pepper, green beans, leek, ginger");
            descriptions.Add("Udon with beef", "beef, udon, bell pepper, garlic, leek, ginger");
            descriptions.Add("Funchoza with beef", "beef, funchoza, green beans, bell peppers, carrots, leek, garlic");
            descriptions.Add("Soba with seafood cocktail", "soba, broccoli, ginger, carrots, pumpkin");
            descriptions.Add("Tamago with seafood cocktail", "tamago, broccoli, carrots, pumpkin, ginger");
            descriptions.Add("Udon with seafood cocktail", "udon, broccoli, ginger, carrots, pumpkin");
            descriptions.Add("Funchoza with seafood cocktail", "funchoza, broccoli, pumpkin, carrots, ginger");
            descriptions.Add("Mushroom wok with Udon", "honey mushrooms, oyster mushrooms, mushrooms, broccoli, bell pepper, pumpkin");
            descriptions.Add("Mushroom wok with rice", "honey mushrooms, oyster mushrooms, champignons, broccoli, Japanese rice");
            descriptions.Add("Mushroom wok with funchoza", "honey mushrooms, oyster mushrooms, champignons, broccoli, pumpkin, bell pepper");
            descriptions.Add("Set 1 – Salmon Set – 40 pieces", "0");
            descriptions.Add("Set 2 – Hot rolls set – 33 pieces", "0");
            descriptions.Add("Set 3 – Maki Set – 50 pieces", "0");
            descriptions.Add("Set 4 – Big Set – 80 pieces", "0"); 


        }
    }
}
