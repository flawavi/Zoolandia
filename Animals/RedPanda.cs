using System;

namespace Zoolandia.Animals
{
    class Ailurus_fulgens: Animal
    {
        public bool omnivore = true;
        public int age = 0;
        public bool canSwim = false;
        public bool canWalk = true;
        public bool canFly = false;
        public bool canClimb = true;
        public int numOfLimbs = 4;
        public string coloration = "red, black, white";
        public string brainSize = "medium";
        public string domain = "forest";
        public override string eat()
        {   
            string parentMessage = base.eat();
            return $"{parentMessage} Jerrod is eating bamboo. He looks very cute while he eats bamboo. Bamboo is all he ever eats."; 
        }
        public Ailurus_fulgens()
        {
            this.name = "Jerrod";
        }
        public Ailurus_fulgens(string args)
        {
            string name = args;
        }
        public Ailurus_fulgens(int args)
        {
            this.age = args;
        }
        public Ailurus_fulgens(string[] args)
        {
            this.age = Convert.ToInt16(args[0]);
            this.name = args[1];
        }
        public Ailurus_fulgens(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}