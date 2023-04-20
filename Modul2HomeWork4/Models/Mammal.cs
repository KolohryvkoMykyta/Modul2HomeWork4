using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public abstract class Mammal : Animal
    {
        protected Mammal()
            : base()
        {
            AnimalClass = AnimalClass.Mammal;
        }

        public int WoolLength { get; protected set; }

        public override void Print()
        {
            base.Print();
            Console.Write($"WoolLength: {WoolLength} cm, ");
        }
    }
}
