using System;

namespace Zoolandia.Animals
{
    class Haliaeetus_leucocephalus: Animal
    {
        public int wingspan = 1;
        public int age = 0;
        public bool canFly = true;
        public bool canSwim = true;
        public bool canWalk = true;
        public bool canClimb = false;
        public bool carnivore = true;
        public int numOfWings = 2;
        public string domain = "air, trees, nests";
        public string brainSize = "medium";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} Jerome is eating a fish that he caught 20 feet below the surface of the ocean. He was particulary hungry today.";
        }
        public Haliaeetus_leucocephalus()
        {
            this.name = "Jerome";
        }
        public Haliaeetus_leucocephalus(string args)
        {
            string name = args;
        }
        public Haliaeetus_leucocephalus(int args)
        {
            this.age = args;
        }
        public Haliaeetus_leucocephalus(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
