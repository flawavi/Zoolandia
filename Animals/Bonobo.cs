using System;

namespace Zoolandia.Animals
{
    class Pan_paniscus: Animal
    {
        public bool omnivore = true;
        public bool canSwim = false;
        public bool canFly = false;
        public bool canWalk = true;
        public bool canClimb = true;
        public int numOfLimbs = 4;
        public string domain = "forest";
        public string brainSize = "large";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"Jeremy is eating a platter full of creepy crawlies. Times are hard.";
        }
        public Pan_paniscus()
        {
            this.name = "Jeremy";
        }
    }
}

