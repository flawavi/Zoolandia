namespace Zoolandia.Animals
{
    public class Loxodonta: Genus
    {
        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Bonobo";
            this.trait = "emotion intelligence";
            this.commonName = "African Elephant";
            this.genus = "Loxodonta";
        }
        public Loxodonta()
        {
        this.init();
        } 
    }
}