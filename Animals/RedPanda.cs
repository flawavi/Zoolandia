using System;

namespace Zoolandia.Animals
{
    public class Ailurus: Animal
    {
        public bool omnivore = true;
        public bool canSwim = false;
        public bool canFly = false;
        public bool canWalk = true;
        public bool canClimb = true;
        public int numOfLimbs = 4;        
        public string coloration = "red, black, white";
        public string brainSize = "medium";
    }
    public class fulgens: Ailurus
    {
        public int age = 0;
        public string domain = "forest";
        public string commonName = "Red Panda";
        public string scientificName = "Ailurus_fulgens";
        public override string eat()
        {   
            string parentMessage = base.eat();
            return $"{parentMessage} Jerrod is eating bamboo. He looks very cute while he eats bamboo. Bamboo is all he ever eats."; 
        }
        public override string sleep()
        {   
            string parentMessage = base.sleep();
            return $"{parentMessage} Zzz..."; 
        }
        public override string speak()
        {   
            string parentMessage = base.speak();
            return $"{parentMessage} Squeak."; 
        }
        public override string play()
        {   
            string parentMessage = base.play();
            return $"{parentMessage} Awww. That's cute."; 
        }
        public void Ailurus_fulgens()
        {
            this.name = "Jerrod";
        }
        public void Ailurus_fulgens(string args)
        {
            string name = args;
        }
        public void Ailurus_fulgens(int args)
        {
            this.age = args;
        }
        public void Ailurus_fulgens(string[] args)
        {
            this.age = Convert.ToInt16(args[0]);
            this.name = args[1];
        }
        public void Ailurus_fulgens(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}