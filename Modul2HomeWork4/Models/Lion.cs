using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Lion : CarnivoreMammal
    {
        public Lion()
            : base()
        {
            WoolLength = new Random().Next(20, 40);
            CarnivorousFoodType = CarnivorousNutritionType.AntelopeMeat;
            AnimalType = AnimalType.Lion;
        }
    }
}
