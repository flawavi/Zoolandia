using System;

namespace Zoolandia.Animals
{
    class Pan_paniscus: Animal
    {
        public bool omnivore = true;
        public int age = 0;
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
        public Pan_paniscus(string args)
        {
            string name = args;
        }
        public Pan_paniscus(int args)
        {
            this.age = args;
        }
        public Pan_paniscus(string[] args)
        {
            this.age = Convert.ToInt16(args[0]);
            this.name = args[1];
        }
        public Pan_paniscus(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}

