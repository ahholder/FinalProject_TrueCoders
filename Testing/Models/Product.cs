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
    }
}
