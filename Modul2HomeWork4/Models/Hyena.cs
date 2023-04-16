using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Hyena : CarnivoreMammal
    {
        public Hyena()
            : base()
        {
            WoolLength = new Random().Next(15, 25);
            CarnivorousFoodType = CarnivorousNutritionType.ZebraMeat;
            AnimalType = AnimalType.Hyena;
        }
    }
}
