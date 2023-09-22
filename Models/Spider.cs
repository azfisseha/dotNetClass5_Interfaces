using System;
using Class05.Interfaces;

namespace Class05.Models
{
    public class Spider : ICombatant
    {
        public string Name { get; set; }
        public IArmor Armor { get; set; }
        public IWeapon Weapon { get; set; }

        public Spider(string name, IArmor armor, IWeapon weapon)
        {
            Name = name;
            Armor = armor;
            Weapon = weapon;

        }
        public void Attack(ICombatant enemy)
        {
            Console.WriteLine($"{Name} {Weapon.Name}s {enemy.Name}!");
        }
    }
}
