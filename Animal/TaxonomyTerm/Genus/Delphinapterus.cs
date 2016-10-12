namespace Zoolandia.Animals
{
    public class Delphinapterus: Genus
    {
        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Beluga_whale";
            this.trait = "Language";
            this.commonName = "Beluga";
            this.genus = "Delphinapterus";
        }
        public Delphinapterus()
        {
        this.init();
        } 
    }
}