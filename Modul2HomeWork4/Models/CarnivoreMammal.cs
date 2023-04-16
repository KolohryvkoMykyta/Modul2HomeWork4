using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public abstract class CarnivoreMammal : Mammal
    {
        protected CarnivoreMammal()
            : base()
        {
            NutritionType = NutritionType.Carnivore;
        }

        public CarnivorousNutritionType CarnivorousFoodType { get; protected set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Eats: {CarnivorousFoodType}");
        }
    }
}
