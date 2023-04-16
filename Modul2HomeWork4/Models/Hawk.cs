using Modul2HomeWork4.Enums;

namespace Modul2HomeWork4.Models
{
    public class Hawk : CarnivoreBird
    {
        public Hawk()
            : base()
        {
            Wingspan = new Random().Next(70, 110);
            AnimalType = AnimalType.Elephant;
        }
    }
}
