using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Iguana : HerbivoreReptile
    {
        public Iguana()
           : base()
        {
            PawsNumber = 4;
            HerbivoreFoodType = HerbivoreNutritionType.Flowers;
            AnimalType = AnimalType.Iguana;
        }
    }
}
