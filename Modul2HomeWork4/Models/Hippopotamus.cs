using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Hippopotamus : HerbivoreMammal
    {
        public Hippopotamus()
            : base()
        {
            WoolLength = 0;
            HerbivoreFoodType = HerbivoreNutritionType.Grass;
            AnimalType = AnimalType.Hippopotamus;
        }
    }
}
