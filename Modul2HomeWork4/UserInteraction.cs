using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4
{
    public static class UserInteraction
    {
        public static int ChooseAnimalsNumber()
        {
            int result;
            Console.Write("Input the number of animals in the safari park: ");

            while (true)
            {
                var isCorrectInput = int.TryParse(Console.ReadLine(), out result);

                if (isCorrectInput && result > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Enter an integer greater than zero!");
                    Console.Write("Please try again: ");
                }
            }

            return result;
        }

        public static FilterType AskForFilterType()
        {
            Console.WriteLine("\nChoose by what criteria to sort the animals: (press 1, 2 or 3)\n1 Sort by Class\n2 Sort by Nutrition\n3 Sort by Type");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return FilterType.Class;
                    case '2':
                        return FilterType.Nutrition;
                    case '3':
                        return FilterType.Type;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1, 2 or 3!");
                        break;
                }
            }
        }

        public static NutritionType AskForNutritionType()
        {
            Console.WriteLine("\nChoose how to filter animals: (press 1 or 2)\n1 Herbivores Animals\n2 Carnivores Animals");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return NutritionType.Herbivore;
                    case '2':
                        return NutritionType.Carnivore;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1 or 2!");
                        break;
                }
            }
        }

        public static AnimalClass AskForAnimalClass()
        {
            Console.WriteLine("\nChoose how to filter animals: (press 1, 2 or 3)\n1 Bird\n2 Mammal\n3 Reptile");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return AnimalClass.Bird;
                    case '2':
                        return AnimalClass.Mammal;
                    case '3':
                        return AnimalClass.Reptile;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1, 2 or 3!");
                        break;
                }
            }
        }

        public static AnimalType AskForAnimalType()
        {
            Console.Write("\nChoose how to filter animals: (enter a number from 1 to 12)\n1 Eagle\n2 Hawk\n3 Partridge\n4 Toucan\n5 Lion\n6 Hyena\n7 Hippopotamus\n8 Elephant" +
                "\n9 Crocodile\n10 Cobra\n11 Iguana\n12 Agama\nYour choice: ");

            while (true)
            {
                string? choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        return AnimalType.Eagle;
                    case "2":
                        return AnimalType.Hawk;
                    case "3":
                        return AnimalType.Partridge;
                    case "4":
                        return AnimalType.Toucan;
                    case "5":
                        return AnimalType.Lion;
                    case "6":
                        return AnimalType.Hyena;
                    case "7":
                        return AnimalType.Hippopotamus;
                    case "8":
                        return AnimalType.Elephant;
                    case "9":
                        return AnimalType.Crocodile;
                    case "10":
                        return AnimalType.Cobra;
                    case "11":
                        return AnimalType.Iguana;
                    case "12":
                        return AnimalType.Agama;
                    default:
                        Console.WriteLine("\nIncorrect input! Enter a number from 1 to 12!");
                        Console.Write("Try again: ");
                        break;
                }
            }
        }

        public static int AskForActionForEmptyArray()
        {
            Console.WriteLine("\nThere are no animals matching your criteria!");
            Console.WriteLine("Choose what to do next: (press 1, 2 or 3)");
            Console.WriteLine("1 Reset previous filter");
            Console.WriteLine("2 Reset all filters");
            Console.WriteLine("3 Exit");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return 0;
                    case '2':
                        return 1;
                    case '3':
                        return 2;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1, 2 or 3!");
                        break;
                }
            }
        }

        public static bool AskForPrint()
        {
            Console.WriteLine("\nIf you want to see a list of all animals press SPACE button");
            Console.WriteLine("If not press any button");

            char choice = Console.ReadKey(true).KeyChar;

            if (choice == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AskForContinue()
        {
            Console.WriteLine("\nIf you want to continue press SPACE button");
            Console.WriteLine("To exit press any button");

            char choice = Console.ReadKey(true).KeyChar;

            if (choice == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
