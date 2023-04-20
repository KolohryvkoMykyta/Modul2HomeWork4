using Modul2HomeWork4.Enums;
using Modul2HomeWork4.Models;
using static System.Collections.Specialized.BitVector32;

namespace Modul2HomeWork4
{
    public class SafariParkSection
    {
        public SafariParkSection(int animalsNumber)
        {
            Animals = new Animal[animalsNumber];

            for (int i = 0; i < Animals.Length; i++)
            {
                FillingSection(i);
            }

            Array.Sort(Animals);

            Console.WriteLine($"\nSection has {Animals.GetAnimalsCount(AnimalClass.Bird)} birds, {Animals.GetAnimalsCount(AnimalClass.Mammal)} mammals," +
               $" {Animals.GetAnimalsCount(AnimalClass.Reptile)} reptiles");
        }

        public Animal[] Animals { get; private set; }

        private void FillingSection(int position)
        {
            int randomAnimal = new Random().Next(13);

            switch (randomAnimal)
            {
                case 0:
                    Animals[position] = new Agama();
                    break;
                case 1:
                    Animals[position] = new Cobra();
                    break;
                case 3:
                    Animals[position] = new Crocodile();
                    break;
                case 4:
                    Animals[position] = new Eagle();
                    break;
                case 5:
                    Animals[position] = new Elephant();
                    break;
                case 6:
                    Animals[position] = new Hawk();
                    break;
                case 7:
                    Animals[position] = new Hippopotamus();
                    break;
                case 8:
                    Animals[position] = new Hyena();
                    break;
                case 9:
                    Animals[position] = new Iguana();
                    break;
                case 10:
                    Animals[position] = new Lion();
                    break;
                case 11:
                    Animals[position] = new Partridge();
                    break;
                default:
                    Animals[position] = new Toucan();
                    break;
            }
        }
    }
}
