namespace Zoolandia.Animals
{
    public interface ISwimming
    {
        int fins {get;set;}
        int waterspeed {get;set;}
        string swim();  
    }
}