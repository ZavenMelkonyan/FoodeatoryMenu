using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Models.Georgian
{
    public class Categorie
    {
        public string Name { get; set; }
        public string NameArm { get; set; }
        public string NameRus { get; set; }
        public List<Product> Products { get; set; }
        public bool isQR { get; set; }
        public string CategoriePic { get; set; }
    }
}
