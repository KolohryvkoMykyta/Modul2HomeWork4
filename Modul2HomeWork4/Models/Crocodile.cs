using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Crocodile : CarnivoreReptiles
    {
        public Crocodile()
            : base()
        {
            PawsNumber = 4;
            CarnivorousFoodType = CarnivorousNutritionType.Fish;
            AnimalType = AnimalType.Crocodile;
        }
    }
}
