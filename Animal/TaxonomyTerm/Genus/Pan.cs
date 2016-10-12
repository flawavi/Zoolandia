namespace Zoolandia.Animals
{
    public class Pan: Genus
    {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Bonobo";
      this.trait = "intelligence";
      this.commonName = "Bonobo";
      this.genus = "Pan";
    }
        public Pan()
        {
        this.init();
        }
    }
}