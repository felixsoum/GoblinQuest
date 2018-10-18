using System.Collections.Generic;
using System.Linq;

namespace GoblinQuest
{
    public enum Rarity
    {
        Common, Rare, Epic
    }

    public class Weapon
    {
        public string name;
        public Rarity rarity;
        public int cost;

        public Weapon(string name, Rarity rarity, int cost)
        {
            this.name = name;
            this.rarity = rarity;
            this.cost = cost;
        }

        public static List<Weapon> SortByCostDescending(List<Weapon> weapons)
        {
            var query = from weapon in weapons
                        select weapon;

            weapons = query.ToList();
            return weapons;
        }

        public static List<Weapon> FilterEpicOnly(List<Weapon> weapons)
        {
            var query = from weapon in weapons
                        select weapon;

            weapons = query.ToList();
            return weapons;
        }

        public static List<Weapon> FilterFreeOnly(List<Weapon> weapons)
        {
            var query = from weapon in weapons
                        select weapon;

            weapons = query.ToList();
            return weapons;
        }
    }
}
