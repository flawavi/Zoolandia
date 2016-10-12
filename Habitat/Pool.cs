namespace Zoolandia.Habitats
{
    public class Pool: Habitat, IAquatic
    {
        public int avgWaterTemp {get;set;} 
        public bool isFreshwater {get;set;}
        public int maxDepth {get;set;}
        public int minDepth {get;set;}
        public int fillTime {get;set;}
        public string area(int height, int width)
        {
            return "The area of the surface of the pool is" + (height * width) + "feet.";
        }
    }
}