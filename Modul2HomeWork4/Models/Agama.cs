using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Agama : HerbivoreReptile
    {
        public Agama()
           : base()
        {
            PawsNumber = 4;
            HerbivoreFoodType = HerbivoreNutritionType.Flowers;
            AnimalType = AnimalType.Agama;
        }
    }
}
