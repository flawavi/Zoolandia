namespace Zoolandia.Animals
{
    public class Eagle: Animal, IAnimal, IFlying, IAmbulatory
    {
        public int wingspan {get;set;}
        public int numLegs {get;set;}
        public int speed {get;set;}
        public int airspeed {get;set;}
        public int maxAltitude {get;set;}
        public string fly()
        {
            return $"{name} is flying at {airspeed}mph";
        }
        public double airSpeed { get; set; }
    }
}