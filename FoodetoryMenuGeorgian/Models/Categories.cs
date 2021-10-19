using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models
{
    public class Categories
    {
        public List<Tuple<string, string, string>> categories = new List<Tuple<string, string, string>>();
        public Categories()
        {
            categories.Add(new Tuple<string, string, string>("Maki", "MakiArm", "MakiRus"));
            categories.Add(new Tuple<string, string, string>("Rolls", "RollsArm", "RollsRus"));
            categories.Add(new Tuple<string, string, string>("HotRolls", "HotRollsArm", "HotRollsRus"));
            categories.Add(new Tuple<string, string, string>("FriedRolls", "FriedRollsArm", "FriedRollsRus"));
            categories.Add(new Tuple<string, string, string>("Sushi", "SushiArm", "SushiRus"));
            categories.Add(new Tuple<string, string, string>("Gunkan", "GunkanArm", "GunkanRus"));
            categories.Add(new Tuple<string, string, string>("Temaki", "TemakiArm", "TemakiRus"));
            categories.Add(new Tuple<string, string, string>("Sashimi", "SashimiArm", "SashimiRus")); 
            categories.Add(new Tuple<string, string, string>("Other", "OtherArm", "OtherRus"));
            categories.Add(new Tuple<string, string, string>("Salads", "SaladsArm", "SaladsRus"));
            categories.Add(new Tuple<string, string, string>("Soups", "SoupsArm", "SoupsRus"));
            categories.Add(new Tuple<string, string, string>("Wok", "WokArm", "WokRus"));
            categories.Add(new Tuple<string, string, string>("Sets", "SetsArm", "SetsRus"));

        }
    }
}
