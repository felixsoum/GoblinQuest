using System;
using System.Collections.Generic;

namespace GoblinQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq1();
            //Linq2();
            //Linq3();
        }

        static void Battle(Goblin goblin1, Goblin goblin2)
        {
            //goblin1.Attack(goblin2);
            //goblin2.Attack(goblin1);
            //...?
        }

        /// <summary>
        /// Greatsword
        /// Greataxe
        /// Sword
        /// Axe
        /// Dagger
        /// Baton
        /// Croissant
        /// </summary>
        static void Linq1()
        {
            var result = Weapon.SortByCostDescending(CreateWeapons());
            foreach (var weapon in result)
            {
                Console.WriteLine(weapon.name);
            }
        }

        /// <summary>
        /// Greatsword
        /// Greataxe
        /// </summary>
        static void Linq2()
        {
            var result = Weapon.FilterEpicOnly(CreateWeapons());
            foreach (var weapon in result)
            {
                Console.WriteLine(weapon.name);
            }
        }

        /// <summary>
        /// Baton
        /// Croissant
        /// </summary>
        static void Linq3()
        {
            var result = Weapon.FilterFreeOnly(CreateWeapons());
            foreach (var weapon in result)
            {
                Console.WriteLine(weapon.name);
            }
        }

        static List<Weapon> CreateWeapons()
        {
            return new List<Weapon>()
            {
                new Weapon("Sword", Rarity.Rare, 75),
                new Weapon("Greatsword", Rarity.Epic, 200),
                new Weapon("Baton", Rarity.Common, 0),
                new Weapon("Dagger", Rarity.Common, 10),
                new Weapon("Croissant", Rarity.Common, 0),
                new Weapon("Axe", Rarity.Rare, 50),
                new Weapon("Greataxe", Rarity.Epic, 100),
            };
        }
    }
}
