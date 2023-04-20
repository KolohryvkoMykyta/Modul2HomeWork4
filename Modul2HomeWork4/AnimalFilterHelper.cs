using Modul2HomeWork4.Enums;
using Modul2HomeWork4.Models;

namespace Modul2HomeWork4
{
    public class AnimalFilterHelper
    {
        private Animal[] _animals;
        private Animal[] _previousStepAnimals;
        private Animal[] _initialAnimals;

        public AnimalFilterHelper(Animal[] animals)
        {
            _animals = animals;
            _previousStepAnimals = animals;
            _initialAnimals = animals;
        }

        public void FilterAnimalsByUserRequirements()
        {
            var @continue = true;
            bool isPrinted = false;

            while (@continue)
            {
                isPrinted = false;
                _previousStepAnimals = _animals;
                _animals = Filter();

                PrintCount();

                if (_animals.Length < 1)
                {
                    if (HandleEmptyArray())
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                var needToPrint = UserInteraction.AskForPrint();

                if (needToPrint)
                {
                    PrintAnimals();
                    isPrinted = true;
                }

                @continue = UserInteraction.AskForContinue();
            }

            if (!isPrinted)
            {
                PrintAnimals();
            }
        }

        private bool HandleEmptyArray()
        {
            var actionForEmptyArray = UserInteraction.AskForActionForEmptyArray();

            switch (actionForEmptyArray)
            {
                case 0:
                    _animals = _previousStepAnimals;
                    return true;
                case 1:
                    _animals = _initialAnimals;
                    return true;
                default:
                    return false;
            }
        }

        private void PrintCount()
        {
            Console.WriteLine($"\nFound {_animals.Count()} animals in section");
        }

        private Animal[] Filter()
        {
            var filterType = UserInteraction.AskForFilterType();

            return filterType switch
            {
                FilterType.Nutrition => FilterByNutritionType(),
                FilterType.Class => FilterByAnimalClass(),
                FilterType.Type => FilterByAnimalType(),
                _ => new Animal[0]
            };
        }

        private void PrintAnimals()
        {
            foreach (var animal in _animals)
            {
                animal.Print();
            }
        }

        private Animal[] FilterByNutritionType()
        {
            var nutritionType = UserInteraction.AskForNutritionType();

            return _animals.FilterAnimals(nutritionType);
        }

        private Animal[] FilterByAnimalClass()
        {
            var animalClass = UserInteraction.AskForAnimalClass();

            return _animals.FilterAnimals(animalClass);
        }

        private Animal[] FilterByAnimalType()
        {
            var animalType = UserInteraction.AskForAnimalType();

            return _animals.FilterAnimals(animalType);
        }
    }
}
