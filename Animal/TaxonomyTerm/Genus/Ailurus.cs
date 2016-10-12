namespace Zoolandia.Animals
{
    public class Ailurus: Genus
    {
        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Red_panda";
            this.trait = "cuteness";
            this.commonName = "Red Panda";
            this.genus = "Ailurus";
        }
        public Ailurus()
        {
            this.init();
        } 
    }
}