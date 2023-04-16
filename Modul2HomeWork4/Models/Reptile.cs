using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public abstract class Reptile : Animal
    {
        protected Reptile()
            : base()
        {
            AnimalClass = AnimalClass.Reptile;
        }

        public int PawsNumber { get; protected set; }

        public override void Print()
        {
            base.Print();
            Console.Write($"PawsNumber: {PawsNumber}, ");
        }
    }
}
