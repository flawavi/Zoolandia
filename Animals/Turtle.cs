using System;

namespace Zoolandia.Animals
{
    public class Chelonoidis: Animal
    {
        public bool canFly = true;
        public bool canSwim = true;
        public bool canWalk = true;
        public bool canClimb = false;
        public string brainSize = "medium";
    }
    public class nigra: Chelonoidis
    {
        public int age = 100;
        public string commonName = "Giant Tortoise";
        public string scientificName = "Chelonoidis nigra";
        public string shellColor = "tortoise shell";
        public string fightingStyle = "ninja";
        public string domain = "Galapagos";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} Don't get your fingers anywhere near my mouth.";
        }
        public override string sleep()
        {
            string parentMessage = base.sleep();
            return $"{parentMessage} I'm actually not sleeping; it just looks like I am because I'm a huge turtle.";
        }
        public override string play()
        {
            string parentMessage = base.play();
            return $"{parentMessage} Let's play a game called who can get there last.";
        }
        public override string speak()
        {
            string parentMessage = base.speak();
            return $"{parentMessage} Please speak slowly. I'm a turtle after all.";
        }
    }
}