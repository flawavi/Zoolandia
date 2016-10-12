namespace Zoolandia.Animals
{
    public class Bonobo: Animal, IAnimal, IIntelligent, IAmbulatory
    {
        public int numLegs {get;set;}
        public int speed {get;set;}
        public int brainsize {get;set;}
        public bool canUseTools {get;set;}
        public bool isSelfAware {get;set;}
    }
}