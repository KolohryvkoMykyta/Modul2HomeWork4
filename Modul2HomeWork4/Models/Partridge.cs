using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Partridge : HerbivoreBird
    {
        public Partridge()
            : base()
        {
            Wingspan = new Random().Next(14, 18);
            HerbivoreFoodType = HerbivoreNutritionType.Seeds;
            AnimalType = AnimalType.Partridge;
        }
    }
}
