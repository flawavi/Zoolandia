using System;

namespace Zoolandia.Animals
{
    class Ailurus_fulgens: Animal
    {
        public bool omnivore = true;
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
    }
}