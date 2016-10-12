namespace Zoolandia.Animals
{
    public class Chelonoidis: Genus
    {
        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Beluga_whale";
            this.trait = "Longevity";
            this.commonName = "Galápagos Tortoise";
            this.genus = "Chelonoidis";
        }
        public Chelonoidis()
        {
        this.init();
        } 
    }
}