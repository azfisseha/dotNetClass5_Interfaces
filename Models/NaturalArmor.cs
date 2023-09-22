using Class05.Interfaces;

namespace Class05.Models
{
    public class NaturalArmor : IArmor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        public NaturalArmor(int defense)
        {
            Name = "Natural Armor";
            Defense = defense;
        }
    }
}
