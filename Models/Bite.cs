using Class05.Interfaces;

namespace Class05.Models
{
    public class Bite : IWeapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Bite(int power)
        {
            Name = "Bite";
            Power = power;
        }
    }
}
