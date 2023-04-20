using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public abstract class CarnivoreBird : Bird
    {
        protected CarnivoreBird()
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
