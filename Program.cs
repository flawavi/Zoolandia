using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal eagle = new Haliaeetus_leucocephalus();
            eagle.birthDate = Convert.ToDateTime("10/06/2016");
            eagle.height = 1;
            eagle.weight = 1;
            eagle.name = "Jerome";

            Animal bonobo = new Pan_paniscus();
            bonobo.birthDate = Convert.ToDateTime("01/01/2000");
            bonobo.height = 3;
            bonobo.weight = 50;
            bonobo.name = "Jeremy";

            Animal redPanda = new Ailurus_fulgens();
            redPanda.birthDate = Convert.ToDateTime("02/02/2002");
            redPanda.height = 2;
            redPanda.weight = 25;
            redPanda.name = "Jerrod";

            Animal dolphin = new Delphinapterus_leucas();
            dolphin.birthDate = Convert.ToDateTime("06/06/2006");
            dolphin.height = 5;
            dolphin.weight = 3000;
            dolphin.name = "Jerluga";

            // Console.WriteLine("I have an eagle named {0}. He was born on {1}. He is {2}ft tall and weighs {3}lbs. Don't fuck with him.", eagle.name, eagle.birthDate, eagle.height, eagle.weight);
            // Console.WriteLine("I have a bonobo named {0}. He was born on {1}. He is {2}ft tall and weighs {3}lbs. Don't fuck with him.", bonobo.name, bonobo.birthDate, bonobo.height, bonobo.weight);
            // Console.WriteLine("I have an red panda named {0}. He was born on {1}. He is {2}ft tall and weighs {3}lbs. Don't fuck with him.", redPanda.name, redPanda.birthDate, redPanda.height, redPanda.weight);
            // Console.WriteLine("I have an dolphin named {0}. He was born on {1}. He is {2}ft tall and weighs {3}lbs. Don't fuck with him.", dolphin.name, dolphin.birthDate, dolphin.height, dolphin.weight);

            // Haliaeetus_leucocephalus Eagle = new Haliaeetus_leucocephalus();
            // Console.WriteLine(Eagle.name);
            // Ailurus_fulgens RedPanda = new Ailurus_fulgens();
            // Console.WriteLine(RedPanda.name);
            // Pan_paniscus Bonobo = new Pan_paniscus();
            // Console.WriteLine(Bonobo.name);
            // Delphinapterus_leucas Dolphin = new Delphinapterus_leucas();
            // Console.WriteLine(Dolphin.name);

            // Haliaeetus_leucocephalus Eagle = new Haliaeetus_leucocephalus("Jerome");
            // Console.WriteLine(Eagle.name);
            // Ailurus_fulgens RedPanda = new Ailurus_fulgens("Jeremy");
            // Console.WriteLine(RedPanda.name);
            // Pan_paniscus Bonobo = new Pan_paniscus("Jerrod");
            // Console.WriteLine(Bonobo.name);
            // Delphinapterus_leucas Dolphin = new Delphinapterus_leucas("Jerluga");
            // Console.WriteLine(Dolphin.name);

            // Haliaeetus_leucocephalus Eagle = new Haliaeetus_leucocephalus(10);
            // Console.WriteLine(Eagle.age);
            // Ailurus_fulgens RedPanda = new Ailurus_fulgens(5);
            // Console.WriteLine(RedPanda.age);
            // Pan_paniscus Bonobo = new Pan_paniscus(31);
            // Console.WriteLine(Bonobo.age);
            // Delphinapterus_leucas Dolphin = new Delphinapterus_leucas(40);
            // Console.WriteLine(Dolphin.age);

            Haliaeetus_leucocephalus Eagle = new Haliaeetus_leucocephalus("Jerome", 10);
            Console.WriteLine($"{Eagle.name} {Eagle.age}");
            Ailurus_fulgens RedPanda = new Ailurus_fulgens("Jeremy", 5);
            Console.WriteLine($"{RedPanda.name} {RedPanda.age}");
            Pan_paniscus Bonobo = new Pan_paniscus("Jerrod", 31);
            Console.WriteLine($"{Bonobo.name} {Bonobo.age}");
            Delphinapterus_leucas Dolphin = new Delphinapterus_leucas("Jerluga", 40);
            Console.WriteLine($"{Dolphin.name} {Dolphin.age}");
        }
    }
}
