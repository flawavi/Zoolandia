namespace Zoolandia.Habitats
{
    public class Aviary: Habitat
    {
        public string cageType {get;set;}
        public string destination {get;set;}
        public string currentLocation {get;set;}
        public void move(string destination)
        {
            this.destination = destination;
        }
        public void build(int height, int depth, int width, int capacity, string cageType)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.cageType = cageType;
            this.capacity = capacity;
        }
        public Aviary(string location)
        {
            this.currentLocation = location;
        }
        public Aviary()
        {

        }

    }
}