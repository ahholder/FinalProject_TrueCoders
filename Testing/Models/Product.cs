using System.Collections;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Testing.Models
{
    /*public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }*/
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sexid { get; set; }
        public int age { get; set; }
        public int raceid { get; set; }
        public int classid { get; set; }
        public string bio { get; set; }
        public IEnumerable<Archetype> archetype { get; set; }
        public IEnumerable<Heritage> heritage { get; set; }
        public IEnumerable<Sex> sex { get; set; }
        public string DisplayGender(int sex)
        {
            if (sex == 0) return "Male";
            if (sex == 1) return "Female";
            return "Other";
        }
        public string DisplayHeritage(int race)
        {
            if (race == 0) return "Dwarf";
            if (race == 1) return "Elf";
            if (race == 2) return "Gnome";
            if (race == 3) return "Halfling";
            if (race == 4) return "Human";
            if (race == 5) return "Orc";
            return "Other";
        }
        public string DisplayArchetype(int job)
        {
            if (job == 0) return "Bard";
            if (job == 1) return "Cleric";
            if (job == 2) return "Druid";
            if (job == 3) return "Mage";
            if (job == 4) return "Monk";
            if (job == 5) return "Paladin";
            if (job == 6) return "Ranger";
            if (job == 7) return "Rogue";
            if (job == 8) return "Warlock";
            if (job == 9) return "Warrior";
            return "Other";
        }
        public string VisualAid(int id)
        {
            if (id == 0) return "https://1001freedownloads.s3.amazonaws.com/vector/thumb/98360/opensourcebear_guitar.png"; //Bard
            if (id == 1) return "https://static.vecteezy.com/system/resources/previews/001/194/209/non_2x/cross-gothic-png.png"; //Cleric
            if (id == 2) return "https://www.nicepng.com/png/full/117-1176628_simple-black-leaf-clip-art-at-clker-black.png"; //Druid
            if (id == 3) return "https://www.clipartqueen.com/image-files/open-book-silhouette.png"; //Mage
            if (id == 4) return "https://www.pngplay.com/wp-content/uploads/15/Karate-Black-Belt-Transparent-File.png"; //Monk
            if (id == 5) return "https://freepngimg.com/save/24094-shield-clip-art-black-and-white-transparent/504x600"; //Paladin
            if (id == 6) return "https://www.freeiconspng.com/thumbs/bow-and-arrow-png/bow-and-arrow-png-picture-3.png"; //Ranger
            if (id == 7) return "https://pngimg.com/d/dagger_PNG48.png"; //Rogue
            if (id == 8) return "https://i.kisscc0.com/20180705/baw/kisscc0-vampire-the-masquerade-vampire-the-eternal-strug-dracoconic-ouroboros-symbol-5b3dfb3458aa32.3012231015307886603632.png"; //Warlock
            if (id == 9) return "https://www.pngmart.com/files/1/Cross-Sword-PNG-Clipart.png"; //Warrior
            return "https://www.freeiconspng.com/thumbs/gear-icon/gear-icon-13.png"; //Other
        }
    }
}
