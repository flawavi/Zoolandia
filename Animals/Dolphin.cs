using System;

namespace Zoolandia.Animals
{
    class Delphinapterus_leucas: Animal
    {
        public bool canSwim = true;
        public bool canWalk = false;
        public bool canFly = false;
        public bool canClimb = false;
        public int numOfFins = 4;
        public string brainSize = "large";
        public string coloration = "white";
        public string domain = "water";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} Jerluga is eating so many plankton. She requires 2 million plankton per day, give or take a couple.";
        }
        public Delphinapterus_leucas()
        {
            this.name = "Jerluga";
        }
    }
}