using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Eagle : CarnivoreBird
    {
        public Eagle()
            : base()
        {
            Wingspan = new Random().Next(150, 240);
            CarnivorousFoodType = CarnivorousNutritionType.GopherMeat;
            AnimalType = AnimalType.Eagle;
        }
    }
}
