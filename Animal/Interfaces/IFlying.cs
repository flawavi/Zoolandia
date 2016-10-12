namespace Zoolandia.Animals
{
    public interface IFlying
    {
        int wingspan {get;set;}
        int airspeed {get;set;}
        int maxAltitude{get;set;}
        string fly();
        double airSpeed { get; set; }
    }
}