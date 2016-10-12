namespace Zoolandia.Animals
{
    public class Dolphin: Animal, IAnimal, ISwimming
    {
        public int fins {get;set;}
        public int waterspeed {get;set;}
        public string swim()
        {
            return $"{name} can swim up to {waterspeed}mph.";
        }

    }
}