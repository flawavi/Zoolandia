using System;
using Zoolandia.Animals;
using Zoolandia.Habitats;
using Zoolandia.ZoologicalParks;
using System.Collections.Generic;

namespace Zoolandia
{
    class Zoolandia
    {
        public static void Main(string[] args)
        {
            Sahara sahara = new Sahara();
            sahara.name = "Jerry's Sahara";

            Aviary aviary = new Aviary();
            aviary.name = "Jerome's Aviary";

            Pool pool = new Pool();
            pool.name = "Geraldo's Pool";

            Jungle jungle = new Jungle();
            jungle.name = "Jerith's Jungle Jym";

            Zoo zoolandia = new Zoo();
            zoolandia.habitats.Add(aviary);
            zoolandia.habitats.Add(sahara);
            zoolandia.habitats.Add(pool);
            zoolandia.habitats.Add(jungle);

            Bonobo berry = new Bonobo();
            berry.name = "Berry";
            berry.species = new Pan_paniscus();

            Dolphin dolf = new Dolphin();
            dolf.name = "Dolf";
            dolf.species = new Delphinapterus_leucas();
            dolf.swim();

            Eagle baldy = new Eagle();
            baldy.name = "Baldy";
            baldy.species = new Haliaeetus_leucocephalus();
            baldy.airspeed = 10;
            baldy.fly();

            Elephant elly = new Elephant();
            elly.name = "Elly";
            elly.species = new Loxodonta_adaurora();

            RedPanda perry = new RedPanda();
            perry.species = new Ailurus_fulgens();
            perry.name = "Perry";

            Turtle terry = new Turtle();
            terry.species = new Chelonoidis_nigra();
            terry.name = "Terry";
            terry.swim();

            sahara.inhabitants.Add(elly);
            sahara.inhabitants.Add(terry);

            jungle.inhabitants.Add(berry);
            jungle.inhabitants.Add(perry);

            aviary.inhabitants.Add(baldy);

            pool.inhabitants.Add(dolf);

            Console.WriteLine($"{zoolandia.slogan()}\n========================================");
            foreach(Habitat habitat in zoolandia.habitats)
            {
                Console.WriteLine($"\n{habitat.name}\nAnimals in this habitat:");
                    foreach (Animal animal in habitat.inhabitants)
                    {
                        Console.WriteLine($@"   {animal.name} the {animal.species.commonName} in the genus {animal.species.genusSpeciesEpithet}.
                        More info: {animal.species.url}.");
                    }
            }
        }
    }
}
