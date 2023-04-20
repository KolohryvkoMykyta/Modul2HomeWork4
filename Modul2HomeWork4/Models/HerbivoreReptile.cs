using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public abstract class HerbivoreReptile : Reptile
    {
        protected HerbivoreReptile()
            : base()
        {
            NutritionType = NutritionType.Herbivore;
        }

        public HerbivoreNutritionType HerbivoreFoodType { get; protected set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Eats: {HerbivoreFoodType}");
        }
    }
}
