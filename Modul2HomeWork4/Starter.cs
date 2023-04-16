using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4
{
    public static class Starter
    {
        public static void Run()
        {
            var section = new SafariParkSection(UserInteraction.ChooseAnimalsNumber());

            var animalFilterHelper = new AnimalFilterHelper(section.Animals);
            animalFilterHelper.FilterAnimalsByUserRequirements();
        }
    }
}
