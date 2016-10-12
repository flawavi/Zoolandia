namespace Zoolandia.Animals
{
    public interface IAnimal
    {
        int GestationDays {get;set;}
        string CoatColor {get;set;}
        bool IsDomesticated {get;set;}
        string GetRange(string name);
    }
}