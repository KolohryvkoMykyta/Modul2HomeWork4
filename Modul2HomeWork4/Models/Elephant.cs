using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Elephant : HerbivoreMammal
    {
        public Elephant()
            : base()
        {
            WoolLength = 0;
            HerbivoreFoodType = HerbivoreNutritionType.Leaves;
            AnimalType = AnimalType.Elephant;
        }
    }
}
