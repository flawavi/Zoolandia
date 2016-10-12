namespace Zoolandia.Habitats
{
    public interface IDesert
    {
        int moistureLevel {get;set;}
        int avgTemp {get;set;}
        string drought(int days);
    }
}