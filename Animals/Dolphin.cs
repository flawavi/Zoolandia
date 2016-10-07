using System;

namespace Zoolandia.Animals
{
    public class Delphinapterus: Animal
    {
        public string domain = "water";
        public bool canWalk = false;
        public bool canSwim = true;
        public int numOfFins = 4;
        
    }
    public class leucas: Delphinapterus
    {
        
        public int age = 0;
        public bool canFly = false;
        public bool canClimb = false;
        public string brainSize = "large";
        public string coloration = "white";
        public string commonName = "Dolphin";
        public string scientificName = "Delphinapterus leucas";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} Jerluga is eating so many plankton. She requires 2 million plankton per day, give or take a couple.";
        }
        public override string sleep()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} Sleeping underwater must be nice.";
        }
        public override string play()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} They can make air rings with their blow holes and toss them around. Pretty neat!";
        }
        public override string speak()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} *Classic dolphin screaches.";
        }
        public void Delphinapterus_leucas()
        {
            this.name = "Jerluga";
        }
        public void Delphinapterus_leucas(string args)
        {
            string name = args;
        }
        public void Delphinapterus_leucas(int args)
        {
            this.age = args;
        }
        public void Delphinapterus_leucas(string[] args)
        {
            this.age = Convert.ToInt16(args[0]);
            this.name = args[1];
        }
        public Delphinapterus_leucas(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}