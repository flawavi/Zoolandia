namespace Zoolandia.Animals
{
    public class Turtle: Animal, IAnimal, IAmbulatory, ISwimming
    {
        public int numLegs {get;set;}
        public int speed {get;set;}
        public int fins {get;set;}
        public int waterspeed {get;set;}
        public string swim()
        {
            return $"{name} can swim up to {waterspeed}mph.";
        }
    }
}