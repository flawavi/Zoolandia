namespace Zoolandia.Habitats
{
    public class Sahara: Habitat, IDesert
    {
        public int avgTemp {get;set;}
        public string drought(int days)
        {
            return $"It hasn't rained in {days} days.";
        }
    }
}