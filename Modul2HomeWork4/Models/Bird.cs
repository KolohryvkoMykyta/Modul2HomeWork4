using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public abstract class Bird : Animal
    {
        protected Bird()
            : base()
        {
            AnimalClass = AnimalClass.Bird;
        }

        public int Wingspan { get; protected set; }

        public override void Print()
        {
            base.Print();

            Console.Write($"Wingspan: {Wingspan} cm, ");
        }
    }
}
