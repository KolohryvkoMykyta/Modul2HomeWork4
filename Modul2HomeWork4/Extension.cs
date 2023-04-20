using Modul2HomeWork4.Enums;
using Modul2HomeWork4.Models;

namespace Modul2HomeWork4
{
    public static class Extension
    {
        public static int GetAnimalsCount(this Animal[] animals, AnimalType type)
        {
            int counter = 0;

            foreach (var animal in animals)
            {
                if (animal.AnimalType == type)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int GetAnimalsCount(this Animal[] animals, AnimalClass animalClass)
        {
            int counter = 0;

            foreach (var animal in animals)
            {
                if (animal.AnimalClass == animalClass)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int GetAnimalsCount(this Animal[] animals, NutritionType type)
        {
            int counter = 0;

            foreach (var animal in animals)
            {
                if (animal.NutritionType == type)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static Animal[] FilterAnimals(this Animal[] animals, AnimalType type)
        {
            Animal[] result = new Animal[animals.GetAnimalsCount(type)];
            var counter = 0;

            foreach (var animal in animals)
            {
                if (animal.AnimalType == type)
                {
                    result[counter] = animal;
                    counter++;
                }
            }

            return result;
        }

        public static Animal[] FilterAnimals(this Animal[] animals, AnimalClass animalClass)
        {
            Animal[] result = new Animal[animals.GetAnimalsCount(animalClass)];
            var counter = 0;

            foreach (var animal in animals)
            {
                if (animal.AnimalClass == animalClass)
                {
                    result[counter] = animal;
                    counter++;
                }
            }

            return result;
        }

        public static Animal[] FilterAnimals(this Animal[] animals, NutritionType type)
        {
            Animal[] result = new Animal[animals.GetAnimalsCount(type)];
            var counter = 0;

            foreach (var animal in animals)
            {
                if (animal.NutritionType == type)
                {
                    result[counter] = animal;
                    counter++;
                }
            }

            return result;
        }
    }
}
