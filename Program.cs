using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            IArmor armor = new Leather("Elven Leather Armor", 12);
            IWeapon sword = new Sword("Long sword", 5);

            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);

            fighter.Attack(badGuy);

            IWeapon bite = new Bite(9);
            IArmor natArmor = new NaturalArmor(14);
            ICombatant spider = new Spider("Giant Spider", natArmor, bite);

            spider.Attack(fighter);
        }

    }
}
