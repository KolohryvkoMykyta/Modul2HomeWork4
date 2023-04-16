using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Cobra : CarnivoreReptiles
    {
        public Cobra()
           : base()
        {
            PawsNumber = 0;
            CarnivorousFoodType = CarnivorousNutritionType.Mice;
            AnimalType = AnimalType.Cobra;
        }
    }
}
