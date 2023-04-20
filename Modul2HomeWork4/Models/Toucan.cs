using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Toucan : HerbivoreBird
    {
        public Toucan()
            : base()
        {
            Wingspan = new Random().Next(110, 155);
            HerbivoreFoodType = HerbivoreNutritionType.PassionFruit;
            AnimalType = AnimalType.Toucan;
        }
    }
}
