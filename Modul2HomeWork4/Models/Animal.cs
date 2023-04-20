using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public abstract class Animal : IComparable
    {
        protected Animal()
        {
            Name = ListOfNames.GetRandomName();
            Age = new Random().Next(3, 16);
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public AnimalType AnimalType { get; protected set; }
        public AnimalClass AnimalClass { get; protected set; }
        public NutritionType NutritionType { get; protected set; }

        public int CompareTo(object? obj)
        {
            return Age.CompareTo(((Animal)obj).Age);
        }

        public virtual void Print()
        {
            Console.Write($"\nName: {Name}, Age: {Age} years, Type: {AnimalType}, Class: {AnimalClass},\n NutritionType: {NutritionType}, ");
        }
    }
}
