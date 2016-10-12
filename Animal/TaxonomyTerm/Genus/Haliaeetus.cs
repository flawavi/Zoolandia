namespace Zoolandia.Animals
{
    public class Haliaeetus: Genus
    {
        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Bald_eagle";
            this.trait = "Flight";
            this.commonName = "Bald Eagle";
            this.genus = "Haliaeetus";
        }
        public Haliaeetus()
        {
        this.init();
        } 
    }
}