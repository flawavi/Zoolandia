using System;

namespace Zoolandia.Animals
{
    public class Haliaeetus: Animal
    {
        public bool canFly = true;
        public bool canSwim = true;
        public bool canWalk = true;
        public bool canClimb = false;
        public string domain = "air, trees, nests";
        public string brainSize = "medium";
    }
    public class leucocephalus: Haliaeetus
    {
        public int wingspan = 1;
        public bool carnivore = true;
        public int age = 0;
        public int numOfWings = 2;
        public string commonName = "Bald Eagle";
        public string scientificName = "Haliaeetus leucocephalus";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} Jerome is eating a fish that he caught 20 feet below the surface of the ocean. He was particulary hungry today.";
        }
        public override string sleep()
        {
            string parentMessage = base.sleep();
            return $"{parentMessage} Dreaming of stampedes of mice.";
        }
        public override string play()
        {
            string parentMessage = base.play();
            return $"{parentMessage}.. Playing with his food!";
        }
        public override string speak()
        {
            string parentMessage = base.speak();
            return $"{parentMessage} Squawk.";
        }
        public void Haliaeetus_leucocephalus()
        {
            this.name = "Jerome";
        }
        public void Haliaeetus_leucocephalus(string args)
        {
            string name = args;
        }
        public void Haliaeetus_leucocephalus(int args)
        {
            this.age = args;
        }
        public void Haliaeetus_leucocephalus(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
